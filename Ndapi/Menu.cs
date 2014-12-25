using Ndapi.Core.Handles;
using Ndapi.Enums;
using System.Collections.Generic;

namespace Ndapi
{
    /// <summary>
    /// Represents a menu object.
    /// </summary>
    public class Menu : NdapiObject
    {
        /// <summary>
        /// Creates a new menu.
        /// </summary>
        /// <param name="module">Menu owner.</param>
        /// <param name="name">Menu name</param>
        public Menu(FormModule module, string name)
        {
            Create(name, ObjectType.Menu, module);
        }

        /// <summary>
        /// Creates a new menu.
        /// </summary>
        /// <param name="module">Menu owner.</param>
        /// <param name="name">Menu name</param>
        public Menu(MenuModule module, string name)
        {
            Create(name, ObjectType.Menu, module);
        }

        internal Menu(ObjectSafeHandle handle) : base(handle)
        {
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
        /// Gets or sets the subtitle.
        /// </summary>
        public string Subtitle
        {
            get { return GetStringProperty(NdapiConstants.D2FP_SUB_TTL); }
            set { SetStringProperty(NdapiConstants.D2FP_SUB_TTL, value); }
        }

        /// <summary>
        /// Gets or sets whether the menu is a tear-off menu.
        /// </summary>
        public bool TearOffMenu
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_TEAR_OFF_MNU); }
            set { SetBooleanProperty(NdapiConstants.D2FP_TEAR_OFF_MNU, value); }
        }

        /// <summary>
        /// Gets the menu items.
        /// </summary>
        public IEnumerable<MenuItem> MenuItems => GetObjectList<MenuItem>(NdapiConstants.D2FP_MNU_ITM);
    }
}
