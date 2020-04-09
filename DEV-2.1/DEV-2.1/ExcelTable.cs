using System;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace DEV_2._1
{
    class ExcelTable
    {
        private string _path;
        _Application excel = new Excel.Application();
        Workbook workbook;
        Worksheet worksheet;
        private static ExcelTable _instance;

        public ExcelTable(string path, int Sheet)
        {
            Path = path;
            workbook = excel.Workbooks.Open(path);
            worksheet = excel.Worksheets[Sheet];
        }

        public string Path
        {
            get
            {
                return _path;
            }

            set
            {
                _path = value;
            }
        }

        public void WriteToCell(int i, int j, string line)
        {
            worksheet.Cells[i, j] = line;
        }

        public string ReadCell(int i, int j)
        {
            if(worksheet.Cells[i,j] != null)
            {
                return Convert.ToString(worksheet.Cells[i, j].Value2);
            }

            else
            {
                return "0";
            }
        }

        public void Save()
        {
            workbook.Save();
        }

        public void SaveAs(string path)
        {
            workbook.SaveAs(path);
        }

        public void Close()
        {
            workbook.Close();
        }

        public int NumberOfNonEmptyLines()
        {
            int i = 1;
            int count = 1;
            while (worksheet.Cells[i,1].Value2 != null)
            {
                i++;
                count++;
            }

            return count;
        }

        

    }
}
