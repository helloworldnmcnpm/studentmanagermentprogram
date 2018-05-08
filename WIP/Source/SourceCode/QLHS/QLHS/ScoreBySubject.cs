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
    public partial class ScoreBySubject : UserControl
    {
        private static ScoreBySubject _instance;
        public static ScoreBySubject Instance
        {
            get
            {
                if (_instance == null) _instance = new ScoreBySubject();
                return _instance;
            }
        }
        public ScoreBySubject()
        {
            InitializeComponent();
        }
        List<Class_DTO> class_DTOs = new List<Class_DTO>();
        List<SchoolYear_DTO> schoolYear_DTOs = new List<SchoolYear_DTO>();
        List<Student_DTO> student_DTOs = new List<Student_DTO>();
        List<Subject_DTO> subject_DTOs = new List<Subject_DTO>();
        List<Term_DTO> term_DTOs = new List<Term_DTO>();
        private void LoadList()
        {
            subject_DTOs = Subject_BUL.Load();
            class_DTOs = Class_BUL.Load();
            schoolYear_DTOs = SchoolYear_BUL.Load();
            Classtxt.DataSource = class_DTOs;
            SCtxt.DataSource = schoolYear_DTOs;
            Subjecttxt.DataSource = subject_DTOs;
            
        }
        private void SCtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            class_DTOs = Class_BUL.LoadBySC(SCtxt.SelectedValue.ToString());
            Classtxt.DataSource = class_DTOs;
            term_DTOs = Term_BUL.LoadBySC(SCtxt.SelectedValue.ToString());
            Termtxt.DataSource = term_DTOs;
        }

        private void Classtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            student_DTOs = Process_BUL.LoadByClass(Classtxt.SelectedValue.ToString());
            dataGridView1.DataSource = student_DTOs;
        }

        private void ScoreBySubject_Load(object sender, EventArgs e)
        {
            LoadList();
            
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            ScoreBySubject_Load(sender, e);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Subjecttxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Process_BUL.LoadByClass(Classtxt.SelectedValue.ToString()) == null) return;
            if (Process_BUL.GetProcess(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), Termtxt.SelectedValue.ToString(), Classtxt.SelectedValue.ToString()) == null) return;
                dataGridView2.DataSource = ScoreBySubject_BUL.LoadByProcessID(Process_BUL.GetProcess(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), Termtxt.SelectedValue.ToString(), Classtxt.SelectedValue.ToString()).ID);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ScoreBySubject_BUL.LoadByProcessID(Process_BUL.GetProcess(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), Termtxt.SelectedValue.ToString(), Classtxt.SelectedValue.ToString()).ID) == null) return;

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (SBStxt.Text == "" || Subject_BUL.Load()==null||Term_BUL.Load()==null) return;
            if (Process_BUL.LoadByClass(Classtxt.SelectedValue.ToString()) == null) return;
            ScoreBySubject_DTO scoreBySubject_DTO = new ScoreBySubject_DTO();
            scoreBySubject_DTO.ID = SBStxt.Text;
            scoreBySubject_DTO.SubjectID = Subjecttxt.SelectedValue.ToString();
            if (Process_BUL.GetProcess(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), Termtxt.SelectedValue.ToString(), Classtxt.SelectedValue.ToString()) == null) {
                MessageBox.Show("Chưa bắt đầu học kỳ mới!", "Thêm thất bại!");
                return; }
            scoreBySubject_DTO.ProcessID = Process_BUL.GetProcess(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), Termtxt.SelectedValue.ToString(), Classtxt.SelectedValue.ToString()).ID;
            scoreBySubject_DTO.FinalScore = 0;
            if (ScoreBySubject_BUL.Insert(scoreBySubject_DTO))
            {
                dataGridView2.DataSource = ScoreBySubject_BUL.LoadByProcessID(scoreBySubject_DTO.ProcessID);
            }
            else MessageBox.Show("Thêm vào database thất bại!", "Thất bại!");
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (Process_BUL.LoadByClass(Classtxt.SelectedValue.ToString()) == null) return;
            if (ScoreBySubject_BUL.LoadByProcessID(Process_BUL.GetProcess(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), Termtxt.SelectedValue.ToString(), Classtxt.SelectedValue.ToString()).ID) == null) return;
            if (ScoreBySubject_BUL.Delete(dataGridView2.SelectedRows[0].Cells[0].Value.ToString()))
            {
                dataGridView2.DataSource = ScoreBySubject_BUL.LoadByProcessID(Process_BUL.GetProcess(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), Termtxt.SelectedValue.ToString(), Classtxt.SelectedValue.ToString()).ID);

            }
            else MessageBox.Show("Xóa thất bại, kiểm tra lại database!", "Thất bại");
        }
    }
}
