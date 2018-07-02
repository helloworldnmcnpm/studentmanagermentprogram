using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
namespace APP
{
    public partial class Main : MaterialSkin.Controls.MaterialForm
    {
        /// <summary>
        /// INITIAL
        /// </summary>
        public Main()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        AddSchoolYear addSchoolYear;
        ConfigRule configRule;
        AddTerm addTerm;
        AddGrade addGrade;
        AddClass addClass;
        AddStudent addStudent;
        Subject subject;
        InsertStudentToAClass insertStudentToAClass;
        SwitchClass switchClass;
        Settings settings;
        AddScoreBySubject addScoreBySubject;
        AddTypeExam addTypeExam;
        AddScore addScore;
        UpClass upClass;
        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void SchoolYear_Click(object sender, EventArgs e)
        {
            if (!Activities.Controls.Contains(addSchoolYear))
            {
                addSchoolYear = new AddSchoolYear();
                addSchoolYear.TopLevel = false;
                Activities.Controls.Add(addSchoolYear);
                addSchoolYear.Show();
                addSchoolYear.BringToFront();
            }
            else
            {
                addSchoolYear.Show();
                addSchoolYear.BringToFront();
            }
        }

        private void Rule_Click(object sender, EventArgs e)
        {
            if (!Activities.Controls.Contains(configRule))
            {
                configRule = new ConfigRule();
                configRule.TopLevel = false;
                Activities.Controls.Add(configRule);
                configRule.Show();
                configRule.BringToFront();
            }
            else
            {
                configRule.Show();
                configRule.BringToFront();
            }
        }

        private void Term_Click(object sender, EventArgs e)
        {
            if (!Activities.Controls.Contains(addTerm))
            {
                addTerm = new AddTerm();
                addTerm.TopLevel = false;
                Activities.Controls.Add(addTerm);
                addTerm.Show();
                addTerm.BringToFront();
            }
            else
            {
                addTerm.Show();
                addTerm.BringToFront();
            }
        }

        private void Grade_Click(object sender, EventArgs e)
        {
            if (!Activities.Controls.Contains(addGrade))
            {
                addGrade = new AddGrade();
                addGrade.TopLevel = false;
                Activities.Controls.Add(addGrade);
                addGrade.Show();
                addGrade.BringToFront();
            }
            else
            {
                addGrade.Show();
                addGrade.BringToFront();
            }
        }

        private void Class_Click(object sender, EventArgs e)
        {
            if (!Activities.Controls.Contains(addClass))
            {
                addClass = new AddClass();
                addClass.TopLevel = false;
                Activities.Controls.Add(addClass);
                addClass.Show();
                addClass.BringToFront();
            }
            else
            {
                addClass.Show();
                addClass.BringToFront();
            }
        }

        private void Student_Click(object sender, EventArgs e)
        {
            if (!Activities.Controls.Contains(addStudent))
            {
                addStudent = new AddStudent();
                addStudent.TopLevel = false;
                Activities.Controls.Add(addStudent);
                addStudent.Show();
                addStudent.BringToFront();
            }
            else
            {
                addStudent.Show();
                addStudent.BringToFront();
            }
        }

        private void BtnSubject_Click(object sender, EventArgs e)
        {
            if (!Activities.Controls.Contains(subject))
            {
                subject = new Subject();
                subject.TopLevel = false;
                Activities.Controls.Add(subject);
                subject.Show();
                subject.BringToFront();
            }
            else
            {
                subject.Show();
                subject.BringToFront();
            }
        }

        private void ForceExit_Click(object sender, EventArgs e)
        {
            Activities.Controls.Clear();
        }

        private void InsertStudent_Click(object sender, EventArgs e)
        {
            if (!Activities.Controls.Contains(insertStudentToAClass))
            {
                insertStudentToAClass = new InsertStudentToAClass();
                insertStudentToAClass.TopLevel = false;
                Activities.Controls.Add(insertStudentToAClass);
                insertStudentToAClass.Show();
                insertStudentToAClass.BringToFront();
            }
            else
            {
                insertStudentToAClass.Show();
                insertStudentToAClass.BringToFront();
            }
        }

        private void ChangeClass_Click(object sender, EventArgs e)
        {
            if (!Activities.Controls.Contains(switchClass))
            {
                switchClass = new SwitchClass();
                switchClass.TopLevel = false;
                Activities.Controls.Add(switchClass);
                switchClass.Show();
                switchClass.BringToFront();
            }
            else
            {
                switchClass.Show();
                switchClass.BringToFront();
            }
        }

        private void materialFlatButton5_Click(object sender, EventArgs e)
        {
            if (!Activities.Controls.Contains(settings))
            {
                settings = new Settings();
                settings.TopLevel = false;
                Activities.Controls.Add(settings);
                settings.Show();
                settings.BringToFront();
            }
            else
            {
                settings.Show();
                settings.BringToFront();
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (!Activities.Controls.Contains(addScoreBySubject))
            {
                addScoreBySubject = new AddScoreBySubject();
                addScoreBySubject.TopLevel = false;
                Activities.Controls.Add(addScoreBySubject);
                addScoreBySubject.Show();
                addScoreBySubject.BringToFront();
            }
            else
            {
                addScoreBySubject.Show();
                addScoreBySubject.BringToFront();
            }
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            if (!Activities.Controls.Contains(addTypeExam))
            {
                addTypeExam = new AddTypeExam();
                addTypeExam.TopLevel = false;
                Activities.Controls.Add(addTypeExam);
                addTypeExam.Show();
                addTypeExam.BringToFront();
            }
            else
            {
                addTypeExam.Show();
                addTypeExam.BringToFront();
            }
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            if (!Activities.Controls.Contains(addScore))
            {
                addScore = new AddScore();
                addScore.TopLevel = false;
                Activities.Controls.Add(addScore);
                addScore.Show();
                addScore.BringToFront();
            }
            else
            {
                addScore.Show();
                addScore.BringToFront();
            }
        }

        private void BtnDataVisualizerMode_Click(object sender, EventArgs e)
        {
            DataVisualizer dataVisualizer = new DataVisualizer();
            this.WindowState = FormWindowState.Minimized;
            dataVisualizer.ShowDialog();
            this.WindowState = FormWindowState.Normal;
        }
        

        private void materialFlatButton7_Click(object sender, EventArgs e)
        {

            if (!Activities.Controls.Contains(upClass))
            {
                upClass = new UpClass();
                upClass.TopLevel = false;
                Activities.Controls.Add(upClass);
                upClass.Show();
                upClass.BringToFront();
            }
            else
            {
                upClass.Show();
                upClass.BringToFront();
            }
        }
    }
}
