using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using DTO;
using BUL;
namespace APP
{
    public partial class InsertStudentToAClass : MaterialSkin.Controls.MaterialForm
    {
        private Student_DTO ChangeType(DataGridViewRow dr)
        {
            Student_DTO student_DTO = new Student_DTO();
            student_DTO.ID = Convert.ToInt32(dr.Cells[1].Value.ToString());
            student_DTO.Status = dr.Cells[0].Value.ToString();
            student_DTO.Name = dr.Cells[2].Value.ToString();
            student_DTO.Sex = dr.Cells[3].Value.ToString();
            student_DTO.Birthday = Convert.ToDateTime(dr.Cells[4].Value.ToString());
            student_DTO.Birthplace = dr.Cells[5].Value.ToString();
            student_DTO.Address = dr.Cells[6].Value.ToString();
            student_DTO.Religion = dr.Cells[7].Value.ToString();
            student_DTO.National = dr.Cells[8].Value.ToString();
            student_DTO.Phone = dr.Cells[9].Value.ToString();
            student_DTO.Father = dr.Cells[10].Value.ToString();
            student_DTO.FJob = dr.Cells[11].Value.ToString();
            student_DTO.Mother = dr.Cells[12].Value.ToString();
            student_DTO.MJob = dr.Cells[13].Value.ToString();
            return student_DTO;
        }
        public InsertStudentToAClass()
        {
            InitializeComponent();
            metroGrid1.VirtualMode = true;
            metroGrid2.VirtualMode = true;
        }



        private void InsertStudentToAClass_Load(object sender, EventArgs e)
        {
            if (SchoolYear_BUL.Load() == null)
            {
                ComboBoxListClass.Enabled = ComboBoxListTerm.Enabled = ComboBoxSchoolYear.Enabled = BtnAdd.Enabled = false;
            }
            else
            {
                ComboBoxListClass.Enabled = ComboBoxListTerm.Enabled = ComboBoxSchoolYear.Enabled = BtnAdd.Enabled = true;
                ComboBoxSchoolYear.DataSource = SchoolYear_BUL.Load();
            }
            if (Student_BUL.Load() == null) { metroGrid1.Enabled = BtnAdd.Enabled = false;
            }
            else {
                metroGrid1.Enabled = BtnAdd.Enabled = true;
                metroGrid1.DataSource = Student_BUL.Load();
            }
        }
        private void ComboBoxSchoolYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxListClass.DataSource = Class_BUL.LoadBySC(ComboBoxSchoolYear.SelectedValue.ToString());
            ComboBoxListClass.ValueMember = "ID";
            ComboBoxListClass.DisplayMember = "Name";
        }
        private void ComboBoxListClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxListTerm.DataSource = Term_BUL.LoadBySC(ComboBoxSchoolYear.SelectedValue.ToString());
            ComboBoxListTerm.ValueMember = "ID";
            ComboBoxListTerm.DisplayMember = "Name";
            if (Class_BUL.LoadBySC(ComboBoxSchoolYear.SelectedValue.ToString()) == null && Term_BUL.LoadBySC(ComboBoxSchoolYear.SelectedValue.ToString())==null)
            {
                metroGrid2.DataSource = null;
                metroGrid2.Enabled = BtnAdd.Enabled = false;
            }
            else
            {
                BtnAdd.Enabled = metroGrid2.Enabled = true;
                metroGrid2.DataSource = Process_BUL.LoadByClass(ComboBoxListClass.SelectedValue.ToString(), ComboBoxListTerm.SelectedValue.ToString());
            }
        }
        private void ComboBoxListTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Class_BUL.LoadBySC(ComboBoxSchoolYear.SelectedValue.ToString()) == null && Term_BUL.LoadBySC(ComboBoxSchoolYear.SelectedValue.ToString()) == null)
            {
                metroGrid2.DataSource = null;
                metroGrid2.Enabled = BtnAdd.Enabled = false;
            }
            else
            {
                BtnAdd.Enabled = metroGrid2.Enabled = true;
                metroGrid2.DataSource = Process_BUL.LoadByClass(ComboBoxListClass.SelectedValue.ToString(), ComboBoxListTerm.SelectedValue.ToString());
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (metroGrid1.DataSource == null) return;
            List<Term_DTO> term_DTOs = Term_BUL.LoadBySC(ComboBoxSchoolYear.SelectedValue.ToString());
            Student_DTO student_DTO;
            for (int i = 0; i < metroGrid1.SelectedRows.Count; i++)
            {
                student_DTO = ChangeType(metroGrid1.SelectedRows[i]);
                for (int j = 0; j < term_DTOs.Count; j++)
                {
                    if (Process_BUL.InitialProcess(ComboBoxListClass.SelectedValue.ToString(), student_DTO.ID, term_DTOs[j].ID)) {
                        student_DTO.Status = "Inserted";
                        Class_BUL.UpdateNumberStudent(metroGrid2.RowCount+1, ComboBoxListClass.SelectedValue.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm quá trình học!", "Thông báo!");
                        break;
                    }
                }
                if (student_DTO.Status == "Inserted")
                {
                    if (!Student_BUL.Update(student_DTO))
                    {
                        MessageBox.Show("Không thể cập nhật học sinh!", "Thông báo!");
                        break;
                    }
                }
            }
            metroGrid1.DataSource = Student_BUL.Load();
            metroGrid2.DataSource = Process_BUL.LoadByClass(ComboBoxListClass.SelectedValue.ToString(), ComboBoxListTerm.SelectedValue.ToString());
        }
        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Student_BUL.Load()==null) return;
            if (metroGrid1.SelectedRows.Count + Process_BUL.CountStudent(ComboBoxListClass.SelectedValue.ToString(), ComboBoxListTerm.SelectedValue.ToString()) >= Rule_BUL.Load().MaxStudent)
            {
                BtnAdd.Enabled = false;
            }
            else
            {
                BtnAdd.Enabled = true;
            }
        }
        private void metroGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Process_BUL.LoadByClass(ComboBoxListClass.SelectedValue.ToString(), ComboBoxListTerm.SelectedValue.ToString()) == null) return;
        }
    }
}
