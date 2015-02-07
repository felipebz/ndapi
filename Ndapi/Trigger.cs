using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    /// <summary>
    /// Represents a trigger object.
    /// </summary>
    public class Trigger : NdapiObject<Trigger>
    {
        /// <summary>
        /// Creates a trigger.
        /// </summary>
        /// <param name="module">Trigger owner.</param>
        /// <param name="name">Trigger name.</param>
        public Trigger(FormModule module, string name) : base(name, ObjectType.Trigger, module)
        {
        }

        /// <summary>
        /// Creates a trigger.
        /// </summary>
        /// <param name="group">Trigger owner.</param>
        /// <param name="name">Trigger name.</param>
        public Trigger(ObjectGroup group, string name) : base(name, ObjectType.Trigger, group)
        {
        }

        /// <summary>
        /// Creates a trigger.
        /// </summary>
        /// <param name="block">Trigger owner.</param>
        /// <param name="name">Trigger name.</param>
        public Trigger(Block block, string name) : base(name, ObjectType.Trigger, block)
        {
        }

        /// <summary>
        /// Creates a trigger.
        /// </summary>
        /// <param name="item">Trigger owner.</param>
        /// <param name="name">Trigger name.</param>
        public Trigger(Item item, string name) : base(name, ObjectType.Trigger, item)
        {
        }

        /// <summary>
        /// Creates a trigger.
        /// </summary>
        /// <param name="propertyClass">Trigger owner.</param>
        /// <param name="name">Trigger name.</param>
        public Trigger(PropertyClass propertyClass, string name) : base(name, ObjectType.Trigger, propertyClass)
        {
        }

        internal Trigger(ObjectSafeHandle handle) : base(handle)
        {
        }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        [Property(NdapiConstants.D2FP_COMMENT)]
        public string Comment
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COMMENT); }
            set { SetStringProperty(NdapiConstants.D2FP_COMMENT, value); }
        }

        /// <summary>
        /// Gets or sets whether runtime should display the trigger in keyboard help.
        /// </summary>
        [Property(NdapiConstants.D2FP_DISP_IN_KBRD_HLP)]
        public bool DisplayInKeyboardHelp
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_DISP_IN_KBRD_HLP); }
            set { SetBooleanProperty(NdapiConstants.D2FP_DISP_IN_KBRD_HLP, value); }
        }

        /// <summary>
        /// Gets or sets the execution style.
        /// </summary>
        [Property(NdapiConstants.D2FP_EXEC_HIERARCHY)]
        public ExecutionStyle ExecutionStyle
        {
            get { return GetNumberProperty<ExecutionStyle>(NdapiConstants.D2FP_EXEC_HIERARCHY); }
            set { SetNumberProperty(NdapiConstants.D2FP_EXEC_HIERARCHY, value); }
        }

        /// <summary>
        /// Gets or sets whether runtime should fire the trigger in enter-query mode.
        /// </summary>
        [Property(NdapiConstants.D2FP_FIRE_IN_QRY)]
        public bool FireInEnterQueryMode
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_FIRE_IN_QRY); }
            set { SetBooleanProperty(NdapiConstants.D2FP_FIRE_IN_QRY, value); }
        }

        /// <summary>
        /// Gets or sets the keyboard help description.
        /// </summary>
        [Property(NdapiConstants.D2FP_KBRD_HLP_TXT)]
        public string KeyboardHelpDescription
        {
            get { return GetStringProperty(NdapiConstants.D2FP_KBRD_HLP_TXT); }
            set { SetStringProperty(NdapiConstants.D2FP_KBRD_HLP_TXT, value); }
        }

        /// <summary>
        /// Gets or sets the trigger style.
        /// </summary>
        [Property(NdapiConstants.D2FP_TRG_STY)]
        public TriggerStyle Style
        {
            get { return GetNumberProperty<TriggerStyle>(NdapiConstants.D2FP_TRG_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_TRG_STY, value); }
        }

        /// <summary>
        /// Gets or sets the trigger code.
        /// </summary>
        [Property(NdapiConstants.D2FP_TRG_TXT)]
        public string Text
        {
            get { return GetStringProperty(NdapiConstants.D2FP_TRG_TXT); }
            set { SetStringProperty(NdapiConstants.D2FP_TRG_TXT, value); }
        }

        /// <summary>
        /// Compiles the trigger.
        /// </summary>
        public void Compile()
        {
            var status = NativeMethods.d2ftrgco_CompileObj(NdapiContext.Context, _handle);
            Ensure.Success(status);
        }
    }
}
