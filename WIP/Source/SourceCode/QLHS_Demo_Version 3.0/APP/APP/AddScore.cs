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
using CID;
namespace APP
{
    public partial class AddScore : MaterialSkin.Controls.MaterialForm
    {
        Correct_Input_Data cid = new Correct_Input_Data();
        public AddScore()
        {
            InitializeComponent();
            metroGrid1.VirtualMode = true;
            metroGrid2.VirtualMode = true;
        }

        private void AddScore_Load(object sender, EventArgs e)
        {
            if (SchoolYear_BUL.Load() == null)
            {
                BtnAdd.Enabled = BtnUpdate.Enabled = BtnDelete.Enabled = false;
                ComboBoxListClass.Enabled = ComboBoxListTerm.Enabled = false;
                ComboBoxSchoolYear.DataSource = null;
            }
            else
            {
                BtnAdd.Enabled = BtnUpdate.Enabled = BtnDelete.Enabled = true;
                ComboBoxListTerm.Enabled = ComboBoxListTerm.Enabled = true;
                ComboBoxSchoolYear.DataSource = SchoolYear_BUL.Load();
                ComboBoxSchoolYear.ValueMember = "ID";
                ComboBoxSchoolYear.DisplayMember = "Name";
            }
            if (TypeExam_BUL.Load() == null)
            {
                BtnAdd.Enabled = BtnUpdate.Enabled = BtnDelete.Enabled = false;
                ComboboxTypeExam.Enabled = false;
                ComboboxTypeExam.DataSource = null;
            }
            else
            {
                BtnAdd.Enabled = BtnDelete.Enabled = BtnUpdate.Enabled = true;
                ComboboxTypeExam.Enabled = true;
                ComboboxTypeExam.DataSource = TypeExam_BUL.Load();
                ComboboxTypeExam.DisplayMember = "Name";
                ComboboxTypeExam.ValueMember = "ID";
            }
            if (Subject_BUL.Load() == null)
            {
                BtnAdd.Enabled = BtnUpdate.Enabled = BtnDelete.Enabled = false;
                ComboboxSubject.Enabled = false;
                ComboboxSubject.DataSource = null;
            }
            else
            {
                BtnAdd.Enabled = BtnDelete.Enabled = BtnUpdate.Enabled = true;
                ComboboxSubject.Enabled = true;
                ComboboxSubject.DataSource = Subject_BUL.Load();
                ComboboxSubject.DisplayMember = "Name";
                ComboboxSubject.ValueMember = "ID";
            }
        }

        private void ComboBoxSchoolYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Class_BUL.LoadBySC(ComboBoxSchoolYear.SelectedValue.ToString()) == null)
            {
                BtnAdd.Enabled = BtnUpdate.Enabled = BtnDelete.Enabled = false;
                ComboBoxListClass.Enabled = false;
                ComboBoxListClass.DataSource = null;
            }
            else
            {
                BtnAdd.Enabled = BtnUpdate.Enabled = BtnDelete.Enabled = true;
                ComboBoxListClass.Enabled = true;
                ComboBoxListClass.DataSource = Class_BUL.LoadBySC(ComboBoxSchoolYear.SelectedValue.ToString());
                ComboBoxListClass.DisplayMember = "Name";
                ComboBoxListClass.ValueMember = "ID";
            }

