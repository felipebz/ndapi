using System.Runtime.ExceptionServices;

namespace Ndapi.Tests;

/// <summary>
/// The Forms 6i Open API initialises OLE and refuses to create a context on an MTA thread,
/// and the test runner threads are MTA. Every test body runs on a dedicated STA thread.
/// </summary>
internal static class Sta
{
    public static void Run(Action action)
    {
        ExceptionDispatchInfo? error = null;
        var thread = new Thread(() =>
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
                NdapiContext.Destroy();
            }
        });
        thread.SetApartmentState(ApartmentState.STA);
        thread.Start();
        thread.Join();
        error?.Throw();
    }
}
