using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;
using System.Collections.Generic;

namespace Ndapi
{
    /// <summary>
    /// Represents a menu module parameter.
    /// </summary>
    public class MenuParameter : NdapiObject
    {
        /// <summary>
        /// Creates a new menu parameter.
        /// </summary>
        /// <param name="module">Parameter owner.</param>
        /// <param name="name">Parameter name.</param>
        public MenuParameter(MenuModule module, string name) : base(name, ObjectType.MenuParameter, module)
        {
        }

        internal MenuParameter(ObjectSafeHandle handle) : base(handle)
        {
        }

        /// <summary>
        /// Gets the number of associated menus.
        /// </summary>
        public int AssociatedMenusCount => GetNumberProperty(NdapiConstants.D2FP_ASSOC_MENUS_COUNT);

        /// <summary>
        /// Gets or sets the case restriction.
        /// </summary>
        public CaseRestriction CaseRestriction
        {
            get { return GetNumberProperty<CaseRestriction>(NdapiConstants.D2FP_CASE_RSTRCTION); }
            set { SetNumberProperty(NdapiConstants.D2FP_CASE_RSTRCTION, value); }
        }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        public string Comment
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COMMENT); }
            set { SetStringProperty(NdapiConstants.D2FP_COMMENT, value); }
        }

        /// <summary>
        /// Gets or sets whether runtime should hide characters that the user types into the text item. 
        /// </summary>
        public bool ConcealData
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_CONCEAL_DATA); }
            set { SetBooleanProperty(NdapiConstants.D2FP_CONCEAL_DATA, value); }
        }

        /// <summary>
        /// Gets or sets whether the length is fixed.
        /// </summary>
        public bool FixedLength
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_FIXED_LEN); }
            set { SetBooleanProperty(NdapiConstants.D2FP_FIXED_LEN, value); }
        }

        /// <summary>
        /// Gets or sets the parameter hint.
        /// </summary>
        public string Hint
        {
            get { return GetStringProperty(NdapiConstants.D2FP_HINT); }
            set { SetStringProperty(NdapiConstants.D2FP_HINT, value); }
        }

        /// <summary>
        /// Gets or sets the label of the associated text item.
        /// </summary>
        public string Label
        {
            get { return GetStringProperty(NdapiConstants.D2FP_LABEL); }
            set { SetStringProperty(NdapiConstants.D2FP_LABEL, value); }
        }

        /// <summary>
        /// Gets or sets the maximum length.
        /// </summary>
        public int MaximumLength
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_MAX_LEN); }
            set { SetNumberProperty(NdapiConstants.D2FP_MAX_LEN, value); }
        }

        /// <summary>
        /// Gets or sets the initial value.
        /// </summary>
        public string InitialValue
        {
            get { return GetStringProperty(NdapiConstants.D2FP_MNU_PARAM_INIT_VAL); }
            set { SetStringProperty(NdapiConstants.D2FP_MNU_PARAM_INIT_VAL, value); }
        }

        /// <summary>
        /// Gets the menu item roles.
        /// </summary>
        public IEnumerable<string> AssociatedMenus
        {
            get
            {
                for (var i = 1; i <= AssociatedMenusCount; i++) // objects index is one-based
                {
                    yield return GetAssociatedMenuAt(i);
                }
            }
        }

        /// <summary>
        /// Inserts an associated menu in the specified index.
        /// </summary>
        /// <param name="index">The one-based index at which associated menu should be inserted.</param>
        /// <param name="menu">Associated menu name.</param>
        public void AddAssociatedMenuAt(int index, string menu)
        {
            var status = NativeMethods.d2fmpmaam_AddAssocMenu(NdapiContext.Context, _handle, index, menu);
            Ensure.Success(status);
        }

        /// <summary>
        /// Deletes the associated menu in the specified index.
        /// </summary>
        /// <param name="index">The one-based index at which associated menu should be removed.</param>
        public void DeleteAssociatedMenuAt(int index)
        {
            var status = NativeMethods.d2fmpmram_RemoveAssocMenu(NdapiContext.Context, _handle, index);
            Ensure.Success(status);
        }

        /// <summary>
        /// Gets the associated menu in the specified index.
        /// </summary>
        /// <param name="index">The one-based index of the associated menu.</param>
        /// <returns>The associated menu name.</returns>
        public string GetAssociatedMenuAt(int index)
        {
            string menu;
            var status = NativeMethods.d2fmpmgam_GetAssocMenu(NdapiContext.Context, _handle, index, out menu);
            Ensure.Success(status);
            return menu;
        }
    }
}
