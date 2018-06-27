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
    public partial class ClassDashBoard: MetroFramework.Forms.MetroForm
    {
        public bool IsSearch { get; set; }
        public string SchoolYearID { get; set; }
        public string TermID { get; set; }
        public ClassDashBoard()
        {
            InitializeComponent();
        }

        private void ClassDashBoard_Load(object sender, EventArgs e)
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
            {
                Male.Text = "Số học sinh nam:";
                AllStudent.Text = "Tổng số học sinh:";
                Female.Text = "Số học sinh nữ:";
                Religion.Text = "Số học sinh dân tộc thiểu số:";
                metroGrid.DataSource = Process_BUL.LoadByClass(metroComboBox1.SelectedValue.ToString(), TermID);
                AllStudent.Text += " " + metroGrid.RowCount + " học sinh.";
                int count = 0, count2 = 0, count3 = 0;
                for (int i = 0; i < metroGrid.RowCount; i++)
                {
                    if (metroGrid.Rows[i].Cells[3].Value.ToString() == "Nam")
                    {
                        count++;
                    }
                    else
                    {
                        count2++;
                    }
                    if (metroGrid.Rows[i].Cells[8].Value.ToString() != "Kinh")
                    {
                        count3++;
                    }
                }
                Male.Text += " " + count + " học sinh. (" + Math.Round((double)count / (double)metroGrid.RowCount, 2, MidpointRounding.AwayFromZero)*100+"%).";
                Female.Text += " " + count2 + " học sinh. (" + Math.Round((double)count2 / (double)metroGrid.RowCount, 2, MidpointRounding.AwayFromZero) * 100 + "%).";
                Religion.Text += " " + count3 + " học sinh. (" + Math.Round((double)count3 / (double)metroGrid.RowCount, 2, MidpointRounding.AwayFromZero) * 100 + "%).";
            }
            else
            {
                metroGrid.DataSource = null;
                Male.Text = "Số học sinh nam: 0 (0%)";
                AllStudent.Text = "Tổng số học sinh: 0";
                Female.Text = "Số học sinh nữ: 0 (0%)";
                Religion.Text = "Số học sinh dân tộc thiểu số: 0 (0%)";
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

        private void ScoreBoardBtn_Click(object sender, EventArgs e)
        {
            APP.Class_Dashboard.Class_ScoreBoard class_ScoreBoard = new Class_Dashboard.Class_ScoreBoard();
            class_ScoreBoard.SchoolYearID = SchoolYearID;
            class_ScoreBoard.TermID = TermID;
            class_ScoreBoard.ClassID = metroComboBox1.SelectedValue.ToString();
            class_ScoreBoard.ShowDialog();
        }
    }
}
