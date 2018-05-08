using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
using DTO;
using System.Text.RegularExpressions;

namespace QLHS
{
    public partial class AddScore : UserControl
    {
        private static AddScore _instance;
        public static AddScore Instance
        {
            get
            {
                if (_instance == null) _instance = new AddScore();
                return _instance;
            }
        }
        public AddScore()
        {
            InitializeComponent();
        }
        List<SchoolYear_DTO> schoolYear_DTOs = new List<SchoolYear_DTO>();
        List<Class_DTO> class_DTOs = new List<Class_DTO>();
        List<Term_DTO> term_DTOs = new List<Term_DTO>();
        List<Subject_DTO> subject_DTOs = new List<Subject_DTO>();
        List<Student_DTO> student_DTOs = new List<Student_DTO>();
        List<TypeExam_DTO> typeExam_DTOs = new List<TypeExam_DTO>();
        private void LoadSchoolYear_SubjectComboBox()
        {
            schoolYear_DTOs = SchoolYear_BUL.Load();
            SCtxt.DataSource = schoolYear_DTOs;
            Classtxt.DataSource = class_DTOs;
            subject_DTOs = Subject_BUL.Load();
            Subjecttxt.DataSource = subject_DTOs;
            typeExam_DTOs = TypeExam_BUL.Load();
            TypeExamtxt.DataSource = typeExam_DTOs;
        }
        
        private void AddScore_Load(object sender, EventArgs e)
        {
            LoadSchoolYear_SubjectComboBox();
            
            
        }

        private void SCtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Class_BUL.Load() == null) return;
            class_DTOs = Class_BUL.LoadBySC(SCtxt.SelectedValue.ToString());
            term_DTOs = Term_BUL.LoadBySC(SCtxt.SelectedValue.ToString());
            Termtxt.DataSource = term_DTOs;
            Classtxt.DataSource = class_DTOs;
        }

        private void Termtxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Classtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            student_DTOs = Process_BUL.LoadByClass(Classtxt.SelectedValue.ToString());
            dataGridView1.DataSource = student_DTOs;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Process_BUL.LoadByClass(Classtxt.SelectedValue.ToString()) == null) return;
            if (Termtxt == null || Subjecttxt == null || TypeExamtxt == null) return;
            Process_DTO process_DTO = Process_BUL.GetProcess(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), Termtxt.SelectedValue.ToString(), Classtxt.SelectedValue.ToString());
            string ScoreBySubjectID = ScoreBySubject_BUL.GetID(process_DTO.ID, Subjecttxt.SelectedValue.ToString());
            dataGridView2.DataSource = DetailScore_BUL.LoadBySBSID(ScoreBySubjectID);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Process_BUL.LoadByClass(Classtxt.SelectedValue.ToString()) == null) return;
            if (Termtxt == null || Subjecttxt == null || TypeExamtxt == null) return;
            Process_DTO process_DTO = Process_BUL.GetProcess(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), Termtxt.SelectedValue.ToString(), Classtxt.SelectedValue.ToString());
            string ScoreBySubjectID = ScoreBySubject_BUL.GetID(process_DTO.ID, Subjecttxt.SelectedValue.ToString());
            if (DetailScore_BUL.LoadBySBSID(ScoreBySubjectID) == null) return;
            TypeExamtxt.SelectedValue = dataGridView2.SelectedRows[0].Cells[0].Value;
            Scoretxt.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
        }
        private bool IsNumber(string UncheckString)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(UncheckString);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (Process_BUL.LoadByClass(Classtxt.SelectedValue.ToString()) == null) return;
            if (Termtxt == null || Subjecttxt == null || TypeExamtxt == null) return;
            if (!IsNumber(Scoretxt.Text) || Convert.ToSingle(Scoretxt.Text) < 0 || Convert.ToSingle(Scoretxt.Text) > 10)
            {
                MessageBox.Show("Nhập điểm sai, vui lòng nhập lại!", "Nhập sai!");
                return;
            }
            Process_DTO process_DTO = Process_BUL.GetProcess(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), Termtxt.SelectedValue.ToString(), Classtxt.SelectedValue.ToString());
            string ScoreBySubjectID = ScoreBySubject_BUL.GetID(process_DTO.ID, Subjecttxt.SelectedValue.ToString());
            if (DetailScore_BUL.InsertScoreByStudent(ScoreBySubjectID, TypeExamtxt.SelectedValue.ToString(), Convert.ToSingle(Scoretxt.Text)))
            {
                MessageBox.Show("Đã thêm điểm!", "Thành công");
                dataGridView2.DataSource = DetailScore_BUL.LoadBySBSID(ScoreBySubjectID);
            }
            else MessageBox.Show("Thêm thất bại.", "Thất bại");
        }

        private void Subjecttxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Process_BUL.LoadByClass(Classtxt.SelectedValue.ToString()) == null) return;
            if (Termtxt == null || Subjecttxt == null || TypeExamtxt == null) return;
            Process_DTO process_DTO = Process_BUL.GetProcess(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), Termtxt.SelectedValue.ToString(), Classtxt.SelectedValue.ToString());
            string ScoreBySubjectID = ScoreBySubject_BUL.GetID(process_DTO.ID, Subjecttxt.SelectedValue.ToString());
            if (ScoreBySubjectID == null) return;
            dataGridView2.DataSource = DetailScore_BUL.LoadBySBSID(ScoreBySubjectID);
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (Process_BUL.LoadByClass(Classtxt.SelectedValue.ToString()) == null) return;
            if (Termtxt == null || Subjecttxt == null || TypeExamtxt == null) return;
            Process_DTO process_DTO = Process_BUL.GetProcess(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), Termtxt.SelectedValue.ToString(), Classtxt.SelectedValue.ToString());
            string ScoreBySubjectID = ScoreBySubject_BUL.GetID(process_DTO.ID, Subjecttxt.SelectedValue.ToString());
            if (DetailScore_BUL.LoadBySBSID(ScoreBySubjectID) == null) return;
            if (ScoreBySubjectID == null) return;
            if (DetailScore_BUL.DeleteScoreByStudent(Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["iDDataGridViewTextBoxColumn1"].Value.ToString())))
            {
                dataGridView2.DataSource= DetailScore_BUL.LoadBySBSID(ScoreBySubjectID);
            }
            else
            {
                MessageBox.Show("Không thể xóa.", "Thất bại");
            }
        }
    }
}