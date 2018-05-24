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
using System.Globalization;

namespace QLHS
{
    public partial class AddScore : UserControl
    {
        /// <summary>
        /// INITIAL
        /// </summary>
        private static AddScore _instance;
        public static AddScore Instance
        {
            get
            {
                if (_instance == null) _instance = new AddScore();
                return _instance;
            }
        }
        private bool IsNumber(string UncheckString)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(UncheckString);
        }



        /// <summary>
        /// LOAD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        public AddScore()
        {
            InitializeComponent();
        }
        private void AddScore_Load(object sender, EventArgs e)
        {
            Scoretxt.Text = "";
            if (SchoolYear_BUL.Load()==null||Subject_BUL.Load()==null||TypeExam_BUL.Load()==null)
            {
                SCtxt.Enabled = false;
                Classtxt.Enabled = false;
                Termtxt.Enabled = false;
                dataGridView1.Enabled = false;
                dataGridView2.Enabled = false;
                Add.Enabled = false;
                buttonUpdate.Enabled = false;
                ButtonDelete.Enabled = false;
                Subjecttxt.Enabled = false;
                TypeExamtxt.Enabled = false;
            }
            else
            {
                SCtxt.Enabled = true;
                Classtxt.Enabled = true;
                Termtxt.Enabled = true;
                dataGridView1.Enabled = true;
                dataGridView2.Enabled = true;
                Add.Enabled = true;
                buttonUpdate.Enabled = true;
                ButtonDelete.Enabled = true;
                Subjecttxt.Enabled = true;
                TypeExamtxt.Enabled = true;
                SCtxt.DataSource = SchoolYear_BUL.Load();
                Subjecttxt.DataSource = Subject_BUL.Load();
                TypeExamtxt.DataSource = TypeExam_BUL.Load();
            }

        }




