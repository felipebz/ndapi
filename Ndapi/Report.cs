using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a report object.
/// </summary>
public class Report : NdapiObject<Report>
{
    /// <summary>
    /// Creates a report object.
    /// </summary>
    /// <param name="module">Report owner.</param>
    /// <param name="name">Report name.</param>
    public Report(FormModule module, string name) : base(name, ObjectType.Report, module)
    {
    }

    internal Report(ObjectSafeHandle handle) : base(handle, ObjectType.Report)
    {
    }

    /// <summary>
    /// Gets or sets the comment.
    /// </summary>
    [Property(NdapiConstant.D2FP_COMMENT)]
    public string Comment
    {
        get => GetStringProperty(NdapiConstant.D2FP_COMMENT);
        set => SetStringProperty(NdapiConstant.D2FP_COMMENT, value);
    }

    /// <summary>
    /// Gets or sets the communication mode.
    /// </summary>
    [Property(NdapiConstant.D2FP_COMM_MODE)]
    public CommunicationMode CommunicationMode
    {
        get => GetNumberProperty<CommunicationMode>(NdapiConstant.D2FP_COMM_MODE);
        set => SetNumberProperty(NdapiConstant.D2FP_COMM_MODE, value);
    }

    /// <summary>
    /// Gets or sets the name of the data source block.
    /// </summary>
    [Property(NdapiConstant.D2FP_DAT_SRC_BLK)]
    public string DataSourceBlock
    {
        get => GetStringProperty(NdapiConstant.D2FP_DAT_SRC_BLK);
        set => SetStringProperty(NdapiConstant.D2FP_DAT_SRC_BLK, value);
    }

    /// <summary>
    /// Gets or sets the execution mode.
    /// </summary>
    [Property(NdapiConstant.D2FP_EXEC_MODE)]
    public ExecutionMode ExecutionMode
    {
        get => GetNumberProperty<ExecutionMode>(NdapiConstant.D2FP_EXEC_MODE);
        set => SetNumberProperty(NdapiConstant.D2FP_EXEC_MODE, value);
    }

    /// <summary>
    /// Gets or sets the filename.
    /// </summary>
    [Property(NdapiConstant.D2FP_FLNAM)]
    public string Filename
    {
        get => GetStringProperty(NdapiConstant.D2FP_FLNAM);
        set => SetStringProperty(NdapiConstant.D2FP_FLNAM, value);
    }

    /// <summary>
    /// Gets or sets the destination format.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_DESTINATION_FMT)]
    public string DestinationFormat
    {
        get => GetStringProperty(NdapiConstant.D2FP_RPT_DESTINATION_FMT);
        set => SetStringProperty(NdapiConstant.D2FP_RPT_DESTINATION_FMT, value);
    }

    /// <summary>
    /// Gets or sets the destination name.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_DESTINATION_NAM)]
    public string DestinationName
    {
        get => GetStringProperty(NdapiConstant.D2FP_RPT_DESTINATION_NAM);
        set => SetStringProperty(NdapiConstant.D2FP_RPT_DESTINATION_NAM, value);
    }

    /// <summary>
    /// Gets or sets the destination type.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_DESTINATION_TYP)]
    public ReportDestinationType DestinationType
    {
        get => GetNumberProperty<ReportDestinationType>(NdapiConstant.D2FP_RPT_DESTINATION_TYP);
        set => SetNumberProperty(NdapiConstant.D2FP_RPT_DESTINATION_TYP, value);
    }

    /// <summary>
    /// Gets or sets the parameters.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_PARAMS)]
    public string Parameters
    {
        get => GetStringProperty(NdapiConstant.D2FP_RPT_PARAMS);
        set => SetStringProperty(NdapiConstant.D2FP_RPT_PARAMS, value);
    }

    /// <summary>
    /// Gets or sets the server adress.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_SRVR)]
    public string Server
    {
        get => GetStringProperty(NdapiConstant.D2FP_RPT_SRVR);
        set => SetStringProperty(NdapiConstant.D2FP_RPT_SRVR, value);
    }
}
