using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUL;
namespace APP.StudentDashboard
{
    public partial class Student_Dashboard : MetroFramework.Forms.MetroForm
    {
        public string TermID { get; set; }
        public string SchoolYearID { get; set; }
        public bool IsSearch { get; set; }
        public Student_Dashboard()
        {
            InitializeComponent();
           
        }

        private void Student_Dashboard_Load(object sender, EventArgs e)
        {
            List<Process_DTO> process_DTOs = new List<Process_DTO>();
            process_DTOs = Process_BUL.ListStudentByTerm(TermID);
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Mã học sinh", typeof(Int32)));
            dt.Columns.Add(new DataColumn("Tên học sinh", typeof(string)));
            dt.Columns.Add(new DataColumn("Lớp", typeof(string)));
            dt.Columns.Add(new DataColumn("Giới tính", typeof(string)));
            dt.Columns.Add(new DataColumn("Ngày sinh", typeof(DateTime)));
            dt.Columns.Add(new DataColumn("Nơi sinh", typeof(string)));
            dt.Columns.Add(new DataColumn("Địa chỉ", typeof(string)));
            dt.Columns.Add(new DataColumn("Dân tộc", typeof(string)));
            dt.Columns.Add(new DataColumn("Tôn giáo", typeof(string)));
            dt.Columns.Add(new DataColumn("Số điện thoại", typeof(string)));
            dt.Columns.Add(new DataColumn("Cha", typeof(string)));
            dt.Columns.Add(new DataColumn("Nghề nghiệp cha", typeof(string)));
            dt.Columns.Add(new DataColumn("Mẹ", typeof(string)));
            dt.Columns.Add(new DataColumn("Nghề nghiệp mẹ", typeof(string)));
            dt.Columns.Add(new DataColumn("ClassID", typeof(string)));
            DataRow dataRow;
            for (int i = 0; i < process_DTOs.Count; i++)
            {
                dataRow = dt.NewRow();
                Student_DTO student_DTO = Student_BUL.LoadAStudent(process_DTOs[i].StudentID);
                dataRow[0] = process_DTOs[i].StudentID;
                dataRow[1] = student_DTO.Name;
                dataRow[2] = Class_BUL.GetName(process_DTOs[i].ClassID);
                dataRow[3] = student_DTO.Sex;
                dataRow[4] = student_DTO.Birthday;
                dataRow[5] = student_DTO.Birthplace;
                dataRow[6] = student_DTO.Address;
                dataRow[7] = student_DTO.National;
                dataRow[8] = student_DTO.Religion;
                dataRow[9] = student_DTO.Phone;
                dataRow[10] = student_DTO.Father;
                dataRow[11] = student_DTO.FJob;
                dataRow[12] = student_DTO.Mother;
                dataRow[13] = student_DTO.MJob;
                dataRow[14] = process_DTOs[i].ClassID;
                dt.Rows.Add(dataRow);
                dt.AcceptChanges();
            }

            metroGrid.DataSource = dt;
            metroGrid.Columns[14].Visible = false;
            {
                Male.Text = "Số học sinh nam:";
                AllStudent.Text = "Tổng số học sinh:";
                Female.Text = "Số học sinh nữ:";
                Religion.Text = "Số học sinh dân tộc thiểu số:";
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
                    if (metroGrid.Rows[i].Cells[7].Value.ToString() != "Kinh")
                    {
                        count3++;
                    }
                }
                Male.Text += " " + count + " học sinh. (" + Math.Round((double)count / (double)metroGrid.RowCount, 2, MidpointRounding.AwayFromZero) * 100 + "%).";
                Female.Text += " " + count2 + " học sinh. (" + Math.Round((double)count2 / (double)metroGrid.RowCount, 2, MidpointRounding.AwayFromZero) * 100 + "%).";
                Religion.Text += " " + count3 + " học sinh. (" + Math.Round((double)count3 / (double)metroGrid.RowCount, 2, MidpointRounding.AwayFromZero) * 100 + "%).";
            }
        }

        private void metroGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid.SelectedRows.Count == 0) return;
            StudentInformation studentInformation = new StudentInformation();
            studentInformation.ID = int.Parse(metroGrid.SelectedRows[0].Cells[0].Value.ToString());
            studentInformation.SchoolYearID = SchoolYearID;
            studentInformation.TermID = TermID;
            studentInformation.ClassID = metroGrid.SelectedRows[0].Cells[14].Value.ToString();
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
