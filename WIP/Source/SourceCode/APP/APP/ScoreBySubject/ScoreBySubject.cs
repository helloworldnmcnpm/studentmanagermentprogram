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
namespace APP.ScoreBySubject
{
    public partial class ScoreBySubject : MetroFramework.Forms.MetroForm
    {
        private DataTable dt = new DataTable();
        private List<TypeExam_DTO> typeExam_DTOs = TypeExam_BUL.Load();
        private List<Process_DTO> ListProcess;
        private void CreateScoreTable()
        {
            dt.Columns.Add(new DataColumn("Mã học sinh", typeof(Int32)));
            dt.Columns.Add(new DataColumn("Tên học sinh", typeof(string)));
            if (typeExam_DTOs == null) return;
            typeExam_DTOs.Sort(delegate (TypeExam_DTO te1, TypeExam_DTO te2)
            {
                return te1.Index.CompareTo(te2.Index);
            });
            for (int i = 0; i < typeExam_DTOs.Count; i++)
            {
                dt.Columns.Add(new DataColumn(typeExam_DTOs[i].Name, typeof(string)));
            }
            dt.Columns.Add(new DataColumn("Điểm trung bình", typeof(string)));
            metroGrid.DataSource = dt;
        }
        public ScoreBySubject()
        {
            InitializeComponent();
        }
        private void ScoreBySubject_Load(object sender, EventArgs e)
        {
            if (SchoolYear_BUL.Load() == null)
            {
                metroGrid.Enabled = TermCombo.Enabled = ClassCombo.Enabled = false;
                comboBox1.DataSource = null;
            }
            else
            {
                metroGrid.Enabled = TermCombo.Enabled = ClassCombo.Enabled = true;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "ID";
                comboBox1.DataSource = SchoolYear_BUL.Load();
            }
            CreateScoreTable();
            if (Subject_BUL.Load()==null)
            {
                SubjectCombo.DataSource = null;
                metroGrid.Enabled = SubjectCombo.Enabled = false;
            }
            else
            {
                metroGrid.Enabled= SubjectCombo.Enabled = true;
                SubjectCombo.DisplayMember = "Name";
                SubjectCombo.ValueMember = "ID";
                SubjectCombo.DataSource = Subject_BUL.Load();
            }
           
        }

        private void TermCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TermCombo.DataSource != null)
                if (Process_BUL.ListStudentByTerm(TermCombo.SelectedValue.ToString()) != null)
                    ListProcess = Process_BUL.ListStudentByTerm(TermCombo.SelectedValue.ToString());
                else return;
            else return;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Term_BUL.LoadBySC(comboBox1.SelectedValue.ToString()) != null||Class_BUL.LoadBySC(comboBox1.SelectedValue.ToString())!=null)
            {
                metroGrid.Enabled = TermCombo.Enabled = ClassCombo.Enabled = true;
                TermCombo.DisplayMember = "Name";
                TermCombo.ValueMember = "ID";
                TermCombo.DataSource = Term_BUL.LoadBySC(comboBox1.SelectedValue.ToString());
                ClassCombo.DisplayMember = "Name";
                ClassCombo.ValueMember = "ID";
                ClassCombo.DataSource = Class_BUL.LoadBySC(comboBox1.SelectedValue.ToString());
            }
            else
            {
                metroGrid.Enabled = TermCombo.Enabled = ClassCombo.Enabled = false;
                TermCombo.DataSource = null;
                ClassCombo.DataSource = null;
                return;
            }
        }

        private void SubjectCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Process_DTO> ListProcessByClass = new List<Process_DTO>();
            dt.Rows.Clear();
            for (int i = 0; i < ListProcess.Count; i++)
            {
                if (ListProcess[i].ClassID == ClassCombo.SelectedValue.ToString()) ListProcessByClass.Add(ListProcess[i]);
            }
            if (ListProcessByClass == null) return;
            Student_DTO student_DTO;
            if (Subject_BUL.Load() == null) return;
            for (int i = 0; i < ListProcessByClass.Count; i++)
            {
                student_DTO = new Student_DTO();
                student_DTO = Student_BUL.LoadAStudent(ListProcessByClass[i].StudentID);
                DataRow dr = dt.NewRow();
                dr["Mã học sinh"] = student_DTO.ID;
                dr["Tên học sinh"] = student_DTO.Name;
                if (ScoreBySubject_BUL.LoadByProcessID(ListProcessByClass[i].ID) != null)
                {
                    List<ScoreBySubject_DTO> scoreBySubject_DTOs = ScoreBySubject_BUL.LoadByProcessID(ListProcessByClass[i].ID);
                    ScoreBySubject_DTO scoreBySubject_DTO = new ScoreBySubject_DTO();
                    for (int j = 0; j < scoreBySubject_DTOs.Count; j++) { if (scoreBySubject_DTOs[j].SubjectID == SubjectCombo.SelectedValue.ToString()) {
                            dr["Điểm trung bình"] =Math.Round(scoreBySubject_DTOs[j].FinalScore,2,MidpointRounding.AwayFromZero);
                            scoreBySubject_DTO = scoreBySubject_DTOs[j];
                            break;
                        } }
                    List<DetailScore_DTO> detailScore_DTOs = DetailScore_BUL.LoadBySBSID(scoreBySubject_DTO.ID);
                    for (int j = 0; j < detailScore_DTOs.Count; j++)
                    {
                        for (int k = 0; k < metroGrid.ColumnCount; k++)
                        {
                            if (TypeExam_BUL.GetName(detailScore_DTOs[j].TypeExamID) == metroGrid.Columns[k].Name)
                            {
                                dr[k] = dr[k] + detailScore_DTOs[j].Score.ToString() + " ";
                            }
                        }
                    }
                }
                dt.Rows.Add(dr);
                dt.AcceptChanges();
            }
            metroGrid.DataSource = dt;
        }
    }
}
