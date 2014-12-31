using Ndapi.Core;
using Ndapi.Enums;
using System;
using System.Runtime.InteropServices;

namespace Ndapi
{
    /// <summary>
    /// Property utilities.
    /// </summary>
    public static class Property
    {
        /// <summary>
        /// Gets the property type.
        /// </summary>
        /// <param name="property">Property id (see <see cref="NdapiConstants"/>).</param>
        /// <returns>The property type.</returns>
        public static PropertyType GetPropertyType(int property) => NativeMethods.d2fprgt_GetType(NdapiContext.Context, property);

        /// <summary>
        /// Gets the property name.
        /// </summary>
        /// <param name="property">Property id (see <see cref="NdapiConstants"/>).</param>
        /// <returns>The property name.</returns>
        public static string GetName(int property)
        {
            string name;
            var status = NativeMethods.d2fprgn_GetName(NdapiContext.Context, property, out name);
            Ensure.Success(status);
            return name;
        }

        /// <summary>
        /// Gets the value name.
        /// </summary>
        /// <param name="property">Property id (see <see cref="NdapiConstants"/>).</param>
        /// <param name="value">Value id (see <see cref="NdapiConstants"/>).</param>
        /// <returns>The value name.</returns>
        public static string GetValueName(int property, int value)
        {
            string name;
            var status = NativeMethods.d2fprgvn_GetValueName(NdapiContext.Context, property, value, out name);
            Ensure.Success(status);
            return name;
        }

        /// <summary>
        /// Gets the constant value.
        /// </summary>
        /// <param name="constant">Constant name.</param>
        /// <returns>The constant value.</returns>
        public static int GetConstantValue(string constant)
        {
            int value;
            var status = NativeMethods.d2fprgcv_GetConstValue(NdapiContext.Context, constant, out value);
            Ensure.Success(status);
            return value;
        }

        /// <summary>
        /// Gets the constant name.
        /// </summary>
        /// <param name="constant">Constant id (see <see cref="NdapiConstants"/>).</param>
        /// <returns>The constant name.</returns>
        public static string GetConstantName(int constant)
        {
            string name;
            var status = NativeMethods.d2fprgcn_GetConstName(NdapiContext.Context, constant, out name);
            Ensure.Success(status);
            return name;
        }
    }
}
