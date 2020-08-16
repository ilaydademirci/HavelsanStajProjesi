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
            string[] vls = reboundDictionary.Keys.ToArray();
            int[] vls2 = new int[10] { 2, 3, 21, 22, 23, 24, 25, 26, 27, 28 }; 
            //int[] vls2 = reboundDictionary.Keys.ToArray();
            this.APP = new Microsoft.Office.Interop.Excel.Application();

            // Open the Workbook:
            string adres = "StajProje.xlsx";
            this.Open(adres, 1);

            // Get the first worksheet.
            // (Excel uses base 1 indexing, not base 0.)
            WS = (Excel.Worksheet)WB.Worksheets[1];
            WS.Cells[1, 1] = "Transition ID";
            WS.Cells[1, 2] = "Status Change";
            WS.Cells[1, 3] = "Number of Changed Status";
            WS.Range["A1", "C1"].Font.Bold = "True";

            Excel.Range header_range = WS.get_Range("A1", "C1");
            header_range.Font.Bold = true;
            header_range.Font.Color =
                System.Drawing.ColorTranslator.ToOle(
                    System.Drawing.Color.Red);
            header_range.Interior.Color =
                System.Drawing.ColorTranslator.ToOle(
                    System.Drawing.Color.Pink);

            Range = WS.get_Range("A1", Type.Missing).get_Resize(1, reboundDictionary.Keys.Count);
            Range.Value = vls;
            Range = WS.get_Range("B1", Type.Missing).get_Resize(1, reboundDictionary.Keys.Count);
            Range.Value = vls;
            Range = WS.get_Range("C1", Type.Missing).get_Resize(1, reboundDictionary.Keys.Count);
            Range.Value = vls;



            // Print out 1 copy to the default printer:
            WS.PrintOut(
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            WB.SaveAs("StajProje.xlsx");

        }

        private void Open(string vls, int vls2)
        {
            throw new NotImplementedException();
        }
    }
}
