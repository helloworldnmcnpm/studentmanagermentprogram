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
namespace APP
{
    public partial class UpClass : MaterialSkin.Controls.MaterialForm
    {
        public UpClass()
        {
            InitializeComponent();
        }
        private DataTable dt = new DataTable();
        private List<Process_DTO> process_DTOs = new List<Process_DTO>();
        private List<Class_DTO> class_DTOs;
        private void CreateDtPassedStudentOfGrade()
        {
            dt.Clear();
            dt.Columns.Add(new DataColumn("Mã học sinh", typeof(string)));
            dt.Columns.Add(new DataColumn("Tên học sinh", typeof(string)));
            dt.Columns.Add(new DataColumn("Lớp", typeof(string)));
            dt.Columns.Add(new DataColumn("Điểm trung bình các học kỳ", typeof(string)));
            dt.Columns.Add(new DataColumn("Đánh giá", typeof(string)));
            metroGrid2.DataSource = dt;
        }

        private void UpClass_Load(object sender, EventArgs e)
        {
            CreateDtPassedStudentOfGrade();
            if (SchoolYear_BUL.Load() == null)
            {
                BtnSwitchUp.Enabled = ComboboxTargetSchoolYear.Enabled =  ComboBoxTargetClass.Enabled = ComboBoxSchoolYear.Enabled = false;
            }
            else
            {
                BtnSwitchUp.Enabled = ComboboxTargetSchoolYear.Enabled = ComboBoxTargetClass.Enabled = ComboBoxSchoolYear.Enabled = true;
                ComboBoxSchoolYear.DataSource = SchoolYear_BUL.Load();
            }
        }

        private void ComboboxTargetSchoolYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboboxTargetSchoolYear.DataSource != null)
            {
                ComboBoxTargetClass.ValueMember = "ID";
                ComboBoxTargetClass.DisplayMember = "Name";
                ComboBoxTargetClass.DataSource = Class_BUL.LoadBySC(ComboboxTargetSchoolYear.SelectedValue.ToString());
            }
            else
            {
                ComboBoxTargetClass.DataSource = null;
            }
        }

        private void ComboBoxSchoolYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SchoolYear_BUL.Load() != null)
            {
                List<SchoolYear_DTO> listNext = SchoolYear_BUL.Load();
                for (int i = 0; i < listNext.Count; i++)
                {
                    if (listNext[i].Begin <= SchoolYear_BUL.LoadASY(ComboBoxSchoolYear.SelectedValue.ToString()).Begin)
                    {
                        listNext.RemoveAt(i);
                        i = 0;
                    }
                }
                if (listNext.Count != 0)
                    ComboboxTargetSchoolYear.DataSource = listNext;
                else ComboboxTargetSchoolYear.DataSource = null;
            }
            else return;
            dt.Clear();
            //load danh sách lớp học thuộc năm học đó
            if (Class_BUL.LoadBySC(ComboBoxSchoolYear.SelectedValue.ToString()) == null) {
               MessageBox.Show("Chưa thêm lớp cho năm học này!");
               return;
            }
            class_DTOs = Class_BUL.LoadBySC(ComboBoxSchoolYear.SelectedValue.ToString());
            //load toàn bộ quá trình học theo mã lớp đã load
            for (int i = 0; i < class_DTOs.Count; i++)
            {
                List<Process_DTO> ListProcessByClass = new List<Process_DTO>();
                if (Process_BUL.ListProcessByClass(class_DTOs[i].ID) == null) continue;
                ListProcessByClass = Process_BUL.ListProcessByClass(class_DTOs[i].ID);
                for (int j = 0; j < ListProcessByClass.Count; j++)
                {
                    process_DTOs.Add(ListProcessByClass[j]);
                }
            }
            //gom những học sinh có cùng mã lớp lên datatable
            {
                for (int i = 0; i < process_DTOs.Count; i++)
                {
                    DataRow dr = dt.NewRow();
                    dr["Mã học sinh"] = process_DTOs[0].StudentID;
                    int StudentID = process_DTOs[0].StudentID,count=1;
                    double Score = process_DTOs[0].TotalScore;
                    if (Class_BUL.GetName(process_DTOs[0].ClassID) == null) return;
                    string Class = Class_BUL.GetName(process_DTOs[0].ClassID)+" ";
                    if (Student_BUL.LoadAStudent(StudentID) == null) return;
                    dr["Tên học sinh"] = Student_BUL.LoadAStudent(StudentID).Name;
                    //Thực hiện
                    {
                        process_DTOs.RemoveAt(0);
                        for (int j = 0; j < process_DTOs.Count; j++)
                        {
                            if (process_DTOs[j].StudentID==StudentID)
                            {
                                Score += process_DTOs[j].TotalScore;
                                count++;
                                if (Class_BUL.GetName(process_DTOs[j].ClassID) == null) return;
                                Class += Class_BUL.GetName(process_DTOs[j].ClassID) + " ";
                                process_DTOs.RemoveAt(j);
                                j = 0;
                            }
                        }
                        Score = Math.Round((double)Score / (double)count, 2, MidpointRounding.AwayFromZero);
                        dr["Điểm trung bình các học kỳ"] = Score;
                        dr["Lớp"] = Class;
                        if (Score >= Rule_BUL.Load().PassedScore) dr["Đánh giá"] = "Có thể lên lớp!";
                        else dr["Đánh giá"] = "Lưu ban!";
                        i = 0;
                    }

                    dt.Rows.Add(dr);
                    dt.AcceptChanges();
                }
                metroGrid2.DataSource = dt;
                
            }
        }

        private void ComboBoxGrade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnSwitchUp_Click(object sender, EventArgs e)
        {
            if (ComboboxTargetSchoolYear.DataSource == null) return;
            if (metroGrid2.Rows.Count <= 0) return;
            if (Term_BUL.LoadBySC(ComboboxTargetSchoolYear.SelectedValue.ToString()) == null) return;
            if (ComboBoxTargetClass.DataSource == null) return;
            if (Class_BUL.LoadBySC(ComboboxTargetSchoolYear.SelectedValue.ToString()) == null) return;
            
            List<Term_DTO> term_DTOs = Term_BUL.LoadBySC(ComboboxTargetSchoolYear.SelectedValue.ToString());
            for (int i = 0; i < metroGrid2.SelectedRows.Count; i++)
            {
                for (int j = 0; j < term_DTOs.Count; j++)
                {
                    if (Process_BUL.GetProcess(Convert.ToInt32(metroGrid2.SelectedRows[i].Cells["Mã học sinh"].Value.ToString()), term_DTOs[j].ID, ComboBoxTargetClass.SelectedValue.ToString()) == null)
                    {
                        if (Process_BUL.ListProcessByTermAndID(Convert.ToInt32(metroGrid2.SelectedRows[i].Cells["Mã học sinh"].Value.ToString()), term_DTOs[j].ID)!=null)
                        {

                            MessageBox.Show("Không thể thêm quá trình học!", "Thông báo!");
                            break;
                        }else
                            if (Process_BUL.InitialProcess(ComboBoxTargetClass.SelectedValue.ToString(), Convert.ToInt32(metroGrid2.SelectedRows[i].Cells["Mã học sinh"].Value.ToString()), term_DTOs[j].ID))
                            {
                                Class_BUL.UpdateNumberStudent(metroGrid1.RowCount + 1, ComboBoxTargetClass.SelectedValue.ToString());
                                metroGrid1.DataSource = Process_BUL.LoadByClass(ComboBoxTargetClass.SelectedValue.ToString(), term_DTOs[j].ID);
                            }
                            else
                            {
                                MessageBox.Show("Không thể thêm quá trình học!", "Thông báo!");
                                break;
                            }
                    }
                    else
                    {
                        MessageBox.Show("Học sinh này đã được thực hiện từ trước!");
                        return;
                    }
                }
            }
            
        }

        private void ComboBoxTargetClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTargetClass.DataSource == null) return;
            List<Term_DTO> term_DTO = new List<Term_DTO>();
            if (Term_BUL.LoadBySC(ComboboxTargetSchoolYear.SelectedValue.ToString()) == null) return;
            else
            {
                term_DTO = Term_BUL.LoadBySC(ComboboxTargetSchoolYear.SelectedValue.ToString());
            }
            metroGrid1.DataSource = Process_BUL.LoadByClass(ComboBoxTargetClass.SelectedValue.ToString(), term_DTO[0].ID);
        }

        private void BtnGuide_Click(object sender, EventArgs e)
        {
            Tutorial.Tutorial_UpClass tutorial_UpClass = new Tutorial.Tutorial_UpClass();
            tutorial_UpClass.ShowDialog();
        }
    }
}
