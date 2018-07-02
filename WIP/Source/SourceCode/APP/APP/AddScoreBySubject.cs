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
using BUL;
using DTO;
using CID;
namespace APP
{
    public partial class AddScoreBySubject : MaterialSkin.Controls.MaterialForm
    {
        Correct_Input_Data cid = new Correct_Input_Data();
        public AddScoreBySubject()
        {
            InitializeComponent();
            metroGrid1.VirtualMode = true;
            metroGrid2.VirtualMode = true;
        }

        private void AddScoreBySubject_Load(object sender, EventArgs e)
        {
            if (SchoolYear_BUL.Load() == null)
            {
                BtnAdd.Enabled = BtnDelete.Enabled = false;
            }
            else
            {
                BtnAdd.Enabled = BtnDelete.Enabled = true;
                ComboBoxListSchoolYear.DataSource = SchoolYear_BUL.Load();
            }
            if (Subject_BUL.Load()==null)
            {
                BtnAdd.Enabled = false;
                BtnDelete.Enabled = false;
            }
            else
            {
                BtnAdd.Enabled = BtnDelete.Enabled = true;
                ComboBoxListSubject.DataSource = Subject_BUL.Load();
            }
        }

        private void BtnGuide_Click(object sender, EventArgs e)
        {
            Tutorial.Tutorial_AddScoreBySubject tutorial_AddScoreBySubject = new Tutorial.Tutorial_AddScoreBySubject();
            tutorial_AddScoreBySubject.ShowDialog();
            this.Refresh();
        }

