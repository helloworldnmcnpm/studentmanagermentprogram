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
namespace APP.ImediateStudent
{
    public partial class OrderByClass : MetroFramework.Forms.MetroForm
    {
        public string SchoolYearID { get; set; }
        public string TermID { get; set; }
        public bool IsSearch { get; set; }
        public OrderByClass()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        private void OrderByClass_Load(object sender, EventArgs e)
        {
            dt.Columns.Add(new DataColumn("Mã học sinh", typeof(Int32)));
            dt.Columns.Add(new DataColumn("Tên học sinh", typeof(string)));
            dt.Columns.Add(new DataColumn("Lớp", typeof(string)));
            dt.Columns.Add(new DataColumn("Điểm tổng kết", typeof(double)));
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
            metroCombo.DataSource = Class_BUL.LoadBySC(SchoolYearID);
            metroCombo.DisplayMember = "Name";
            metroCombo.ValueMember = "ID";
            metroCombo_SelectedIndexChanged(sender, e);
        }

        private void metroCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dt.Rows.Count > 0)
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i].Delete();
                }
            List<Process_DTO> process_DTOs = new List<Process_DTO>();
            List<Process_DTO> ListImediate = new List<Process_DTO>();
            if (Process_BUL.ListStudentByTerm(TermID) == null) return;
            process_DTOs = Process_BUL.ListStudentByTerm(TermID);
            for (int i = 0; i < process_DTOs.Count; i++)
            {
                if (process_DTOs[i].TotalScore >= 6.5&&process_DTOs[i].TotalScore<8 && process_DTOs[i].ClassID == metroCombo.SelectedValue.ToString())
                    ListImediate.Add(process_DTOs[i]);
            }
            DataRow dataRow;
            for (int i = 0; i < ListImediate.Count; i++)
            {
                dataRow = dt.NewRow();
                Student_DTO student_DTO = Student_BUL.LoadAStudent(ListImediate[i].StudentID);
                dataRow[0] = ListImediate[i].StudentID;
                dataRow[1] = student_DTO.Name;
                dataRow[2] = Class_BUL.GetName(ListImediate[i].ClassID);
                dataRow[3] = Math.Round(ListImediate[i].TotalScore, 2, MidpointRounding.AwayFromZero);
                dataRow[4] = student_DTO.Sex;
                dataRow[5] = student_DTO.Birthday;
                dataRow[6] = student_DTO.Birthplace;
                dataRow[7] = student_DTO.Address;
                dataRow[8] = student_DTO.National;
                dataRow[9] = student_DTO.Religion;
                dataRow[10] = student_DTO.Phone;
                dataRow[11] = student_DTO.Father;
                dataRow[12] = student_DTO.FJob;
                dataRow[13] = student_DTO.Mother;
                dataRow[14] = student_DTO.MJob;
                dataRow[15] = ListImediate[i].ClassID;
                dt.Rows.Add(dataRow);
                dt.AcceptChanges();
            }
            metroGrid.DataSource = dt;
            metroGrid.Columns[15].Visible = false;
            NumberEx.Text = "Số học sinh khá: " + metroGrid.RowCount+" học sinh. ("+ Math.Round((double)metroGrid.RowCount/(double)Class_BUL.LoadBySC(SchoolYearID)[metroCombo.SelectedIndex].Students,2,MidpointRounding.AwayFromZero)*100+"%).";
            AllStudent.Text = "Tổng số học sinh: " + Class_BUL.LoadBySC(SchoolYearID)[metroCombo.SelectedIndex].Students;
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
