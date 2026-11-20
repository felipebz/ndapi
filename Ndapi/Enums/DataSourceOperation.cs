namespace Ndapi.Enums;

/// <summary>
/// Block operation whose procedure data source owns a data source argument or column.
/// </summary>
public enum DataSourceOperation
{
    Query,
    Insert,
    Update,
    Delete,
    Lock
}
