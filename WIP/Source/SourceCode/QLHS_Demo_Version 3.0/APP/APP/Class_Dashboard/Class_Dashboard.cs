using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
using DTO;
namespace APP
{
    public partial class Class_Dashboard : MetroFramework.Forms.MetroForm
    {
        public bool IsSearch { get; set; }
        public string SchoolYearID { get; set; }
        public string TermID { get; set; }
        public Class_Dashboard()
        {
            InitializeComponent();
        }

        private void Class_Dashboard_Load(object sender, EventArgs e)
        {
            if (Class_BUL.LoadBySC(SchoolYearID) == null)
            {
                metroComboBox1.DataSource = null;
                metroGrid.DataSource = null;
                metroComboBox1.Enabled = metroGrid.Enabled = false;
            }
            else
            {
                metroComboBox1.ValueMember = "ID";
                metroComboBox1.DisplayMember = "Name";
                metroComboBox1.DataSource = Class_BUL.LoadBySC(SchoolYearID);
            }
            if (IsSearch == true)
            {
                
            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsSearch == true)
            {

            }
            else
                if (Process_BUL.LoadByClass(metroComboBox1.SelectedValue.ToString(), TermID) != null)
                    metroGrid.DataSource = Process_BUL.LoadByClass(metroComboBox1.SelectedValue.ToString(), TermID);
                else
                {
                    metroGrid.DataSource = null;
                }
        }

        private void metroGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid.SelectedRows.Count == 0) return;
            StudentInformation studentInformation = new StudentInformation();
            studentInformation.ID =int.Parse(metroGrid.SelectedRows[0].Cells[1].Value.ToString());
            studentInformation.SchoolYearID = SchoolYearID;
            studentInformation.TermID = TermID;
            studentInformation.ClassID = metroComboBox1.SelectedValue.ToString();
            studentInformation.ShowDialog();
        }

        private void copyAlltoClipboard()
        {
            metroGrid.SelectAll();
            DataObject dataObj = metroGrid.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }


        private void BtnExport_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

        }
    }
}
