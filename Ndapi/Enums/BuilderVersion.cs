using System;

namespace Ndapi.Enums;

public record BuilderVersion(int FullVersion)
{
    public Version Version { get; } =
        new(FullVersion / 10_000_000, (FullVersion / 1_000_000) % 10, (FullVersion / 10_000) % 100,
            (FullVersion / 100) % 100);

    public int MajorVersion => Version.Major;

    public static BuilderVersion Forms6 { get; } = new(60000000);
    public static BuilderVersion Forms12213 { get; } = new(122010300);
}
