using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) WindowState = FormWindowState.Maximized;
            else WindowState = FormWindowState.Normal;
        }



        private void BtnProfileManagement_Click(object sender, EventArgs e)
        {
            PanelProfileManagement.BringToFront();
        }

        private void BtnAddSubject_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnScoreManagement_Click(object sender, EventArgs e)
        {
            PanelScoreManagement.BringToFront();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            if (!Activities.Controls.Contains(AddStudent.Instance))
            {
                Activities.Controls.Add(AddStudent.Instance);
                AddStudent.Instance.Dock = DockStyle.Fill;
                AddStudent.Instance.BringToFront();
            }
            else AddStudent.Instance.BringToFront();
        }

        private void BtnChangeSchool_Click(object sender, EventArgs e)
        {
            if (!Activities.Controls.Contains(StudentChangeSchool.Instance))
            {
                Activities.Controls.Add(StudentChangeSchool.Instance);
                StudentChangeSchool.Instance.Dock = DockStyle.Fill;
                StudentChangeSchool.Instance.BringToFront();
            }
            else StudentChangeSchool.Instance.BringToFront();
        }
    }
}
