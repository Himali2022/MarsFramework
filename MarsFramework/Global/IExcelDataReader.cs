using System.Data;

namespace MarsFramework.Global
{
    internal interface IExcelDataReader
    {
        bool IsFirstRowAsColumnNames { get; set; }

        DataSet AsDataSet();
    }
}