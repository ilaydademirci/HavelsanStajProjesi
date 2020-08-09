using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using Excel= Microsoft.Office.Interop.Excel;

namespace StajProje.Helpers
{
    
    public class ExcelHelper
    {
        public Excel.Application APP = null;
        public Excel.Workbook WB = null;
        public Excel.Worksheet WS = null;
        public Excel.Range Range = null;
        public void PrintToExcelFile(Dictionary<string, int> reboundDictionary)
        {
            this.APP = new Microsoft.Office.Interop.Excel.Application();

            // Open the Workbook:
            this.Open("StajProje\\Staj\\StajProje\\StajProje.xlsx", 1);

            // Get the first worksheet.
            // (Excel uses base 1 indexing, not base 0.)
            WS = (Excel.Worksheet)WB.Worksheets[1];

            // Print out 1 copy to the default printer:
            WS.PrintOut(
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing);

        }

        private void Open(string v1, int v2)
        {
          throw new NotImplementedException();
        }
    }
}
