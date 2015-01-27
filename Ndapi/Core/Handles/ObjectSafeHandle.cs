namespace Ndapi.Core.Handles
{
    internal class ObjectSafeHandle : SafeHandleBase
    {
        protected override bool ReleaseHandleImpl()
        {
            return true;
        }
    }
}