        /// <summary>
        /// BUTTON
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void Add_Click(object sender, EventArgs e)
        {
            //Initial
            Process_DTO process_DTO = Process_BUL.GetProcess(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), Termtxt.SelectedValue.ToString(), Classtxt.SelectedValue.ToString());
            if (ScoreBySubject_BUL.GetID(process_DTO.ID, Subjecttxt.SelectedValue.ToString()) == null)
            {
                MessageBox.Show("Học sinh này chưa thêm bảng điểm!", "Thông báo!");
                return;
            }
            string ScoreBySubjectID = ScoreBySubject_BUL.GetID(process_DTO.ID, Subjecttxt.SelectedValue.ToString());
            //Insert
            if (Scoretxt.Text == "")
            {
                return;
            }
            double a = Convert.ToDouble(Scoretxt.Text, new CultureInfo("en-US"));
            if (DetailScore_BUL.InsertScoreByStudent(ScoreBySubjectID, TypeExamtxt.SelectedValue.ToString(), a))
            {
                //Load datagridview
                dataGridView2.DataSource = DetailScore_BUL.LoadBySBSID(ScoreBySubjectID);
            }
            else
            {
                MessageBox.Show("Kiểm tra lại DataAccessLayer hoặc Database!", "Thông báo!");
            }
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            Process_DTO process_DTO = Process_BUL.GetProcess(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), Termtxt.SelectedValue.ToString(), Classtxt.SelectedValue.ToString());
            if (ScoreBySubject_BUL.GetID(process_DTO.ID, Subjecttxt.SelectedValue.ToString()) == null)
            {
                MessageBox.Show("Học sinh này chưa thêm bảng điểm!", "Thông báo!");
                return;
            }
            string ScoreBySubjectID = ScoreBySubject_BUL.GetID(process_DTO.ID, Subjecttxt.SelectedValue.ToString());
            if (dataGridView2.DataSource == null) return;
            if (DetailScore_BUL.DeleteScoreByStudent(int.Parse(dataGridView2.SelectedRows[0].Cells[3].Value.ToString())))
            {
                dataGridView2.DataSource = DetailScore_BUL.LoadBySBSID(ScoreBySubjectID);
            }
            else
            {
                MessageBox.Show("Kiểm tra lại DataAccessLayer hoặc Database!", "Thông báo!");
            }
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Process_DTO process_DTO = Process_BUL.GetProcess(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), Termtxt.SelectedValue.ToString(), Classtxt.SelectedValue.ToString());
            if (ScoreBySubject_BUL.GetID(process_DTO.ID, Subjecttxt.SelectedValue.ToString()) == null)
            {
                MessageBox.Show("Học sinh này chưa thêm bảng điểm!", "Thông báo!");
                return;
            }
            string ScoreBySubjectID = ScoreBySubject_BUL.GetID(process_DTO.ID, Subjecttxt.SelectedValue.ToString());
            if (Scoretxt.Text == "")
            {
                return;
            }
            double a = Convert.ToDouble(Scoretxt.Text, new CultureInfo("en-US"));
            if (dataGridView2.DataSource == null) return;
            if (DetailScore_BUL.UpdateScoreByStudent(int.Parse(dataGridView2.SelectedRows[0].Cells[3].Value.ToString()), a))
            {
                dataGridView2.DataSource = DetailScore_BUL.LoadBySBSID(ScoreBySubjectID);
            }
            else
            {
                MessageBox.Show("Kiểm tra lại DataAccessLayer hoặc Database!", "Thông báo!");
            }
        }
        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            AddScore_Load(sender, e);
        }




        /// <summary>
        /// EVENT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Classtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Process_BUL.LoadByClass(Classtxt.SelectedValue.ToString()) == null)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Enabled = false;
                Add.Enabled = false;
                buttonUpdate.Enabled = false;
                ButtonDelete.Enabled = false;
            }
            else
            {
                dataGridView1.Enabled = true;
                dataGridView1.DataSource = Process_BUL.LoadByClass(Classtxt.SelectedValue.ToString());
                Add.Enabled = true;
                buttonUpdate.Enabled = true;
                ButtonDelete.Enabled = true;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Scoretxt.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
        }
        private void Subjecttxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null) return;
            Process_DTO process_DTO = Process_BUL.GetProcess(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), Termtxt.SelectedValue.ToString(), Classtxt.SelectedValue.ToString());
            string ScoreBySubjectID = ScoreBySubject_BUL.GetID(process_DTO.ID, Subjecttxt.SelectedValue.ToString());
            dataGridView2.DataSource = DetailScore_BUL.LoadBySBSID(ScoreBySubjectID);
        }
        private void Scoretxt_TextChanged(object sender, EventArgs e)
        {
            label8.Visible = true;
            if (Scoretxt.Text=="")
            {
                label8.ForeColor = Color.Red;
                label8.Text = "Hãy nhập điểm!";
                Add.Enabled = false;
                buttonUpdate.Enabled = false;
            }
            else
            {
                if (!IsNumber(Scoretxt.Text))
                {
                    label8.ForeColor = Color.Red;
                    label8.Text = "Điểm phải là chữ số!";
                    Add.Enabled = false;
                    buttonUpdate.Enabled = false;
                }
                else
                {
                    if (double.Parse(Scoretxt.Text, CultureInfo.InvariantCulture.NumberFormat) < 0 || double.Parse(Scoretxt.Text, CultureInfo.InvariantCulture.NumberFormat) > 10)
                    {
                        label8.ForeColor = Color.Red;
                        label8.Text = "Điểm phải lớn hơn 0 và nhỏ hơn 10!";
                        Add.Enabled = false;
                        buttonUpdate.Enabled = false;
                    }
                    else
                    {
                        label8.ForeColor=Color.FromArgb(18, 148, 246);
                        label8.Text = "Nhập đúng!";
                        Add.Enabled = true;
                        buttonUpdate.Enabled = true;

                    }
                }
            }
        }
        private void SCtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Class_BUL.LoadBySC(SCtxt.SelectedValue.ToString()) == null||Term_BUL.LoadBySC(SCtxt.SelectedValue.ToString())==null)
            {
                dataGridView1.Enabled = false;
                dataGridView2.Enabled = false;
                Add.Enabled = false;
                buttonUpdate.Enabled = false;
                ButtonDelete.Enabled = false;
            }
            else
            {
                dataGridView1.Enabled = true;
                dataGridView2.Enabled = true;
                Add.Enabled = true;
                buttonUpdate.Enabled = true;
                ButtonDelete.Enabled = true;
                Classtxt.DataSource = Class_BUL.LoadBySC(SCtxt.SelectedValue.ToString());
                Termtxt.DataSource = Term_BUL.LoadBySC(SCtxt.SelectedValue.ToString());
            }
            
        }
        private void Termtxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}