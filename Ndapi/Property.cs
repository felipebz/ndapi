using Ndapi.Core;
using Ndapi.Enums;

namespace Ndapi
{
    public static class Property
    {
        public static PropertyType GetPropertyType(int property) => NativeMethods.d2fprgt_GetType(NdapiContext.Context, property);

        public static string GetName(int property)
        {
            string name;
            var status = NativeMethods.d2fprgn_GetName(NdapiContext.Context, property, out name);
            Ensure.Success(status);
            return name;
        }

        public static string GetValueName(int property, int value)
        {
            string name;
            var status = NativeMethods.d2fprgvn_GetValueName(NdapiContext.Context, property, value, out name);
            Ensure.Success(status);
            return name;
        }

        public static int GetConstantValue(string constant)
        {
            int value;
            var status = NativeMethods.d2fprgcv_GetConstValue(NdapiContext.Context, constant, out value);
            Ensure.Success(status);
            return value;
        }

        public static string GetConstantName(int property)
        {
            string name;
            var status = NativeMethods.d2fprgcn_GetConstName(NdapiContext.Context, property, out name);
            Ensure.Success(status);
            return name;
        }
    }
}
