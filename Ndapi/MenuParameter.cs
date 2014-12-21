using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    public class MenuParameter : NdapiObject
    {
        public MenuParameter(MenuModule module, string name)
        {
            Create(name, ObjectType.MenuParameter, module);
        }

        internal MenuParameter(ObjectSafeHandle handle) : base(handle)
        {
        }

        public int AssociatedMenusCount
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_ASSOC_MENUS_COUNT); }
        }

        public CaseRestriction CaseRestriction
        {
            get { return GetNumberProperty<CaseRestriction>(NdapiConstants.D2FP_CASE_RSTRCTION); }
            set { SetNumberProperty(NdapiConstants.D2FP_CASE_RSTRCTION, value); }
        }

        public string Comment
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COMMENT); }
            set { SetStringProperty(NdapiConstants.D2FP_COMMENT, value); }
        }

        public bool ConcealData
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_CONCEAL_DATA); }
            set { SetBooleanProperty(NdapiConstants.D2FP_CONCEAL_DATA, value); }
        }

        public bool FixedLength
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_FIXED_LEN); }
            set { SetBooleanProperty(NdapiConstants.D2FP_FIXED_LEN, value); }
        }

        public string Hint
        {
            get { return GetStringProperty(NdapiConstants.D2FP_HINT); }
            set { SetStringProperty(NdapiConstants.D2FP_HINT, value); }
        }

        public string Label
        {
            get { return GetStringProperty(NdapiConstants.D2FP_LABEL); }
            set { SetStringProperty(NdapiConstants.D2FP_LABEL, value); }
        }

        public int MaximumLength
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_MAX_LEN); }
            set { SetNumberProperty(NdapiConstants.D2FP_MAX_LEN, value); }
        }

        public string InitialValue
        {
            get { return GetStringProperty(NdapiConstants.D2FP_MNU_PARAM_INIT_VAL); }
            set { SetStringProperty(NdapiConstants.D2FP_MNU_PARAM_INIT_VAL, value); }
        }
    }
}
