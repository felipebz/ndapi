using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Ndapi.Core;

internal sealed class NdapiObjectRegistry
{
    private readonly Dictionary<IntPtr, NdapiObject> _trackedObjects = new();

    public bool TryGetObject(IntPtr pointer, [NotNullWhen(true)] out NdapiObject? obj)
        => _trackedObjects.TryGetValue(pointer, out obj);

    public void TrackObject(IntPtr pointer, NdapiObject obj)
        => _trackedObjects[pointer] = obj;

    public void UntrackObject(IntPtr pointer)
        => _trackedObjects.Remove(pointer);

    public void Clear()
        => _trackedObjects.Clear();
}
