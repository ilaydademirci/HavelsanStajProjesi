using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;


namespace StajProje
{
    public partial class ExcelHelper : Form
    {
        private Excel.Application APP;

        public ExcelHelper()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Excel.Application APP = new Excel.Application();
            APP.Visible = true;
            APP.DisplayAlerts = true;

            object Missing = Type.Missing;

            Excel.Workbook WB = APP.Workbooks.Add(System.Reflection.Missing.Value);
            Excel.Worksheet WS = (Excel.Worksheet)WB.Sheets[1];
            object misValue = System.Reflection.Missing.Value;
            Excel.Range Range = (Excel.Range)WS.Cells;
            WB = APP.Workbooks.Open("StajProje.xlsx");
            WS.Cells[1, 1] = "Transition ID";
            WS.Cells[1, 2] = "Status Change";
            WS.Cells[1, 3] = "Number of Changed Status";
            WS.Range["A1", "C1"].Font.Bold = "True";

            MessageBox.Show(WS.get_Range("A1", "A1").Value2.ToString());

            WB.Close(true, misValue, misValue);
            APP.Quit();

            MessageBox.Show("Excel belgesini bağlandı ve okudu");


        }
        public void PrintToExcelFile(Dictionary<string, int> reboundDictionary)
        {
            string[] vls = reboundDictionary.Keys.ToArray();
            int[] vls2 = new int[10] { 2, 3, 21, 22, 23, 24, 25, 26, 27, 28 };
            //int[] vls2 = reboundDictionary.Keys.ToArray();
            this.APP = new Microsoft.Office.Interop.Excel.Application();


        }
    }
}