        private void ComboBoxListSchoolYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Term_BUL.LoadBySC(ComboBoxListSchoolYear.SelectedValue.ToString()) == null || Class_BUL.LoadBySC(ComboBoxListSchoolYear.SelectedValue.ToString()) == null)
            {
                BtnAdd.Enabled = BtnDelete.Enabled = false;
                ComboBoxListClass.Enabled = ComboBoxListTerm.Enabled = false;
                metroGrid2.DataSource = null;
            }
            else
            {
                BtnAdd.Enabled = BtnDelete.Enabled = true;
                ComboBoxListClass.Enabled = ComboBoxListTerm.Enabled = true;
                ComboBoxListClass.DataSource = Class_BUL.LoadBySC(ComboBoxListSchoolYear.SelectedValue.ToString());
                ComboBoxListClass.DisplayMember = "Name";
                ComboBoxListClass.ValueMember = "ID";
                ComboBoxListTerm.DataSource = Term_BUL.LoadBySC(ComboBoxListSchoolYear.SelectedValue.ToString());
                ComboBoxListTerm.DisplayMember = "Name";
                ComboBoxListTerm.ValueMember = "ID";
            }
        }
        //Mục đích: Load danh sách học sinh thuộc lớp *. trong học kỳ n
        private void ComboBoxListClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Class_BUL.LoadBySC(ComboBoxListSchoolYear.SelectedValue.ToString()) == null && Term_BUL.LoadBySC(ComboBoxListSchoolYear.SelectedValue.ToString()) == null)
            {
                BtnAdd.Enabled = BtnDelete.Enabled = false;
                metroGrid2.DataSource = null;
                return;
            }
            else
            {
                ComboBoxListTerm.DataSource = Term_BUL.LoadBySC(ComboBoxListSchoolYear.SelectedValue.ToString());
                if (ComboBoxListTerm!=null)
                {
                    BtnAdd.Enabled = BtnDelete.Enabled = true;
                    metroGrid2.DataSource = Process_BUL.LoadByClass(ComboBoxListClass.SelectedValue.ToString(), ComboBoxListTerm.SelectedValue.ToString());
                }
                else
                {
                    BtnAdd.Enabled = BtnDelete.Enabled = false;
                    metroGrid2.DataSource = null;
                    return;
                }
            }
        }

        private void ComboBoxListTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Class_BUL.LoadBySC(ComboBoxListSchoolYear.SelectedValue.ToString()) == null && Term_BUL.LoadBySC(ComboBoxListSchoolYear.SelectedValue.ToString()) == null)
            {
                BtnAdd.Enabled = BtnDelete.Enabled = false;
                metroGrid2.DataSource = null;
                return;
            }
            else
            {
                    BtnAdd.Enabled = BtnDelete.Enabled = true;
                    metroGrid2.DataSource = Process_BUL.LoadByClass(ComboBoxListClass.SelectedValue.ToString(), ComboBoxListTerm.SelectedValue.ToString());
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (SchoolYear_BUL.Load() == null || Class_BUL.LoadBySC(ComboBoxListSchoolYear.SelectedValue.ToString()) == null || Term_BUL.LoadBySC(ComboBoxListSchoolYear.SelectedValue.ToString()) == null) return;
            if (Subject_BUL.Load() == null)
            { BtnAdd.Enabled = BtnDelete.Enabled = false;
                return;
            }
            else
            {
                BtnAdd.Enabled = BtnDelete.Enabled = true;
            }
            ScoreBySubject_DTO scoreBySubject_DTO;
            Process_DTO process_DTO = new Process_DTO();
            process_DTO = Process_BUL.GetProcess(int.Parse(metroGrid2.SelectedRows[0].Cells[0].Value.ToString()), ComboBoxListTerm.SelectedValue.ToString(), ComboBoxListClass.SelectedValue.ToString());

            scoreBySubject_DTO = new ScoreBySubject_DTO();
            scoreBySubject_DTO.ID = IDtxt.Text;
            scoreBySubject_DTO.ProcessID = process_DTO.ID;
            scoreBySubject_DTO.SubjectID = ComboBoxListSubject.SelectedValue.ToString();
            scoreBySubject_DTO.FinalScore = 0;
            if (ScoreBySubject_BUL.LoadByProcessID(process_DTO.ID) != null)
            {
                for (int i = 0; i < ScoreBySubject_BUL.LoadByProcessID(process_DTO.ID).Count; i++)
                {
                    if (ScoreBySubject_BUL.LoadByProcessID(process_DTO.ID)[i].ID == scoreBySubject_DTO.ID)
                    {
                        MessageBox.Show("Trùng mã bảng điểm môn!","Thông báo");
                        IDtxt.Focus();
                        return;
                    }
                }
            }
            
             
                if (ScoreBySubject_BUL.Insert(scoreBySubject_DTO))
                {
                    metroGrid1.DataSource = ScoreBySubject_BUL.LoadByProcessID(process_DTO.ID);
                    IDtxt.Focus();
                }
                else
                {
                    MessageBox.Show("Không thể thêm bảng điểm môn học!", "Thông báo!");
                }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (SchoolYear_BUL.Load() == null || Class_BUL.LoadBySC(ComboBoxListSchoolYear.SelectedValue.ToString()) == null || Term_BUL.LoadBySC(ComboBoxListSchoolYear.SelectedValue.ToString()) == null) return;
            if (Subject_BUL.Load() == null)
            {
                BtnAdd.Enabled = BtnDelete.Enabled = false;
                return;
            }
            else
            {
                BtnAdd.Enabled = BtnDelete.Enabled = true;
            }
            ScoreBySubject_DTO scoreBySubject_DTO;
            Process_DTO process_DTO = new Process_DTO();
            process_DTO = Process_BUL.GetProcess(int.Parse(metroGrid2.SelectedRows[0].Cells[0].Value.ToString()), ComboBoxListTerm.SelectedValue.ToString(), ComboBoxListClass.SelectedValue.ToString());
            scoreBySubject_DTO = new ScoreBySubject_DTO();
            scoreBySubject_DTO.ID = IDtxt.Text;
            scoreBySubject_DTO.ProcessID = process_DTO.ID;
            scoreBySubject_DTO.SubjectID = ComboBoxListSubject.SelectedValue.ToString();
            scoreBySubject_DTO.FinalScore = 0;
            if (ScoreBySubject_BUL.LoadByProcessID(process_DTO.ID) == null)
            {
                BtnDelete.Enabled = false;
                return;
            }
            for (int i = 0; i < metroGrid1.SelectedRows.Count; i++)
            {
                if (ScoreBySubject_BUL.Delete(metroGrid1.SelectedRows[i].Cells[0].Value.ToString()))
                {

                }
                else
                {
                    MessageBox.Show("Kiểm tra lại cơ sở dữ liệu!", "Thông báo!");
                    break;
                }
            }
            metroGrid1.DataSource = ScoreBySubject_BUL.LoadByProcessID(process_DTO.ID);
        }

        private void IDtxt_TextChanged(object sender, EventArgs e)
        {
            if (IDtxt.Text == "")
            {
                BtnAdd.Enabled = false;
            }
            else
            {
                BtnAdd.Enabled = true;
                cid.InputString = IDtxt.Text;
                IDtxt.Text = cid.TrueID;
                IDtxt.SelectionStart = IDtxt.Text.Length;
            }
        }

        private void metroGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SchoolYear_BUL.Load()==null&& Class_BUL.LoadBySC(ComboBoxListSchoolYear.SelectedValue.ToString()) == null && Term_BUL.LoadBySC(ComboBoxListSchoolYear.SelectedValue.ToString()) == null)
            {
                BtnAdd.Enabled = BtnDelete.Enabled = false;
                metroGrid2.DataSource = null;
                return;
            }
            else
            {
                Process_DTO process_DTO = new Process_DTO();
                process_DTO = Process_BUL.GetProcess(int.Parse(metroGrid2.SelectedRows[0].Cells[0].Value.ToString()),ComboBoxListTerm.SelectedValue.ToString(),ComboBoxListClass.SelectedValue.ToString());
                metroGrid1.DataSource= ScoreBySubject_BUL.LoadByProcessID(process_DTO.ID);
            }
        }

        private void QuicklyCreate_Click(object sender, EventArgs e)
        {
            if (SchoolYear_BUL.Load() == null || Class_BUL.LoadBySC(ComboBoxListSchoolYear.SelectedValue.ToString()) == null || Term_BUL.LoadBySC(ComboBoxListSchoolYear.SelectedValue.ToString()) == null) return;
            if (Subject_BUL.Load() == null)
            {
                BtnAdd.Enabled = BtnDelete.Enabled = false;
                return;
            }
            else
            {
                BtnAdd.Enabled = BtnDelete.Enabled = true;
            }
            ScoreBySubject_DTO scoreBySubject_DTO;
            Process_DTO process_DTO = new Process_DTO();
            process_DTO = Process_BUL.GetProcess(int.Parse(metroGrid2.SelectedRows[0].Cells[0].Value.ToString()), ComboBoxListTerm.SelectedValue.ToString(), ComboBoxListClass.SelectedValue.ToString());
            scoreBySubject_DTO = new ScoreBySubject_DTO();
            scoreBySubject_DTO.ProcessID = process_DTO.ID;
            scoreBySubject_DTO.FinalScore = 0;
            if (ScoreBySubject_BUL.LoadByProcessID(process_DTO.ID) != null)
            {
                for (int i = 0; i < ScoreBySubject_BUL.LoadByProcessID(process_DTO.ID).Count; i++)
                {
                    if (ScoreBySubject_BUL.LoadByProcessID(process_DTO.ID)[i].ID == scoreBySubject_DTO.ID)
                    {
                        MessageBox.Show("Trùng mã bảng điểm môn!", "Thông báo");
                        IDtxt.Focus();
                        return;
                    }
                }
            }

            for (int i = 0; i < Subject_BUL.Load().Count; i++)
            {
                IDtxt.Text = Subject_BUL.Load()[i].ID + metroGrid2.SelectedRows[0].Cells[0].Value.ToString() + ComboBoxListTerm.SelectedValue.ToString();
                scoreBySubject_DTO.SubjectID = Subject_BUL.Load()[i].ID;
                scoreBySubject_DTO.ID = IDtxt.Text;
                if (ScoreBySubject_BUL.Insert(scoreBySubject_DTO))
                {
                    metroGrid1.DataSource = ScoreBySubject_BUL.LoadByProcessID(process_DTO.ID);
                    IDtxt.Text = "";
                    IDtxt.Focus();

                }
                else
                {
                    MessageBox.Show("Không thể thêm bảng điểm môn học!", "Thông báo!");
                }
            }
            
        }
    }
}
