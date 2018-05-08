using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PanelRight.Size = new System.Drawing.Size(0, 0);
            PanelSetting.Size = new System.Drawing.Size(0, 0);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PanelRight.BringToFront();
            if (PanelRight.Width == 264)
            {
                PanelRight.Size = new System.Drawing.Size(0, 0);
                if (PanelSetting.Width == 359) PanelSetting.Size = new System.Drawing.Size(0, 0);
            }
            else PanelRight.Size = new System.Drawing.Size(264, 739);
        }

        private void buttonNewSchoolYear_Click(object sender, EventArgs e)
        {
            if (!Activities.Controls.Contains(SchoolYear.Instance))
            {
                Activities.Controls.Add(SchoolYear.Instance);
                SchoolYear.Instance.Dock = DockStyle.Fill;
                SchoolYear.Instance.BringToFront();
            }
            else SchoolYear.Instance.BringToFront();
        }

        private void buttonRules_Click(object sender, EventArgs e)
        {
            if (!Activities.Controls.Contains(Rule.Instance))
            {
                Activities.Controls.Add(Rule.Instance);
                Rule.Instance.Dock = DockStyle.Fill;
                Rule.Instance.BringToFront();
            }
            else Rule.Instance.BringToFront();
        }

        private void buttonGrade_Click(object sender, EventArgs e)
        {
            if (!Activities.Controls.Contains(Grade.Instance))
            {
                Activities.Controls.Add(Grade.Instance);
                Grade.Instance.Dock = DockStyle.Fill;
                Grade.Instance.BringToFront();
            }
            else Grade.Instance.BringToFront();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            if (!Activities.Controls.Contains(Class.Instance))
            {
                Activities.Controls.Add(Class.Instance);
                Class.Instance.Dock = DockStyle.Fill;
                Class.Instance.BringToFront();
            }
            else Class.Instance.BringToFront();

        }

        private void buttonStudent_Click(object sender, EventArgs e)
        {
            if (!Activities.Controls.Contains(Student.Instance))
            {
                Activities.Controls.Add(Student.Instance);
                Student.Instance.Dock = DockStyle.Fill;
                Student.Instance.BringToFront();
            }
            else Student.Instance.BringToFront();
        }

        private void buttonTerm_Click(object sender, EventArgs e)
        {
            if (!Activities.Controls.Contains(Term.Instance))
            {
                Activities.Controls.Add(Term.Instance);
                Term.Instance.Dock = DockStyle.Fill;
                Term.Instance.BringToFront();
            }
            else Term.Instance.BringToFront();
        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
            InfoLogin infoLogin = new InfoLogin();
            infoLogin.ShowDialog();
            infoLogin.BringToFront();
        }

        private void buttonTypeExam_Click(object sender, EventArgs e)
        {
            if (!Activities.Controls.Contains(TypeExam.Instance))
            {
                Activities.Controls.Add(TypeExam.Instance);
                TypeExam.Instance.Dock = DockStyle.Fill;
                TypeExam.Instance.BringToFront();
            }
            else TypeExam.Instance.BringToFront();
        }

        private void buttonSubject_Click(object sender, EventArgs e)
        {
            if (!Activities.Controls.Contains(Subject.Instance))
            {
                Activities.Controls.Add(Subject.Instance);
                Subject.Instance.Dock = DockStyle.Fill;
                Subject.Instance.BringToFront();
            }
            else Subject.Instance.BringToFront();
        }

        private void buttonMark_Click(object sender, EventArgs e)
        {
            if (!Activities.Controls.Contains(Mark.Instance))
            {
                Activities.Controls.Add(Mark.Instance);
                Mark.Instance.Dock = DockStyle.Fill;
                Mark.Instance.BringToFront();
            }
            else Mark.Instance.BringToFront();
        }

        private void SelectColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            SelectColor.BackColor = colorDialog1.Color;
            panel2.BackColor = colorDialog1.Color;
            panel4.BackColor = colorDialog1.Color;
            panel5.BackColor = colorDialog1.Color;
            panel7.BackColor = colorDialog1.Color;
            panel8.BackColor = colorDialog1.Color;
            panel9.BackColor = colorDialog1.Color;
            panel10.BackColor = colorDialog1.Color;
            panel1.BackColor = colorDialog1.Color;
            panel6.BackColor = colorDialog1.Color;
            panel3.BackColor = colorDialog1.Color;
        }

        private void Default_Click(object sender, EventArgs e)
        {
            SelectColor.BackColor = Color.FromArgb(18, 148, 246);
            panel2.BackColor = Color.FromArgb(18, 148, 246);
            panel4.BackColor = Color.FromArgb(18, 148, 246);
            panel5.BackColor = Color.FromArgb(18, 148, 246);
            panel7.BackColor = Color.FromArgb(18, 148, 246);
            panel8.BackColor = Color.FromArgb(18, 148, 246);
            panel9.BackColor = Color.FromArgb(18, 148, 246);
            panel10.BackColor = Color.FromArgb(18, 148, 246);
            panel1.BackColor = Color.FromArgb(18, 148, 246);
            panel6.BackColor = Color.FromArgb(18, 148, 246);
            panel3.BackColor = Color.FromArgb(18, 148, 246);
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            PanelSetting.BringToFront();
            if (PanelSetting.Width == 359) PanelSetting.Size = new System.Drawing.Size(0, 0);
            else PanelSetting.Size = new System.Drawing.Size(359, 740);
        }
        
    }
}
