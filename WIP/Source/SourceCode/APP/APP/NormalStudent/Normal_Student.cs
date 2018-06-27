﻿using System;
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
namespace APP.NormalStudent
{
    public partial class Normal_Student : MetroFramework.Forms.MetroForm
    {
        public string SchoolYearID { get; set; }
        public string TermID { get; set; }
        public bool IsSearch { get; set; }
        public int number;
        public double percent { get; set; }

        public Normal_Student()
        {
            InitializeComponent();
        }

        private void Normal_Student_Load(object sender, EventArgs e)
        {
            int count = 0;
            int ma = 0, mi = 0;
            string Sma = "", Smi = "", Current = "";
            RateLabel.Text = "Tỷ lệ học sinh trung bình toàn trường: " + percent + "%";
            DataTable dt = new DataTable();
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
            List<Process_DTO> process_DTOs = new List<Process_DTO>();
            List<Process_DTO> ListNormal = new List<Process_DTO>();
            process_DTOs = Process_BUL.ListStudentByTerm(TermID);
            for (int i = 0; i < process_DTOs.Count; i++)
            {
                if (process_DTOs[i].TotalScore >= 5 && process_DTOs[i].TotalScore < 6.5)
                    ListNormal.Add(process_DTOs[i]);
            }
            DataRow dataRow;
            number = ListNormal.Count;
            NumberLabel.Text = "Tổng số học sinh trung bình: " + number;
            for (int i = 0; i < ListNormal.Count; i++)
            {
                dataRow = dt.NewRow();
                Student_DTO student_DTO = Student_BUL.LoadAStudent(ListNormal[i].StudentID);
                dataRow[0] = ListNormal[i].StudentID;
                dataRow[1] = student_DTO.Name;
                dataRow[2] = Class_BUL.GetName(ListNormal[i].ClassID);
                dataRow[3] = Math.Round(ListNormal[i].TotalScore, 2, MidpointRounding.AwayFromZero);
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
                dataRow[15] = ListNormal[i].ClassID;
                dt.Rows.Add(dataRow);
                dt.AcceptChanges();
            }
            metroGrid.DataSource = dt;
            metroGrid.Columns[15].Visible = false;
            for (int i = 0; i < Class_BUL.LoadBySC(SchoolYearID).Count; i++)
            {
                count = 0;
                for (int j = 0; j < ListNormal.Count; j++)
                {
                    if (ListNormal[j].ClassID == Class_BUL.LoadBySC(SchoolYearID)[i].ID)
                    {
                        count++;
                        Sma = Class_BUL.LoadBySC(SchoolYearID)[i].Name;
                    }
                }
                if (count > ma)
                {
                    Current = "";
                    ma = count;
                    Current = Sma;
                }
                else
                    if (count == ma)
                {
                    Current += "\n" + Sma;
                }
            }
            Max.Text = "Lớp có tổng số học sinh trung bình nhiều nhất (" + ma + " Học sinh): " + Current;
            Current = "";
            count = 0;
            mi = ListNormal.Count;

            for (int i = 0; i < Class_BUL.LoadBySC(SchoolYearID).Count; i++)
            {
                count = 0;
                for (int j = 0; j < ListNormal.Count; j++)
                {
                    Smi = Class_BUL.LoadBySC(SchoolYearID)[i].Name.ToString();
                    if (ListNormal[j].ClassID == Class_BUL.LoadBySC(SchoolYearID)[i].ID)
                    {
                        count++;
                    }
                }
                if (count < mi)
                {
                    Current = "";
                    mi = count;
                    Current = Smi;
                }
                else if (count == mi)
                {
                    Current += "\n" + Smi;
                }
            }
            Min.Text = "Lớp có tổng số học sinh trung bình ít nhất (" + mi + " Học sinh): " + Current;
        }

        private void metroGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid.SelectedRows.Count == 0) return;
            StudentInformation studentInformation = new StudentInformation();
            studentInformation.ID = int.Parse(metroGrid.SelectedRows[0].Cells[0].Value.ToString());
            studentInformation.SchoolYearID = SchoolYearID;
            studentInformation.TermID = TermID;
            studentInformation.ClassID = metroGrid.SelectedRows[0].Cells[15].Value.ToString();
            studentInformation.ShowDialog();
        }

        private void BtnOrderByClass_Click(object sender, EventArgs e)
        {
            NormalStudent.OrderByClass orderByClass = new NormalStudent.OrderByClass();
            orderByClass.SchoolYearID = SchoolYearID;
            orderByClass.TermID = TermID;
            orderByClass.IsSearch = IsSearch;
            orderByClass.ShowDialog();
        }
    }
}