            if (Term_BUL.LoadBySC(ComboBoxSchoolYear.SelectedValue.ToString()) == null)
            {
                BtnAdd.Enabled = BtnUpdate.Enabled = BtnDelete.Enabled = false;
                ComboBoxListTerm.Enabled = false;
                ComboBoxListTerm.DataSource = null;
            }
            else
            {
                BtnAdd.Enabled = BtnUpdate.Enabled = BtnDelete.Enabled = true;
                ComboBoxListTerm.Enabled = true;
                ComboBoxListTerm.DataSource = Term_BUL.LoadBySC(ComboBoxSchoolYear.SelectedValue.ToString());
                ComboBoxListTerm.DisplayMember = "Name";
                ComboBoxListTerm.ValueMember = "ID";
            }
        }

        private void ComboBoxListClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxListTerm.DataSource == null || ComboBoxListClass.DataSource == null)
            {
                metroGrid1.DataSource = null;
                return;
            }
            else
            {
                if (Process_BUL.LoadByClass(ComboBoxListClass.SelectedValue.ToString(), ComboBoxListTerm.SelectedValue.ToString()) == null)
                {
                    metroGrid1.Enabled = BtnAdd.Enabled = BtnDelete.Enabled = false;
                    metroGrid1.DataSource = null;
                }
                else
                {
                    metroGrid1.Enabled = BtnAdd.Enabled = BtnDelete.Enabled = true;
                    metroGrid1.DataSource = Process_BUL.LoadByClass(ComboBoxListClass.SelectedValue.ToString(), ComboBoxListTerm.SelectedValue.ToString());
                }
            }
        }

        private void ComboBoxListTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxListClass.DataSource == null || ComboBoxListTerm.DataSource == null)
            {
                return;
            }
            else
            {

                if (Process_BUL.LoadByClass(ComboBoxListClass.SelectedValue.ToString(), ComboBoxListTerm.SelectedValue.ToString()) == null)
                {
                    metroGrid1.Enabled = BtnAdd.Enabled = BtnDelete.Enabled = false;
                    metroGrid1.DataSource = null;
                }
                else
                {
                    metroGrid1.Enabled = BtnAdd.Enabled = BtnDelete.Enabled = true;
                    metroGrid1.DataSource = Process_BUL.LoadByClass(ComboBoxListClass.SelectedValue.ToString(), ComboBoxListTerm.SelectedValue.ToString());
                }
            }
        }

        private void ComboboxTypeExam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboboxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboboxSubject.DataSource == null)
            {
                BtnAdd.Enabled = BtnUpdate.Enabled = BtnDelete.Enabled = false;
                metroGrid2.DataSource = null;
            }
            else
            {
                BtnAdd.Enabled = BtnUpdate.Enabled = BtnDelete.Enabled = true;

                if (ComboBoxListClass.DataSource == null || ComboBoxListTerm.DataSource == null || metroGrid1.DataSource == null)
                {
                    BtnAdd.Enabled = BtnUpdate.Enabled = BtnDelete.Enabled = false;
                    metroGrid2.DataSource = null;
                }
                else
                {
                    BtnAdd.Enabled = BtnUpdate.Enabled = BtnDelete.Enabled = true;
                    Process_DTO process_DTO = new Process_DTO();
                    process_DTO = Process_BUL.GetProcess(int.Parse(metroGrid1.SelectedRows[0].Cells[0].Value.ToString()), ComboBoxListTerm.SelectedValue.ToString(), ComboBoxListClass.SelectedValue.ToString());
                    ScoreBySubject_DTO scoreBySubject_DTO = new ScoreBySubject_DTO();
                    scoreBySubject_DTO.ID = ScoreBySubject_BUL.GetID(process_DTO.ID, ComboboxSubject.SelectedValue.ToString());
                    if (ScoreBySubject_BUL.GetID(process_DTO.ID, ComboboxSubject.SelectedValue.ToString()) == null)
                    {
                        BtnAdd.Enabled = BtnUpdate.Enabled = BtnDelete.Enabled = false;
                        metroGrid2.DataSource = null;
                    }
                    else
                    {
                        BtnAdd.Enabled = BtnUpdate.Enabled = BtnDelete.Enabled = true;
                        if (DetailScore_BUL.LoadBySBSID(scoreBySubject_DTO.ID) == null)
                        {
                            BtnAdd.Enabled = BtnUpdate.Enabled = BtnDelete.Enabled = false;
                            metroGrid2.DataSource = null;
                        }
                        else
                        {
                            BtnAdd.Enabled = BtnUpdate.Enabled = BtnDelete.Enabled = true;
                            metroGrid2.DataSource = DetailScore_BUL.LoadBySBSID(scoreBySubject_DTO.ID);
                        }
                    }
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (ComboboxSubject.DataSource == null)
            {
                BtnAdd.Enabled = BtnUpdate.Enabled = BtnDelete.Enabled = false;
                metroGrid2.DataSource = null;
            }
            else
            {
                BtnAdd.Enabled = BtnUpdate.Enabled = BtnDelete.Enabled = true;

                if (ComboBoxListClass.DataSource == null || ComboBoxListTerm.DataSource == null || metroGrid1.DataSource == null)
                {
                    BtnAdd.Enabled = BtnUpdate.Enabled = BtnDelete.Enabled = false;
                    metroGrid2.DataSource = null;
                }
                else
                {
                    BtnAdd.Enabled = BtnUpdate.Enabled = BtnDelete.Enabled = true;
                    Process_DTO process_DTO = new Process_DTO();
                    process_DTO = Process_BUL.GetProcess(int.Parse(metroGrid1.SelectedRows[0].Cells[0].Value.ToString()), ComboBoxListTerm.SelectedValue.ToString(), ComboBoxListClass.SelectedValue.ToString());
                    ScoreBySubject_DTO scoreBySubject_DTO = new ScoreBySubject_DTO();
                    scoreBySubject_DTO.ID = ScoreBySubject_BUL.GetID(process_DTO.ID, ComboboxSubject.SelectedValue.ToString());
                    if (ScoreBySubject_BUL.GetID(process_DTO.ID, ComboboxSubject.SelectedValue.ToString()) == null)
                    {
                        BtnAdd.Enabled = BtnUpdate.Enabled = BtnDelete.Enabled = false;
                        metroGrid2.DataSource = null;
                    }
                    else
                    {
                        if (DetailScore_BUL.InsertScoreByStudent(scoreBySubject_DTO.ID, ComboboxTypeExam.SelectedValue.ToString(), Double.Parse(Scoretxt.Text)))
                        {
                            metroGrid2.DataSource = DetailScore_BUL.LoadBySBSID(scoreBySubject_DTO.ID);
                            int count = 0;
                            double finalmark = 0;
                            for (int i = 0; i < DetailScore_BUL.LoadBySBSID(scoreBySubject_DTO.ID).Count; i++)
                            {
                                for (int j = 0; j < TypeExam_BUL.Load().Count; j++)
                                {
                                    if (TypeExam_BUL.Load()[j].ID == DetailScore_BUL.LoadBySBSID(scoreBySubject_DTO.ID)[i].TypeExamID)
                                    {
                                        count += TypeExam_BUL.Load()[j].Index;
                                        finalmark += DetailScore_BUL.LoadBySBSID(scoreBySubject_DTO.ID)[i].Score * TypeExam_BUL.Load()[j].Index;
                                    }
                                }
                            }
                            if (ScoreBySubject_BUL.UpdateScore(scoreBySubject_DTO.ID, (finalmark / count)))
                            {
                                MessageBox.Show("Cập nhật bảng điểm thành công!", "Thông báo!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm điểm!", "Thông báo!");
                        }
                    }
                }
            }
        }

        private void Scoretxt_TextChanged(object sender, EventArgs e)
        {
            if (Scoretxt.Text == ".") Scoretxt.Text = "0.";
            if (Scoretxt.Text == "")
            {
                BtnAdd.Enabled = BtnDelete.Enabled = false;
            }
            else
            {
                BtnAdd.Enabled = BtnDelete.Enabled = true;
                cid.InputString = Scoretxt.Text;
                Scoretxt.Text = cid.Real;
                Scoretxt.SelectionStart = Scoretxt.Text.Length;
                if (double.Parse(Scoretxt.Text) > 10 || double.Parse(Scoretxt.Text) < 0)
                {
                    Scoretxt.Text = "";
                }
            }
        }

        private void metroGrid1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid1.DataSource == null) return;
            if (ComboBoxListClass.DataSource == null || ComboBoxListTerm.DataSource == null || ComboBoxListClass == null) { metroGrid2.DataSource = null; return; }
            if (ComboboxSubject.DataSource == null) return;
            if (metroGrid1.SelectedRows.Count == 0) return;
            Process_DTO process_DTO = Process_BUL.GetProcess(int.Parse(metroGrid1.SelectedRows[0].Cells[0].Value.ToString()), ComboBoxListTerm.SelectedValue.ToString(), ComboBoxListClass.SelectedValue.ToString());
            if (Process_BUL.GetProcess(int.Parse(metroGrid1.SelectedRows[0].Cells[0].Value.ToString()), ComboBoxListTerm.SelectedValue.ToString(), ComboBoxListClass.SelectedValue.ToString()) == null) { metroGrid2.DataSource = null; return; }
            ScoreBySubject_DTO scoreBySubject_DTO = new ScoreBySubject_DTO();
            if (ScoreBySubject_BUL.GetID(process_DTO.ID, ComboboxSubject.SelectedValue.ToString()) == null)
            {
                metroGrid2.DataSource = null;
                return;
            }
            scoreBySubject_DTO.ID = ScoreBySubject_BUL.GetID(process_DTO.ID, ComboboxSubject.SelectedValue.ToString());
            if (DetailScore_BUL.LoadBySBSID(scoreBySubject_DTO.ID) == null)
            {
                BtnAdd.Enabled = BtnUpdate.Enabled = BtnDelete.Enabled = false;
                metroGrid2.DataSource = null;
            }
            else
            {
                BtnAdd.Enabled = BtnUpdate.Enabled = BtnDelete.Enabled = true;
                metroGrid2.DataSource = DetailScore_BUL.LoadBySBSID(scoreBySubject_DTO.ID);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (metroGrid2.DataSource == null || metroGrid1.DataSource == null || ComboBoxListClass.DataSource == null || ComboBoxListTerm.DataSource == null)
            {
                BtnDelete.Enabled = false;
            }
            else
            {
                for (int i = 0; i < metroGrid2.SelectedRows.Count; i++)
                {
                    if (DetailScore_BUL.DeleteScoreByStudent(int.Parse(metroGrid2.SelectedRows[i].Cells[1].Value.ToString())))
                    {

                    }
                    else
                    {
                        MessageBox.Show("Kiểm tra lại cơ sở dữ liệu!", "Thông báo!");
                        break;
                    }
                }
                BtnAdd.Enabled = BtnUpdate.Enabled = BtnDelete.Enabled = true;
                Process_DTO process_DTO = new Process_DTO();
                process_DTO = Process_BUL.GetProcess(int.Parse(metroGrid1.SelectedRows[0].Cells[0].Value.ToString()), ComboBoxListTerm.SelectedValue.ToString(), ComboBoxListClass.SelectedValue.ToString());
                ScoreBySubject_DTO scoreBySubject_DTO = new ScoreBySubject_DTO();
                scoreBySubject_DTO.ID = ScoreBySubject_BUL.GetID(process_DTO.ID, ComboboxSubject.SelectedValue.ToString());
                if (ScoreBySubject_BUL.GetID(process_DTO.ID, ComboboxSubject.SelectedValue.ToString()) == null)
                {
                    BtnAdd.Enabled = BtnUpdate.Enabled = BtnDelete.Enabled = false;
                    metroGrid2.DataSource = null;
                }
                else
                {
                    metroGrid2.DataSource = DetailScore_BUL.LoadBySBSID(scoreBySubject_DTO.ID);
                    int count = 0;
                    double finalmark = 0;
                    if (DetailScore_BUL.LoadBySBSID(scoreBySubject_DTO.ID)!=null) 
                    for (int i = 0; i < DetailScore_BUL.LoadBySBSID(scoreBySubject_DTO.ID).Count; i++)
                    {
                        for (int j = 0; j < TypeExam_BUL.Load().Count; j++)
                        {
                            if (TypeExam_BUL.Load()[j].ID == DetailScore_BUL.LoadBySBSID(scoreBySubject_DTO.ID)[i].TypeExamID)
                            {
                                count += TypeExam_BUL.Load()[j].Index;
                                finalmark += DetailScore_BUL.LoadBySBSID(scoreBySubject_DTO.ID)[i].Score * TypeExam_BUL.Load()[j].Index;
                            }
                        }
                    }
                    if (ScoreBySubject_BUL.UpdateScore(scoreBySubject_DTO.ID, (finalmark / count)))
                    {
                        MessageBox.Show("Cập nhật bảng điểm thành công!", "Thông báo!");
                    }
                }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (Scoretxt.Text == "" || metroGrid2.DataSource == null || metroGrid1.DataSource == null || ComboBoxListClass.DataSource == null || ComboBoxListTerm.DataSource == null)
            {
                BtnUpdate.Enabled = false;
            }
            else
            {
                for (int i = 0; i < metroGrid2.SelectedRows.Count; i++)
                {
                    if (DetailScore_BUL.UpdateScoreByStudent(int.Parse(metroGrid2.SelectedRows[i].Cells[1].Value.ToString()), double.Parse(Scoretxt.Text)))
                    {

                    }
                    else
                    {
                        MessageBox.Show("Kiểm tra lại cơ sở dữ liệu!", "Thông báo!");
                        break;
                    }
                }
                BtnAdd.Enabled = BtnUpdate.Enabled = BtnDelete.Enabled = true;
                Process_DTO process_DTO = new Process_DTO();
                process_DTO = Process_BUL.GetProcess(int.Parse(metroGrid1.SelectedRows[0].Cells[0].Value.ToString()), ComboBoxListTerm.SelectedValue.ToString(), ComboBoxListClass.SelectedValue.ToString());
                ScoreBySubject_DTO scoreBySubject_DTO = new ScoreBySubject_DTO();
                scoreBySubject_DTO.ID = ScoreBySubject_BUL.GetID(process_DTO.ID, ComboboxSubject.SelectedValue.ToString());
                if (ScoreBySubject_BUL.GetID(process_DTO.ID, ComboboxSubject.SelectedValue.ToString()) == null)
                {
                    BtnAdd.Enabled = BtnUpdate.Enabled = BtnDelete.Enabled = false;
                    metroGrid2.DataSource = null;
                }
                else
                {
                    metroGrid2.DataSource = DetailScore_BUL.LoadBySBSID(scoreBySubject_DTO.ID);
                    int count = 0;
                    double finalmark = 0;
                    for (int i = 0; i < DetailScore_BUL.LoadBySBSID(scoreBySubject_DTO.ID).Count; i++)
                    {
                        for (int j = 0; j < TypeExam_BUL.Load().Count; j++)
                        {
                            if (TypeExam_BUL.Load()[j].ID == DetailScore_BUL.LoadBySBSID(scoreBySubject_DTO.ID)[i].TypeExamID)
                            {
                                count += TypeExam_BUL.Load()[j].Index;
                                finalmark += DetailScore_BUL.LoadBySBSID(scoreBySubject_DTO.ID)[i].Score * TypeExam_BUL.Load()[j].Index;
                            }
                        }
                    }
                    if (ScoreBySubject_BUL.UpdateScore(scoreBySubject_DTO.ID, (finalmark / count)))
                    {
                        MessageBox.Show("Cập nhật bảng điểm thành công!", "Thông báo!");
                    }
                }
            }
        }
    }
}
