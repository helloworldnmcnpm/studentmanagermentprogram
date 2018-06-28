
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
using DTO;
using CID;

namespace APP
{

    public partial class DataVisualizer : MetroFramework.Forms.MetroForm
    {
        Correct_Input_Data cid = new Correct_Input_Data();
        public DataVisualizer()
        {
            InitializeComponent();
        }
        ClassDashBoard class_Dashboard;
        private void DataVisualizer_Load(object sender, EventArgs e)
        {
            labelNumberOfStudent.Text = Student_BUL.CountStudent().ToString();
            if (SchoolYear_BUL.Load()==null)
            {
                comboBox2.DataSource = null;
                comboBox1.Enabled = comboBox2.Enabled = false;
                BtnClass.Enabled = BtnStudent.Enabled = BtnEx.Enabled = BtnIme.Enabled = metroButton1.Enabled=metroButton2.Enabled= false;
            }
            else
            {
                comboBox1.Enabled = comboBox2.Enabled = true;
                BtnClass.Enabled = BtnStudent.Enabled = BtnEx.Enabled = BtnIme.Enabled = metroButton1.Enabled = metroButton2.Enabled  = true;

                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "ID";
                comboBox1.DataSource = SchoolYear_BUL.Load();
            }

            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SearchStudent_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible) pictureBox1.Visible = false;
            else
            {
                pictureBox1.Visible = true;
            }
        }

        private void SearchStudent_TextChanged(object sender, EventArgs e)
        {
            if (SearchStudent.Text == "") pictureBox1.Visible = true;
            else
            {
                pictureBox1.Visible = false;
                cid.InputString = SearchStudent.Text;
                SearchStudent.Text = cid.NoSecialKey;
                SearchStudent.SelectionStart = SearchStudent.Text.Length;
            }
        }

        private void Activities_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnClass_Click(object sender, EventArgs e)
        {
            class_Dashboard = new ClassDashBoard();
            class_Dashboard.SchoolYearID = comboBox1.SelectedValue.ToString();
            class_Dashboard.TermID = comboBox2.SelectedValue.ToString();
            if (SearchStudent.Text == ""||SearchStudent.Text==null)
            {
                class_Dashboard.IsSearch = false;
                class_Dashboard.ShowDialog();
            }else
            {
                class_Dashboard.IsSearch = true;
                class_Dashboard.ShowDialog();
            }
        }

        private void BtnStudent_Click(object sender, EventArgs e)
        { 
            StudentDashboard.Student_Dashboard student_Dashboard = new StudentDashboard.Student_Dashboard();
            student_Dashboard.SchoolYearID = comboBox1.SelectedValue.ToString();
            student_Dashboard.TermID = comboBox2.SelectedValue.ToString();
            if (SearchStudent.Text == "" || SearchStudent.Text == null)
            {
                student_Dashboard.IsSearch = false;
                student_Dashboard.ShowDialog();
            }
            else
            {
                student_Dashboard.IsSearch = true;
                student_Dashboard.ShowDialog();
            }
        }

