using NdapiManaged.Core;
using NdapiManaged.Core.Handles;
using NdapiManaged.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NdapiManaged
{
    public class Trigger : NdapiObject
    {
        public Trigger()
        {
        }

        public Trigger(string name)
        {
            Create(name, NdapiConstants.D2FFO_TRIGGER);
        }

        internal Trigger(ObjectSafeHandle handle) : base(handle)
        {
        }

        public string Comment
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COMMENT); }
            set { SetStringProperty(NdapiConstants.D2FP_COMMENT, value); }
        }

        public bool DisplayInKeyboardHelp
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_DISP_IN_KBRD_HLP); }
            set { SetBooleanProperty(NdapiConstants.D2FP_DISP_IN_KBRD_HLP, value); }
        }

        public ExecutionStyle ExecutionStyle
        {
            get { return GetNumberProperty<ExecutionStyle>(NdapiConstants.D2FP_EXEC_HIERARCHY); }
            set { SetNumberProperty(NdapiConstants.D2FP_EXEC_HIERARCHY, value); }
        }

        public bool FireInEnterQueryMode
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_FIRE_IN_QRY); }
            set { SetBooleanProperty(NdapiConstants.D2FP_FIRE_IN_QRY, value); }
        }

        public string KeyboardHelpDescription
        {
            get { return GetStringProperty(NdapiConstants.D2FP_KBRD_HLP_TXT); }
            set { SetStringProperty(NdapiConstants.D2FP_KBRD_HLP_TXT, value); }
        }

        public TriggerStyle Style
        {
            get { return GetNumberProperty<TriggerStyle>(NdapiConstants.D2FP_TRG_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_TRG_STY, value); }
        }

        public string Text
        {
            get { return GetStringProperty(NdapiConstants.D2FP_TRG_TXT); }
            set { SetStringProperty(NdapiConstants.D2FP_TRG_TXT, value); }
        }

        public void Compile()
        {
            var status = NativeMethods.d2ftrgco_CompileObj(NdapiContext.Context, _handle);
            Ensure.Success(status);
        }
    }
}
