using System;
using System.Collections.Generic;
using System.Linq;

namespace Ndapi.Metadata
{
    public static class NdapiMetadata
    {
        private static readonly Lazy<IEnumerable<Type>> _classes = new Lazy<IEnumerable<Type>>(LoadClasses);

        public static IEnumerable<Type> Classes => _classes.Value;

        private static IEnumerable<Type> LoadClasses()
        {
            return typeof(NdapiContext).Assembly.GetTypes().Where(t => t.BaseType == typeof(NdapiObject));
        }

        public static NdapiMetaObject GetMetaObjectFrom(Type type)
        {
            return new NdapiMetaObject(type);
        }
    }
}
