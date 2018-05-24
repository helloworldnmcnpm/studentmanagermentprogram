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

        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
           
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
          
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
       }
        private void Subjecttxt_SelectedIndexChanged(object sender, EventArgs e)
        {
          }
        private void Scoretxt_TextChanged(object sender, EventArgs e)
        {
            label8.Visible = true;
            if (Scoretxt.Text=="")
            {
                label8.ForeColor = Color.Red;
                label8.Text = "Hãy nhập điểm!";
            }
            else
            {
                if (!IsNumber(Scoretxt.Text))
                {
                    label8.ForeColor = Color.Red;
                    label8.Text = "Điểm phải là chữ số!";
                }
                else
                {
                    if (float.Parse(Scoretxt.Text, CultureInfo.InvariantCulture.NumberFormat) < 0 || float.Parse(Scoretxt.Text, CultureInfo.InvariantCulture.NumberFormat) > 10)
                    {
                        label8.ForeColor = Color.Red;
                        label8.Text = "Điểm phải lớn hơn 0 và nhỏ hơn 10!";
                    }
                    else
                    {
                        label8.ForeColor=Color.FromArgb(18, 148, 246);
                        label8.Text = "Nhập đúng!";
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