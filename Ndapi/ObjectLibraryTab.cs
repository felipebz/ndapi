using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ndapi.Core.Handles;
using Ndapi.Enums;
using Ndapi.Core;

namespace Ndapi
{
    public class ObjectLibraryTab : NdapiObject
    {
        public ObjectLibraryTab(FormModule module, string name)
        {
            Create(name, ObjectType.ObjectLibraryTab, module);
        }

        internal ObjectLibraryTab(ObjectSafeHandle handle) : base(handle)
        {
        }

        public string Comment
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COMMENT); }
            set { SetStringProperty(NdapiConstants.D2FP_COMMENT, value); }
        }

        public string Label
        {
            get { return GetStringProperty(NdapiConstants.D2FP_LABEL); }
            set { SetStringProperty(NdapiConstants.D2FP_LABEL, value); }
        }

        public int ObjectCount => GetNumberProperty(NdapiConstants.D2FP_OBJ_COUNT);

        public IEnumerable<NdapiObject> Objects
        {
            get
            {
                for (var i = 1; i <= ObjectCount; i++) // objects index is one-based
                {
                    yield return GetObjectByPosition(i);
                }
            }
        }

        public NdapiObject GetObjectByPosition(int position)
        {
            ObjectSafeHandle obj;
            var status = NativeMethods.d2foltf2_Findobjbypos(NdapiContext.Context, _handle, position, out obj);
            Ensure.Success(status);

            if (obj.IsInvalid)
            {
                return null;
            }

            return new NdapiObject(obj);
        }
    }
}
