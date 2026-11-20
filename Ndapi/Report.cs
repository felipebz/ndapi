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
    public partial string? Comment { get; set; }

    /// <summary>
    /// Gets or sets the communication mode.
    /// </summary>
    [Property(NdapiConstant.D2FP_COMM_MODE)]
    public partial CommunicationMode CommunicationMode { get; set; }

    /// <summary>
    /// Gets or sets the name of the data source block.
    /// </summary>
    [Property(NdapiConstant.D2FP_DAT_SRC_BLK)]
    public partial string? DataSourceBlock { get; set; }

    /// <summary>
    /// Gets or sets the execution mode.
    /// </summary>
    [Property(NdapiConstant.D2FP_EXEC_MODE)]
    public partial ExecutionMode ExecutionMode { get; set; }

    /// <summary>
    /// Gets or sets the filename.
    /// </summary>
    [Property(NdapiConstant.D2FP_FLNAM)]
    public partial string? FileName { get; set; }

    /// <summary>
    /// Gets or sets the destination format.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_DESTINATION_FMT)]
    public partial string? DestinationFormat { get; set; }

    /// <summary>
    /// Gets or sets the destination name.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_DESTINATION_NAM)]
    public partial string? DestinationName { get; set; }

    /// <summary>
    /// Gets or sets the destination type.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_DESTINATION_TYP)]
    public partial ReportDestinationType DestinationType { get; set; }

    /// <summary>
    /// Gets or sets the parameters.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_PARAMS)]
    public partial string? Parameters { get; set; }

    /// <summary>
    /// Gets or sets the name of the query the report is based on.
    /// </summary>
    [Property(NdapiConstant.D2FP_QUERY_NAME)]
    public partial string? QueryName { get; set; }

    /// <summary>
    /// Gets or sets the server adress.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_SRVR)]
    public partial string? Server { get; set; }

    /// <summary>
    /// Gets or sets whether the report runs on Oracle Reports or Analytics Publisher (BI Publisher):
    /// 0 = Oracle Reports, 1 = BI Publisher. Forms 12c and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_OBJECT_TYPE)]
    public partial int ReportObjectType { get; set; }

    /// <summary>
    /// Gets or sets the URL, relative or fully qualified, of the BI Publisher ScheduleService WSDL. Forms 12c and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_SRVC_LOC)]
    public partial string? ServiceLocation { get; set; }

    /// <summary>
    /// Gets or sets whether the call to the BI Publisher server needs SSL/TLS: 0 = Mandatory, 1 = Optional.
    /// Forms 12c and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_SSL_CONN)]
    public partial int SslConnection { get; set; }

    /// <summary>
    /// Gets or sets the path of the report in BI Publisher. Forms 12c and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_ABS_PATH)]
    public partial string? ReportPath { get; set; }

    /// <summary>
    /// Gets or sets the BI Publisher report parameters: name/value pairs separated by CHR(10). Forms 12c and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_BIP_PARAMS)]
    public partial string? ReportParameters { get; set; }

    /// <summary>
    /// Gets or sets the BI Publisher template name. Forms 12c and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_TEMPLATE_NAME)]
    public partial string? TemplateName { get; set; }

    /// <summary>
    /// Gets or sets the BI Publisher output format. Forms 12c and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_OPT_FMT)]
    public partial string? ReportFormat { get; set; }

    /// <summary>
    /// Gets or sets the locale used to print the BI Publisher output. Forms 12c and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_LOCALE)]
    public partial string? ReportLocale { get; set; }

    /// <summary>
    /// Gets or sets how the BI Publisher output is delivered: 0 = Mail, 1 = Printer, 2 = File, 3 = Fax, 4 = FTP,
    /// 5 = WebDAV. Forms 12c and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_DEL_TYPE)]
    public partial int DeliveryType { get; set; }

    /// <summary>
    /// Gets or sets the mail server alias configured on the BI Publisher server. Forms 12c and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_MAIL_SERVER)]
    public partial string? MailServer { get; set; }

    /// <summary>
    /// Gets or sets the FROM address of the mailed output. Forms 12c and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_MAIL_FROM)]
    public partial string? MailFrom { get; set; }

    /// <summary>
    /// Gets or sets the TO address of the mailed output. Forms 12c and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_MAIL_TO)]
    public partial string? MailTo { get; set; }

    /// <summary>
    /// Gets or sets the CC address of the mailed output. Forms 12c and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_MAIL_CC)]
    public partial string? MailCc { get; set; }

    /// <summary>
    /// Gets or sets the BCC address of the mailed output. Forms 12c and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_MAIL_BCC)]
    public partial string? MailBcc { get; set; }

    /// <summary>
    /// Gets or sets the REPLY TO address of the mailed output. Forms 12c and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_MAIL_REPLYTO)]
    public partial string? MailReplyTo { get; set; }

    /// <summary>
    /// Gets or sets the subject of the mailed output. Forms 12c and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_MAIL_SUBJECT)]
    public partial string? MailSubject { get; set; }

    /// <summary>
    /// Gets or sets the body text of the mailed output. Forms 12c and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_MAIL_BODY)]
    public partial string? MailBody { get; set; }

    /// <summary>
    /// Gets or sets the print server alias configured on the BI Publisher server. Forms 12c and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_PRINT_NAME)]
    public partial string? PrintServer { get; set; }

    /// <summary>
    /// Gets or sets the number of printed copies. Forms 12c and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_PRINT_NUMBEROFCOPY)]
    public partial int NumberOfCopies { get; set; }

    /// <summary>
    /// Gets or sets the range of pages to print. Forms 12c and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_PRINT_PAGERANGE)]
    public partial string? PageRange { get; set; }

    /// <summary>
    /// Gets or sets the paper orientation: 0 = Portrait, 1 = Landscape. Forms 12c and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_PRINT_ORIENTATION)]
    public partial int Orientation { get; set; }

    /// <summary>
    /// Gets or sets single or double sided printing: 0 = Single sided, 1 = Double sided long edge (duplex),
    /// 2 = Double sided short edge (tumble). Forms 12c and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_PRINT_SIDE)]
    public partial int PrintSide { get; set; }

    /// <summary>
    /// Gets or sets the printer tray: 0 = Default, 1 = Tray 1, 2 = Tray 2, 3 = Tray 3. Forms 12c and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_PRINT_TRAY)]
    public partial int PrintTray { get; set; }

    /// <summary>
    /// Gets or sets the fax server alias configured on the BI Publisher server. Forms 12c and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_FAX_SERVER)]
    public partial string? FaxServer { get; set; }

    /// <summary>
    /// Gets or sets the fax phone number. Forms 12c and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_FAX_NUMBER)]
    public partial string? FaxNumber { get; set; }

    /// <summary>
    /// Gets or sets where on the BI Publisher server's file system the output is stored. Forms 12c and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_LOCAL_FILENAME)]
    public partial string? LocalFileName { get; set; }

    /// <summary>
    /// Gets or sets the FTP server alias configured on the BI Publisher server. Forms 12c and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_FTP_SERVER)]
    public partial string? FtpServer { get; set; }

    /// <summary>
    /// Gets or sets the FTP user name. Forms 12c and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_FTP_USER)]
    public partial string? FtpUser { get; set; }

    /// <summary>
    /// Gets or sets the file name of the output delivered by FTP. Forms 12c and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_FTP_FILENAME)]
    public partial string? FtpFileName { get; set; }

    /// <summary>
    /// Gets or sets whether SFTP is used instead of FTP. Forms 12c and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_FTP_SECURED)]
    public partial bool SecureFtp { get; set; }

    /// <summary>
    /// Gets or sets the WebDAV server alias configured on the BI Publisher server. Forms 12c and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_WEBDAV_SERVER)]
    public partial string? WebDavServer { get; set; }

    /// <summary>
    /// Gets or sets the WebDAV authentication type: 0 = None, 1 = Basic, 2 = Digest. Forms 12c and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_WEBDAV_AUTHTYPE)]
    public partial int WebDavAuthenticationType { get; set; }

    /// <summary>
    /// Gets or sets the proxy user name in front of the WebDAV server. Forms 12c and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_WEBDAV_USER)]
    public partial string? WebDavUser { get; set; }

    /// <summary>
    /// Gets or sets the directory on the remote server where the WebDAV output is delivered. Forms 12c and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_RPT_WEBDAV_FILE)]
    public partial string? WebDavFilePath { get; set; }

    /// <summary>
    /// Gets or sets whether the object was modified since it was loaded or saved.
    /// </summary>
    [Property(NdapiConstant.D2FP_DIRTY_INFO)]
    public partial bool IsDirty { get; set; }

    /// <summary>
    /// Gets the module that contains the object.
    /// </summary>
    [Property(NdapiConstant.D2FP_MODULE)]
    public partial NdapiObject? Module { get; }

    /// <summary>
    /// Gets the object this object is subclassed from.
    /// </summary>
    [Property(NdapiConstant.D2FP_SOURCE)]
    public partial NdapiObject? Source { get; }

    /// <summary>
    /// Gets or sets whether the object is subclassed as part of an object group.
    /// </summary>
    [Property(NdapiConstant.D2FP_SUBCL_OBJGRP)]
    public partial bool IsSubclassObjectGroup { get; set; }

    /// <summary>
    /// Gets or sets whether the object is subclassed as a sub-object of a subclassed parent.
    /// </summary>
    [Property(NdapiConstant.D2FP_SUBCL_SUBOBJ)]
    public partial bool IsSubclassSubObject { get; set; }
}
