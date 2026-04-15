using System;
using System.Collections.Generic;

namespace Ndapi.Core;

internal class NdapiObjectRegistry
{
    private readonly Dictionary<IntPtr, NdapiObject> _trackedObjects = new();

    public bool TryGetObject(IntPtr pointer, out NdapiObject obj) 
        => _trackedObjects.TryGetValue(pointer, out obj);

    public void TrackObject(IntPtr pointer, NdapiObject obj) 
        => _trackedObjects[pointer] = obj;
    
    public void UntrackObject(IntPtr pointer) 
        => _trackedObjects.Remove(pointer);

    public void Clear() 
        => _trackedObjects.Clear();
}