        private void SearchStudent_Leave(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Term_BUL.LoadBySC(comboBox1.SelectedValue.ToString()) == null)
            {
                comboBox2.DataSource = null;
                comboBox2.Enabled = false;
                BtnClass.Enabled = BtnStudent.Enabled = BtnEx.Enabled = BtnIme.Enabled = metroButton1.Enabled = metroButton2.Enabled = false;
            }
            else
            {
                comboBox2.Enabled = true;
                BtnClass.Enabled = BtnStudent.Enabled = BtnEx.Enabled = BtnIme.Enabled = metroButton1.Enabled = metroButton2.Enabled = true;
                comboBox2.ValueMember = "ID";
                comboBox2.DisplayMember = "Name";
                comboBox2.DataSource = Term_BUL.LoadBySC(comboBox1.SelectedValue.ToString());
            }
            LabelNumberOfClass.Text = Class_BUL.CountBySC(comboBox1.SelectedValue.ToString()).ToString();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void BtnEx_Click(object sender, EventArgs e)
        {
            ExcellentStudent.Excellent_Student excellent_Student = new ExcellentStudent.Excellent_Student();
            excellent_Student.SchoolYearID= comboBox1.SelectedValue.ToString();
            excellent_Student.TermID= comboBox2.SelectedValue.ToString();
            excellent_Student.percent = percent;
            if (SearchStudent.Text == "" || SearchStudent.Text == null)
            {
                excellent_Student.IsSearch = false;
                excellent_Student.ShowDialog();
            }
            else
            {
                excellent_Student.IsSearch = true;
                excellent_Student.ShowDialog();
            }
        }
        double percent;
        double percent2;
        double percent3;
        double percent4;
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Process_DTO> process_DTOs = new List<Process_DTO>();
            process_DTOs = Process_BUL.ListStudentByTerm(comboBox2.SelectedValue.ToString());
            List<Process_DTO> ExcellentStudent = new List<Process_DTO>();
            if (process_DTOs != null)
            {
                for (int i = 0; i < process_DTOs.Count; i++)
                {
                    if (process_DTOs[i].TotalScore >= 8) ExcellentStudent.Add(process_DTOs[i]);
                }
                percent = ((double)ExcellentStudent.Count / (double)process_DTOs.Count) * 100;
                percent = Math.Round(percent, 2, MidpointRounding.AwayFromZero);
                labelPercentEx.Text = ExcellentStudent.Count + "-" + percent + ("%");

                List<Process_DTO> ImeStudent = new List<Process_DTO>();
                for (int i = 0; i < process_DTOs.Count; i++)
                {
                    if (process_DTOs[i].TotalScore >= 6.5 && process_DTOs[i].TotalScore < 8) ImeStudent.Add(process_DTOs[i]);
                }
                percent2 = ((double)ImeStudent.Count / (double)process_DTOs.Count) * 100;
                percent2 = Math.Round(percent2, 2, MidpointRounding.AwayFromZero);
                labelPercentIme.Text = ImeStudent.Count + "-" + percent2 + ("%");

                List<Process_DTO> NormalStudent = new List<Process_DTO>();
                for (int i = 0; i < process_DTOs.Count; i++)
                {
                    if (process_DTOs[i].TotalScore >= 5 && process_DTOs[i].TotalScore < 6.5) NormalStudent.Add(process_DTOs[i]);
                }
                percent3 = ((double)NormalStudent.Count / (double)process_DTOs.Count) * 100;
                percent3 = Math.Round(percent3, 2, MidpointRounding.AwayFromZero);
                LabelNor.Text = NormalStudent.Count + "-" + percent3 + ("%");
                List<Process_DTO> WeakStudent = new List<Process_DTO>();
                for (int i = 0; i < process_DTOs.Count; i++)
                {
                    if (process_DTOs[i].TotalScore < 5) WeakStudent.Add(process_DTOs[i]);
                }
                percent4 = ((double)WeakStudent.Count / (double)process_DTOs.Count) * 100;
                percent4 = Math.Round(percent4, 2, MidpointRounding.AwayFromZero);
                LabelWeak.Text = WeakStudent.Count + "-" + percent4 + ("%");

                label5.Text = Convert.ToInt32(labelNumberOfStudent.Text) - WeakStudent.Count + "-" +
                    Math.Round((double)(Convert.ToInt32(labelNumberOfStudent.Text) - WeakStudent.Count) / (double)Convert.ToInt32(labelNumberOfStudent.Text), 2, MidpointRounding.AwayFromZero) * 100 + "%";
            }
        }

        private void BtnIme_Click(object sender, EventArgs e)
        {
            ImediateStudent.Imediate_Student imediate_Student = new ImediateStudent.Imediate_Student();
            imediate_Student.SchoolYearID= comboBox1.SelectedValue.ToString();
            imediate_Student.TermID= comboBox2.SelectedValue.ToString();
            imediate_Student.percent = percent2;
            if (SearchStudent.Text == "" || SearchStudent.Text == null)
            {
                imediate_Student.IsSearch = false;
                imediate_Student.ShowDialog();
            }
            else
            {
                imediate_Student.IsSearch = true;
                imediate_Student.ShowDialog();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            NormalStudent.Normal_Student normal_Student = new NormalStudent.Normal_Student();
            normal_Student.SchoolYearID = comboBox1.SelectedValue.ToString();
            normal_Student.TermID = comboBox2.SelectedValue.ToString();
            normal_Student.percent = percent3;
            if (SearchStudent.Text == "" || SearchStudent.Text == null)
            {
                normal_Student.IsSearch = false;
                normal_Student.ShowDialog();
            }
            else
            {
                normal_Student.IsSearch = true;
                normal_Student.ShowDialog();
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            WeakStudent.Weak_Student weak_Student = new WeakStudent.Weak_Student();
            weak_Student.SchoolYearID = comboBox1.SelectedValue.ToString();
            weak_Student.TermID = comboBox2.SelectedValue.ToString();
            weak_Student.percent = percent4;
            if (SearchStudent.Text == "" || SearchStudent.Text == null)
            {
                weak_Student.IsSearch = false;
                weak_Student.ShowDialog();
            }
            else
            {
                weak_Student.IsSearch = true;
                weak_Student.ShowDialog();
            }
        }

        private void BtnDashBoard_Click(object sender, EventArgs e)
        {
            DataVisualizer dataVisualizer = new DataVisualizer();
            this.Hide();
            dataVisualizer.ShowDialog();
            this.Close();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Search.SearchForm searchForm = new Search.SearchForm();
            searchForm.NameLike = SearchStudent.Text;
            searchForm.ShowDialog();
        }
    }
}
