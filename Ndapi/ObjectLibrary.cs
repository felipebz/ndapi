using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ndapi.Core.Handles;
using Ndapi.Core;
using Ndapi.Enums;

namespace Ndapi
{
    public class ObjectLibrary : NdapiObject
    {
        public ObjectLibrary(string name)
        {
            Create(name, ObjectType.ObjectLibrary);
        }

        internal ObjectLibrary(ObjectSafeHandle handle) : base(handle)
        {
        }

        public int ObjectCount => GetNumberProperty(NdapiConstants.D2FP_OBJ_COUNT);

        public IEnumerable<ObjectLibraryTab> Tabs => GetObjectList<ObjectLibraryTab>(NdapiConstants.D2FP_OBJ_LIB_TAB);

        public IEnumerable<NdapiObject> Objects
        {
            get
            {
                for (var i = 1; i<= ObjectCount; i++) // objects index is one-based
                {
                    yield return GetObjectByPosition(i);
                }
            }
        }

        public static ObjectLibrary Open(string filename)
        {
            ObjectSafeHandle form;

            var status = NativeMethods.d2folbld_Load(NdapiContext.Context, out form, filename, false);
            Ensure.Success(status);

            return new ObjectLibrary(form);
        }

        public NdapiObject GetObjectByPosition(int position)
        {
            ObjectSafeHandle obj;
            var status = NativeMethods.d2folbf2_Findobjbypos(NdapiContext.Context, _handle, position, out obj);
            Ensure.Success(status);

            if (obj.IsInvalid)
            {
                return null;
            }

            return new NdapiObject(obj);
        }
    }
}
