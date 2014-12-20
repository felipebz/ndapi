using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    public class Report : NdapiObject
    {
        public Report(FormModule module, string name)
        {
            Create(name, ObjectType.Report, module);
        }

        internal Report(ObjectSafeHandle handle) : base(handle)
        {
        }

        public string Comment
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COMMENT); }
            set { SetStringProperty(NdapiConstants.D2FP_COMMENT, value); }
        }

        public CommunicationMode CommunicationMode
        {
            get { return GetNumberProperty<CommunicationMode>(NdapiConstants.D2FP_COMM_MODE); }
            set { SetNumberProperty(NdapiConstants.D2FP_COMM_MODE, value); }
        }

        public string DataSourceBlock
        {
            get { return GetStringProperty(NdapiConstants.D2FP_DAT_SRC_BLK); }
            set { SetStringProperty(NdapiConstants.D2FP_DAT_SRC_BLK, value); }
        }

        public ExecutionMode ExecutionMode
        {
            get { return GetNumberProperty<ExecutionMode>(NdapiConstants.D2FP_EXEC_MODE); }
            set { SetNumberProperty(NdapiConstants.D2FP_EXEC_MODE, value); }
        }

        public string Filename
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FLNAM); }
            set { SetStringProperty(NdapiConstants.D2FP_FLNAM, value); }
        }

        public string DestinationFormat
        {
            get { return GetStringProperty(NdapiConstants.D2FP_RPT_DESTINATION_FMT); }
            set { SetStringProperty(NdapiConstants.D2FP_RPT_DESTINATION_FMT, value); }
        }

        public string DestinationName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_RPT_DESTINATION_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_RPT_DESTINATION_NAM, value); }
        }

        public ReportDestinationType DestinationType
        {
            get { return GetNumberProperty<ReportDestinationType>(NdapiConstants.D2FP_RPT_DESTINATION_TYP); }
            set { SetNumberProperty(NdapiConstants.D2FP_RPT_DESTINATION_TYP, value); }
        }

        public string Parameters
        {
            get { return GetStringProperty(NdapiConstants.D2FP_RPT_PARAMS); }
            set { SetStringProperty(NdapiConstants.D2FP_RPT_PARAMS, value); }
        }

        public string Server
        {
            get { return GetStringProperty(NdapiConstants.D2FP_RPT_SRVR); }
            set { SetStringProperty(NdapiConstants.D2FP_RPT_SRVR, value); }
        }
    }
}
