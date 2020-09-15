using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop;
using Excel = Microsoft.Office.Interop.Excel;

namespace StajProje
{
    class ExcelHelper
    {
            public void PrintToExcelFile(Dictionary<string, int> reboundDictionary)
        {
            Excel.Application App;
            Excel._Workbook WB;
            Excel._Worksheet WS;
            Excel.Range range;

            string[] vls = reboundDictionary.Keys.ToArray();
            int[] vls2 = reboundDictionary.Values.ToArray();

            object misvalue = System.Reflection.Missing.Value;

            try
            {
                //Excel'i başlatma ve Uygulama nesnesini alma.

                App = new Excel.Application();
                App.Visible = true;

                //WB WS değişkenlerini atama.

                WB = (Excel._Workbook)(App.Workbooks.Add(""));
                WS = (Excel._Worksheet)WB.ActiveSheet;

                //Hücreden hücreye giden tablo başlıkları ekleme.

                WS.Cells[1, 1] = "Transition ID";
                WS.Cells[2, 1] = "Number of Changed Status";

                //Biçim A1: A3 kalın, dikey hizalama = Merkez

                WS.get_Range("A1", "A3").Font.Bold = true;
                WS.get_Range("A1", "A3").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

                //B1: AA1'i bir dizi değerle doldurma.

                range = WS.get_Range("B1", "AA1").get_Resize(1, reboundDictionary.Keys.Count);
                range.Value = vls;

                //B2: AA2'yi bir dizi değerle doldurma.

                range = WS.get_Range("B2", "AA2").get_Resize(1, reboundDictionary.Values.Count);
                range.Value2 = vls2;
               
                //AutoFit columns A:D.
                range = WS.get_Range("A2", "C29");
                range.EntireColumn.AutoFit();

                App.Visible = true;
                App.UserControl = true;
                WB.SaveAs(@"‪‪C:\Users\ilayd\Desktop\StajProje.xlsx", Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,
                    true, true, Excel.XlSaveAsAccessMode.xlNoChange,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
               

                //...
            }
            catch
            {
            }
        }
    }
}

