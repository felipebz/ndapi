using System.Collections.Concurrent;
using System.Runtime.ExceptionServices;

namespace Ndapi.Tests;

/// <summary>
/// Runs test bodies on one long-lived thread, STA on Windows.
/// The Forms 6i Open API initialises OLE and refuses to create a context on an MTA thread (the test runner
/// threads are MTA), and destroying the context and creating a new one in the same process crashes
/// d2fctxde_Destroy. So every test shares a single thread and a single context that lives until the process ends.
/// Apartment states don't exist on Linux (Forms 12c/14c), where only the single thread and context matter.
/// </summary>
internal static class Sta
{
    private static readonly BlockingCollection<Action> Queue = new();

    static Sta()
    {
        var thread = new Thread(() =>
        {
            foreach (var action in Queue.GetConsumingEnumerable())
            {
                action();
            }
        })
        {
            IsBackground = true,
            Name = "Forms API (STA)"
        };
        if (OperatingSystem.IsWindows())
        {
            thread.SetApartmentState(ApartmentState.STA);
        }

        thread.Start();
    }

    public static void Run(Action action)
    {
        ExceptionDispatchInfo? error = null;
        using var done = new ManualResetEventSlim();
        Queue.Add(() =>
        {
            try
            {
                action();
            }
            catch (Exception e)
            {
                error = ExceptionDispatchInfo.Capture(e);
            }
            finally
            {
                done.Set();
            }
        });
        done.Wait();
        error?.Throw();
    }
}
