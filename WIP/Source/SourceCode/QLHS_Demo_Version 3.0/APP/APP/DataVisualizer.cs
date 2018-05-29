
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
        Class_Dashboard class_Dashboard;
        private void DataVisualizer_Load(object sender, EventArgs e)
        {
            labelNumberOfStudent.Text = Student_BUL.CountStudent().ToString();
            if (SchoolYear_BUL.Load()==null)
            {
                comboBox2.DataSource = null;
                comboBox1.Enabled = comboBox2.Enabled = false;
                BtnClass.Enabled = BtnStudent.Enabled = BtnEx.Enabled = BtnIme.Enabled = BtnNormal.Enabled = BtnWeak.Enabled = BtnRe.Enabled = BtnPassed.Enabled = false;
            }
            else
            {
                comboBox1.Enabled = comboBox2.Enabled = true;
                BtnClass.Enabled = BtnStudent.Enabled = BtnEx.Enabled = BtnIme.Enabled = BtnNormal.Enabled = BtnWeak.Enabled = BtnRe.Enabled = BtnPassed.Enabled = true;

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
            class_Dashboard = new Class_Dashboard();
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
                BtnClass.Enabled = BtnStudent.Enabled = BtnEx.Enabled = BtnIme.Enabled = BtnNormal.Enabled = BtnWeak.Enabled = BtnRe.Enabled = BtnPassed.Enabled = false;
            }
            else
            {
                comboBox2.Enabled = true;
                BtnClass.Enabled = BtnStudent.Enabled = BtnEx.Enabled = BtnIme.Enabled = BtnNormal.Enabled = BtnWeak.Enabled = BtnRe.Enabled = BtnPassed.Enabled = true;
                comboBox2.ValueMember = "ID";
                comboBox2.DisplayMember = "Name";
                comboBox2.DataSource = Term_BUL.LoadBySC(comboBox1.SelectedValue.ToString());
            }
            LabelNumberOfClass.Text = Class_BUL.CountBySC(comboBox1.SelectedValue.ToString()).ToString();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
