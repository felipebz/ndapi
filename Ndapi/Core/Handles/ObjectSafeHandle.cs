namespace Ndapi.Core.Handles;

internal sealed class ObjectSafeHandle : SafeHandleBase
{
    protected override bool ReleaseHandleImpl()
    {
        return true;
    }
}
