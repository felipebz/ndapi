using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a report object.
/// </summary>
public partial class Report : NdapiObject<Report>
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
    public partial string Comment { get; set; }

    /// <summary>
    /// Gets or sets the communication mode.
    /// </summary>
    [Property(NdapiConstant.D2FP_COMM_MODE)]
    public partial CommunicationMode CommunicationMode { get; set; }

    /// <summary>
    /// Gets or sets the name of the data source block.
    /// </summary>
    [Property(NdapiConstant.D2FP_DAT_SRC_BLK)]
    public partial string DataSourceBlock { get; set; }

    /// <summary>
    /// Gets or sets the execution mode.
    /// </summary>
    [Property(NdapiConstant.D2FP_EXEC_MODE)]
    public partial ExecutionMode ExecutionMode { get; set; }

    /// <summary>
    /// Gets or sets the filename.
    /// </summary>
    [Property(NdapiConstant.D2FP_FLNAM)]
    public partial string Filename { get; set; }

    /// <summary>
    /// Gets or sets the destination format.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_DESTINATION_FMT)]
    public partial string DestinationFormat { get; set; }

    /// <summary>
    /// Gets or sets the destination name.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_DESTINATION_NAM)]
    public partial string DestinationName { get; set; }

    /// <summary>
    /// Gets or sets the destination type.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_DESTINATION_TYP)]
    public partial ReportDestinationType DestinationType { get; set; }

    /// <summary>
    /// Gets or sets the parameters.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_PARAMS)]
    public partial string Parameters { get; set; }

    /// <summary>
    /// Gets or sets the server adress.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_SRVR)]
    public partial string Server { get; set; }
}
