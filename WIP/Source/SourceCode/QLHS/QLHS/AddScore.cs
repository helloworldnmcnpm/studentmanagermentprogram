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
            class_DTOs = Class_BUL.LoadBySC(Classtxt.SelectedValue.ToString());
            term_DTOs = Term_BUL.LoadBySC(Classtxt.SelectedValue.ToString());
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
            if (Termtxt.SelectedValue == null) return;

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}