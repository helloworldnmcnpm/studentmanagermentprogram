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
using System.Data.OleDb;
using System.Data.SqlClient;
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
                ComboBoxListClass.Enabled = ComboBoxListTerm.Enabled = ComboBoxSchoolYear.Enabled = false;
                ComboBoxListClass.DataSource = ComboBoxListTerm.DataSource = ComboBoxSchoolYear.DataSource = null;
            }
            else
            {
                ComboBoxListClass.Enabled = ComboBoxListTerm.Enabled = ComboBoxSchoolYear.Enabled = true;
                ComboBoxSchoolYear.DataSource = SchoolYear_BUL.Load();
            }
            if (Subject_BUL.Load() == null)
            {
                BtnAdd.Enabled = BtnUpdate.Enabled = BtnDelete.Enabled = false;
                ComboboxSubject.Enabled = false;
                ComboboxSubject.DataSource = null;
            }
            else
            {
                BtnAdd.Enabled = BtnUpdate.Enabled = BtnDelete.Enabled = true;
                ComboboxSubject.Enabled = true;
                ComboboxSubject.DisplayMember = "Name";
                ComboboxSubject.ValueMember = "ID";
                ComboboxSubject.DataSource = Subject_BUL.Load();
            }
            if (TypeExam_BUL.Load() == null)
            {
                BtnAdd.Enabled = BtnUpdate.Enabled = BtnDelete.Enabled = false;
                ComboboxTypeExam.Enabled = false;
                ComboboxTypeExam.DataSource = null;
            }
            else
            {
                BtnAdd.Enabled = BtnUpdate.Enabled = BtnDelete.Enabled = true;
                ComboboxTypeExam.Enabled = true;
                ComboboxTypeExam.DisplayMember = "Name";
                ComboboxTypeExam.ValueMember = "ID";
                ComboboxTypeExam.DataSource = TypeExam_BUL.Load();
            }
        }

        private void ComboBoxSchoolYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Class_BUL.LoadBySC(ComboBoxSchoolYear.SelectedValue.ToString()) == null)
            {
                ComboBoxListClass.DataSource = null;
                ComboBoxListTerm.DataSource = null;
                ComboBoxListTerm.Enabled = false;
                ComboBoxListClass.Enabled = false;
            }
            else
            {
                ComboBoxListTerm.DisplayMember = ComboBoxListClass.DisplayMember = "Name";
                ComboBoxListTerm.ValueMember = ComboBoxListClass.ValueMember = "ID";
                ComboBoxListClass.Enabled = true;
                ComboBoxListTerm.Enabled = true;
                ComboBoxListClass.DataSource = Class_BUL.LoadBySC(ComboBoxSchoolYear.SelectedValue.ToString());
                ComboBoxListTerm.DataSource = Term_BUL.LoadBySC(ComboBoxSchoolYear.SelectedValue.ToString());
            }
        }
        private void ComboBoxListClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxListTerm.DataSource == null || ComboBoxListClass.DataSource == null)
            {
                metroGrid1.DataSource = null;
                metroGrid1.Enabled = false;
                return;
            }
            else
            {
                metroGrid1.Enabled = true;
                metroGrid1.DataSource = Process_BUL.LoadByClass(ComboBoxListClass.SelectedValue.ToString(), ComboBoxListTerm.SelectedValue.ToString());
            }
        }
        private void ComboBoxListTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxListClass.DataSource == null || ComboBoxListTerm.DataSource == null)
            {
                metroGrid1.DataSource = null;
                metroGrid1.Enabled = false;
                return;
            }
            else
            {
                metroGrid1.Enabled = true;
                metroGrid1.DataSource = Process_BUL.LoadByClass(ComboBoxListClass.SelectedValue.ToString(), ComboBoxListTerm.SelectedValue.ToString());
            }
        }
        private void ComboboxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroGrid1.DataSource == null || metroGrid1.SelectedRows.Count == 0)
            {
                metroGrid2.Enabled = false;
                metroGrid2.DataSource = null;
                return;
            }
            else
            {
                metroGrid2.Enabled = true;
                int ProcessID = Process_BUL.GetProcess(int.Parse(metroGrid1.SelectedRows[0].Cells[0].Value.ToString()), ComboBoxListTerm.SelectedValue.ToString(), ComboBoxListClass.SelectedValue.ToString()).ID;
                string SubjectID = ComboboxSubject.SelectedValue.ToString();
                string ScoreBySubjectID = ScoreBySubject_BUL.GetID(ProcessID, SubjectID);
                metroGrid2.DataSource = DetailScore_BUL.LoadBySBSID(ScoreBySubjectID);
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
            if (metroGrid1.SelectedRows.Count == 0 || ComboboxSubject.DataSource == null)
            {
                metroGrid2.Enabled = false;
                metroGrid2.DataSource = null;
                return;
            }
            else
            {
                metroGrid2.Enabled = true;
                int ProcessID = Process_BUL.GetProcess(int.Parse(metroGrid1.SelectedRows[0].Cells[0].Value.ToString()), ComboBoxListTerm.SelectedValue.ToString(), ComboBoxListClass.SelectedValue.ToString()).ID;
                string SubjectID = ComboboxSubject.SelectedValue.ToString();
                string ScoreBySubjectID = ScoreBySubject_BUL.GetID(ProcessID, SubjectID);
                metroGrid2.DataSource = DetailScore_BUL.LoadBySBSID(ScoreBySubjectID);
                UpdateScore(int.Parse(metroGrid1.SelectedRows[0].Cells[0].Value.ToString()), ComboBoxListClass.SelectedValue.ToString(), ComboBoxListTerm.SelectedValue.ToString());

                UpdateAllScoreBySubject(Process_BUL.GetProcess(int.Parse(metroGrid1.SelectedRows[0].Cells[0].Value.ToString()), ComboBoxListTerm.SelectedValue.ToString(), ComboBoxListClass.SelectedValue.ToString()));
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (Scoretxt.Text == "")
            {
                BtnAdd.Enabled = BtnUpdate.Enabled = false;
                return;
            }
            int ProcessID = Process_BUL.GetProcess(int.Parse(metroGrid1.SelectedRows[0].Cells[0].Value.ToString()), ComboBoxListTerm.SelectedValue.ToString(), ComboBoxListClass.SelectedValue.ToString()).ID;
            string SubjectID = ComboboxSubject.SelectedValue.ToString();
            string ScoreBySubjectID = ScoreBySubject_BUL.GetID(ProcessID, SubjectID);
            //ADDSCORE
            {
                if (DetailScore_BUL.InsertScoreByStudent(ScoreBySubjectID, ComboboxTypeExam.SelectedValue.ToString(), Convert.ToDouble(Scoretxt.Text)))
                {
                    metroGrid2.DataSource = DetailScore_BUL.LoadBySBSID(ScoreBySubjectID);
                }
                else
                {
                    MessageBox.Show("Kiểm tra lại cơ sở dữ liệu!", "Thông báo!");
                }
            }
            //UPDATE SCORE IN SCOREBYSUBJECT
            {
                int count_index = 0;
                double score = 0;
                for (int i = 0; i < metroGrid2.RowCount; i++)
                {
                    int index = TypeExam_BUL.GetIndex(metroGrid2.Rows[i].Cells[0].Value.ToString());
                    score += Convert.ToDouble(metroGrid2.Rows[i].Cells[2].Value.ToString()) * index;
                    count_index += index;
                }
                if (ScoreBySubject_BUL.UpdateScore(ScoreBySubjectID, score / count_index))
                {
                    //UPDATEPROCESS
                    Process_BUL.InitialFinalScore(ProcessID);
                    UpdateScore(int.Parse(metroGrid1.SelectedRows[0].Cells[0].Value.ToString()), ComboBoxListClass.SelectedValue.ToString(),ComboBoxListTerm.SelectedValue.ToString());
                    UpdateAllScoreBySubject(Process_BUL.GetProcess(int.Parse(metroGrid1.SelectedRows[0].Cells[0].Value.ToString()), ComboBoxListTerm.SelectedValue.ToString(), ComboBoxListClass.SelectedValue.ToString()));
                }
                else
                {
                    MessageBox.Show("Cập nhật bảng điểm môn <Điểm TBM> thất bại!", "Thông báo!");
                }

            }

        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (metroGrid2.DataSource == null || metroGrid2.SelectedRows.Count == 0)
            {
                BtnDelete.Enabled = false;
                return;
            }
            else
            {
                for (int i = 0; i < metroGrid2.SelectedRows.Count; i++)
                {
                    if (DetailScore_BUL.DeleteScoreByStudent(Convert.ToInt32(metroGrid2.SelectedRows[i].Cells[1].Value.ToString())))
                    {

                    }
                    else
                    {
                        MessageBox.Show("Kiểm tra lại cơ sở dữ liệu!", "Thông báo!");
                    }
                }
                int ProcessID = Process_BUL.GetProcess(int.Parse(metroGrid1.SelectedRows[0].Cells[0].Value.ToString()), ComboBoxListTerm.SelectedValue.ToString(), ComboBoxListClass.SelectedValue.ToString()).ID;
                string SubjectID = ComboboxSubject.SelectedValue.ToString();
                string ScoreBySubjectID = ScoreBySubject_BUL.GetID(ProcessID, SubjectID);
                metroGrid2.DataSource = DetailScore_BUL.LoadBySBSID(ScoreBySubjectID);
                {
                    int count_index = 0;
                    double score = 0;
                    if (metroGrid2.RowCount == 0)
                    {
                        if (ScoreBySubject_BUL.UpdateScore(ScoreBySubjectID, 0))
                        {
                            //UPDATEPROCESS
                            Process_BUL.InitialFinalScore(ProcessID);
                            UpdateScore(int.Parse(metroGrid1.SelectedRows[0].Cells[0].Value.ToString()), ComboBoxListClass.SelectedValue.ToString(), ComboBoxListTerm.SelectedValue.ToString());

                            UpdateAllScoreBySubject(Process_BUL.GetProcess(int.Parse(metroGrid1.SelectedRows[0].Cells[0].Value.ToString()), ComboBoxListTerm.SelectedValue.ToString(), ComboBoxListClass.SelectedValue.ToString()));
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật bảng điểm môn <Điểm TBM> thất bại!", "Thông báo!");
                        }
                    }
                    else
                    {
                        for (int i = 0; i < metroGrid2.RowCount; i++)
                        {
                            int index = TypeExam_BUL.GetIndex(metroGrid2.Rows[i].Cells[0].Value.ToString());
                            score += Convert.ToDouble(metroGrid2.Rows[i].Cells[2].Value.ToString()) * index;
                            count_index += index;
                        }
                        if (ScoreBySubject_BUL.UpdateScore(ScoreBySubjectID, score / count_index))
                        {
                            //UPDATEPROCESS
                            Process_BUL.InitialFinalScore(ProcessID);
                            UpdateScore(int.Parse(metroGrid1.SelectedRows[0].Cells[0].Value.ToString()), ComboBoxListClass.SelectedValue.ToString(), ComboBoxListTerm.SelectedValue.ToString());

                            UpdateAllScoreBySubject(Process_BUL.GetProcess(int.Parse(metroGrid1.SelectedRows[0].Cells[0].Value.ToString()), ComboBoxListTerm.SelectedValue.ToString(), ComboBoxListClass.SelectedValue.ToString()));
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật bảng điểm môn <Điểm TBM> thất bại!", "Thông báo!");
                        }
                    }
                }
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (Scoretxt.Text == "")
            {
                BtnAdd.Enabled = BtnUpdate.Enabled = false;
                return;
            }
            int ProcessID = Process_BUL.GetProcess(int.Parse(metroGrid1.SelectedRows[0].Cells[0].Value.ToString()), ComboBoxListTerm.SelectedValue.ToString(), ComboBoxListClass.SelectedValue.ToString()).ID;
            string SubjectID = ComboboxSubject.SelectedValue.ToString();
            string ScoreBySubjectID = ScoreBySubject_BUL.GetID(ProcessID, SubjectID);
            {
                if (DetailScore_BUL.UpdateScoreByStudent(Convert.ToInt32(metroGrid2.SelectedRows[0].Cells[1].Value.ToString()), Convert.ToDouble(Scoretxt.Text)))
                {
                    metroGrid2.DataSource = DetailScore_BUL.LoadBySBSID(ScoreBySubjectID);
                    UpdateScore(int.Parse(metroGrid1.SelectedRows[0].Cells[0].Value.ToString()), ComboBoxListClass.SelectedValue.ToString(), ComboBoxListTerm.SelectedValue.ToString());

                    UpdateAllScoreBySubject(Process_BUL.GetProcess(int.Parse(metroGrid1.SelectedRows[0].Cells[0].Value.ToString()), ComboBoxListTerm.SelectedValue.ToString(), ComboBoxListClass.SelectedValue.ToString()));
                }
                else
                {
                    MessageBox.Show("Kiểm tra lại cơ sở dữ liệu!", "Thông báo!");
                }
            }
            {
                int count_index = 0;
                double score = 0;
                for (int i = 0; i < metroGrid2.RowCount; i++)
                {
                    int index = TypeExam_BUL.GetIndex(metroGrid2.Rows[i].Cells[0].Value.ToString());
                    score += Convert.ToDouble(metroGrid2.Rows[i].Cells[2].Value.ToString()) * index;
                    count_index += index;
                }
                if (ScoreBySubject_BUL.UpdateScore(ScoreBySubjectID, score / count_index))
                {
                    //UPDATEPROCESS
                    Process_BUL.InitialFinalScore(ProcessID);
                    UpdateScore(int.Parse(metroGrid1.SelectedRows[0].Cells[0].Value.ToString()), ComboBoxListClass.SelectedValue.ToString(), ComboBoxListTerm.SelectedValue.ToString());

                    UpdateAllScoreBySubject(Process_BUL.GetProcess(int.Parse(metroGrid1.SelectedRows[0].Cells[0].Value.ToString()), ComboBoxListTerm.SelectedValue.ToString(), ComboBoxListClass.SelectedValue.ToString()));
                }
                else
                {
                    MessageBox.Show("Cập nhật bảng điểm môn <Điểm TBM> thất bại!", "Thông báo!");
                }
            }

        }
        private void InsertScoreByExcel_Click(object sender, EventArgs e)
        {
            ImportFromExcel.Import_From_Excel import_From_Excel = new ImportFromExcel.Import_From_Excel();
            import_From_Excel.ShowDialog();
            UpdateAllScoreBySubject(Process_BUL.GetProcess(int.Parse(metroGrid1.SelectedRows[0].Cells[0].Value.ToString()), ComboBoxListTerm.SelectedValue.ToString(), ComboBoxListClass.SelectedValue.ToString()));
        }
        private void UpdateScore(int StudentID, string ClassID, string TermID)
        {
            if (Process_BUL.GetProcess(StudentID, ClassID, TermID) != null)
            {
                Process_DTO Process_Of_Student = Process_BUL.GetProcess(StudentID, ClassID, TermID);
                List<ScoreBySubject_DTO> ListScoreBySubject = ScoreBySubject_BUL.LoadByProcessID(Process_Of_Student.ID);
                //Lấy từng bảng điểm
                for (int i = 0; i < ListScoreBySubject.Count; i++)
                {
                    //lấy từng chi tiết bảng điểm.
                    {
                        List<DetailScore_DTO> ListDetail = DetailScore_BUL.LoadBySBSID(ListScoreBySubject[i].ID);
                        //Lấy từng loại kiểm tra.
                        List<TypeExam_DTO> typeExam_DTOs = TypeExam_BUL.Load();
                        //Lặp loại kiểm tra để tính điểm.
                        if (!Process_BUL.UpdateFinalScore(Calculate(ListDetail, typeExam_DTOs),Process_Of_Student.ID))
                        {
                            MessageBox.Show("Cập nhật điểm học kỳ thất bại!");
                        }
                    }
                }
            }
            else return;
        }
        private double Calculate(List<DetailScore_DTO> ListDetail, List<TypeExam_DTO> typeExam_DTOs)
        {
            double totalScore = 0, TotalIndex = 0;
            for (int i = 0; i < typeExam_DTOs.Count; i++)
            {
                int index = typeExam_DTOs[i].Index,count=0;
                double AveScore = 0;
                for (int j = 0; j < ListDetail.Count; j++)
                {
                    if (ListDetail[j].TypeExamID == typeExam_DTOs[i].ID)
                    {
                        AveScore += ListDetail[j].Score;
                        count++;
                    }
                }
                if (count == 0) count = 1;
                count = count * index;
                totalScore += AveScore*index;
                TotalIndex += count;
            }
            totalScore = Math.Round((double)totalScore / (double)TotalIndex,2,MidpointRounding.AwayFromZero);
            return totalScore;
        }
        private void BtnGuide_Click(object sender, EventArgs e)
        {
            Tutorial.Tutorial_AddScore tutorial_AddScore = new Tutorial.Tutorial_AddScore();
            tutorial_AddScore.ShowDialog();
            this.Refresh();
        }

        private void UpdateAllScoreBySubject(Process_DTO process_DTO)
        {
            //Load danh sách bảng điểm môn
            if (ScoreBySubject_BUL.LoadByProcessID(process_DTO.ID) == null) return;
            else
            {
                //Có danh sách. Load các chi tiết bảng điểm môn phù hợp với từng bảng điểm môn.
                List<ScoreBySubject_DTO> scoreBySubject_DTOs = ScoreBySubject_BUL.LoadByProcessID(process_DTO.ID);
                for (int i = 0; i < scoreBySubject_DTOs.Count; i++)
                {
                    //Nếu chi tiết bảng điểm môn không có. Bảng điểm môn này sẽ bằng 0.
                    if (DetailScore_BUL.LoadBySBSID(scoreBySubject_DTOs[i].ID) == null)
                    {
                        ScoreBySubject_BUL.UpdateScore(scoreBySubject_DTOs[i].ID, 0);
                    }
                    else
                    {
                        //Load được danh sách chi tiết bảng điểm tương ứng với bảng điểm môn.
                        List<DetailScore_DTO> detailScore_DTOs = DetailScore_BUL.LoadBySBSID(scoreBySubject_DTOs[i].ID);
                        //Load loại kiểm tra.
                        List<TypeExam_DTO> typeExam_DTOs = TypeExam_BUL.Load();
                        //Tính điểm trung bình theo loại kiểm tra và chi tiết bảng điểm môn
                        double score = Math.Round(Calculate(detailScore_DTOs, typeExam_DTOs),2,MidpointRounding.AwayFromZero);
                        ScoreBySubject_BUL.UpdateScore(scoreBySubject_DTOs[i].ID,score);
                    }
                }
            }
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
