using SqlSugar;

namespace MasterServerToolkit.Bridges.SqlSugar
{
    [SugarTable(TablesMapping.EmailConfirmationCodes)]
    public class EmailConfirmationData
    {
        [SugarColumn(ColumnName = "email", ColumnDataType = "varchar(45)", IsPrimaryKey = true)]
        public string Email { get; set; }
        [SugarColumn(ColumnName = "code", ColumnDataType = "varchar(10)")]
        public string Code { get; set; }
    }
}