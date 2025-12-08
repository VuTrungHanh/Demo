using OfficeOpenXml;
using System.Data;
using System.IO;

namespace DemoMvc363.Models.Process
{
    public class ExcelProcess
    {
        public DataTable ExcelToDataTable(string filePath)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("PersonId");
            dt.Columns.Add("FullName");
            dt.Columns.Add("Address");

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            FileInfo fileInfo = new FileInfo(filePath);

            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                int rowCount = worksheet.Dimension.Rows;

                for (int row = 2; row <= rowCount; row++)
                {
                    DataRow dr = dt.NewRow();

                    dr["PersonId"] = worksheet.Cells[row, 1].Text;
                    dr["FullName"] = worksheet.Cells[row, 2].Text;
                    dr["Address"] = worksheet.Cells[row, 3].Text;

                    dt.Rows.Add(dr);
                }
            }

            return dt;
        }
    }
}
