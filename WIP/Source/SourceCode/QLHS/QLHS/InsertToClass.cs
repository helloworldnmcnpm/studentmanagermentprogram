using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUL;

namespace QLHS
{
    public partial class InsertToClass : UserControl
    {
        /// <summary>
        /// INITIAL DATA
        /// </summary>
        List<Student_DTO> ListStudentReady = new List<Student_DTO>();
        List<SchoolYear_DTO> schoolYear_DTOs = new List<SchoolYear_DTO>();
        List<Class_DTO> class_DTOs = new List<Class_DTO>();
        List<Term_DTO> term_DTOs = new List<Term_DTO>();
        private static InsertToClass _instance;
        public static InsertToClass Instance
        {
            get
            {
                if (_instance == null) _instance = new InsertToClass();
                return _instance;
            }
        }




        private Student_DTO ChangeType(DataGridViewRow dr)
        {
            Student_DTO student_DTO = new Student_DTO();
            student_DTO.ID = Convert.ToInt32(dr.Cells[1].Value.ToString());
            student_DTO.Status = dr.Cells[0].Value.ToString();
            student_DTO.Name = dr.Cells[2].Value.ToString();
            student_DTO.Sex = dr.Cells[3].Value.ToString();
            student_DTO.Birthday = Convert.ToDateTime(dr.Cells[4].Value.ToString());
            student_DTO.Birthplace = dr.Cells[5].Value.ToString();
            student_DTO.Address = dr.Cells[6].Value.ToString();
            student_DTO.Religion = dr.Cells[7].Value.ToString();
            student_DTO.National = dr.Cells[8].Value.ToString();
            student_DTO.Phone = dr.Cells[9].Value.ToString();
            student_DTO.Father = dr.Cells[10].Value.ToString();
            student_DTO.FJob = dr.Cells[11].Value.ToString();
            student_DTO.Mother = dr.Cells[12].Value.ToString();
            student_DTO.MJob = dr.Cells[13].Value.ToString();
            return student_DTO;
        }
        private void LoadList()
        {
            //Load List student
            if (Student_BUL.Load() == null) return;
            ListStudentReady = Student_BUL.Load();
            dataGridView1.DataSource = ListStudentReady;


            //Load List school year
            if (SchoolYear_BUL.Load() == null) return;
            schoolYear_DTOs = SchoolYear_BUL.Load();
            SchoolYearComboBox.DataSource = schoolYear_DTOs;
        }




        /// <summary>
        /// LOAD
        /// </summary>
        public InsertToClass()
        {
            InitializeComponent();
        }
        private void InsertToClass_Load(object sender, EventArgs e)
        {
            LoadList();
            if (Student_BUL.Load()==null)
            {
                Add.Enabled = false;
                SchoolYearComboBox.Enabled = false;
                ComboBoxClass.Enabled = false;
                ComboBoxTerm1.Enabled = false;
            }
            else
            {
                Add.Enabled = true;
                SchoolYearComboBox.Enabled = true;
                ComboBoxClass.Enabled = true;
                ComboBoxTerm1.Enabled = true;
            }
            if (SchoolYear_BUL.Load() == null)
            {
                Add.Enabled = false;
                SchoolYearComboBox.Enabled = false;
                ComboBoxClass.Enabled = false;
                ComboBoxTerm1.Enabled = false;
                dataGridView2.Enabled = false;
                dataGridView3.Enabled = false;
                ChangeClass.Visible = false;
            }
            else
            {
                Add.Enabled = true;
                SchoolYearComboBox.Enabled = true;
                ComboBoxClass.Enabled = true;
                ComboBoxTerm1.Enabled = true;
                dataGridView2.Enabled = true;
                dataGridView3.Enabled = true;
                ChangeClass.Visible = true;
            }
            label3.Text = "Số học sinh tối đa: " + Rule_BUL.Load().MaxStudent;
        }




        /// <summary>
        /// BUTTON
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeClass_CheckedChanged(object sender, EventArgs e)
        {
            if (ChangeClass.Checked)
            {
                PanelSwitchStudent.Visible = true;
                Add.Enabled = false;
                panel2.Visible = false;
                dataGridView1.Enabled = false;
            }
            else
            {
                PanelSwitchStudent.Visible = false;
                Add.Enabled = true;
                panel2.Visible = true;
                dataGridView1.Enabled = true;
            }
        }
        private void Add_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                //Initializing Process of students
                
                if(Process_BUL.InitialProcess(ComboBoxClass.SelectedValue.ToString(), int.Parse(dataGridView1.SelectedRows[i].Cells[1].Value.ToString()), ComboBoxTerm1.SelectedValue.ToString()))
                {
                    Student_DTO student_DTO = new Student_DTO();
                    student_DTO= ChangeType(dataGridView1.SelectedRows[i]);
                    student_DTO.Status = "Inserted";
                    Student_BUL.Update(student_DTO);
                } else
                {
                    MessageBox.Show("Không thể thêm vào!", "Không thể!");
                }
            }
            dataGridView1.DataSource = Student_BUL.Load();
            dataGridView2.DataSource = Process_BUL.LoadByClass(ComboBoxClass.SelectedValue.ToString());
        }
        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            
        }
        private void ButtonGuide_Click(object sender, EventArgs e)
        {

        }




        /// <summary>
        /// EVENT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void SchoolYearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Load Class to combobox
            if (Class_BUL.LoadBySC(SchoolYearComboBox.SelectedValue.ToString()) == null) return;
            ComboBoxClass.DataSource = Class_BUL.LoadBySC(SchoolYearComboBox.SelectedValue.ToString());
            ComboboxChangeClass1.DataSource = Class_BUL.LoadBySC(SchoolYearComboBox.SelectedValue.ToString());
            ComboboxChangeClass2.DataSource = Class_BUL.LoadBySC(SchoolYearComboBox.SelectedValue.ToString());
            //Load Term to combobox
            if (Term_BUL.LoadBySC(SchoolYearComboBox.SelectedValue.ToString()) == null) return;
            ComboBoxTerm1.DataSource = Term_BUL.LoadBySC(SchoolYearComboBox.SelectedValue.ToString());
            ComboBoxTerm2.DataSource = Term_BUL.LoadBySC(SchoolYearComboBox.SelectedValue.ToString());
        }
        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Class_BUL.LoadBySC(SchoolYearComboBox.SelectedValue.ToString())==null)
            {
                Add.Enabled = false;
                return;
            }
            else
            {
                Add.Enabled = true;
                LabelNumberOfStudent1.Text = Process_BUL.CountStudent(ComboBoxClass.SelectedValue.ToString()).ToString();
                if (Process_BUL.LoadByClass(ComboBoxClass.SelectedValue.ToString()) == null)
                {
                    label4.Text = ComboBoxClass.Text;
                }
                else
                {
                    dataGridView2.DataSource = Process_BUL.LoadByClass(ComboBoxClass.SelectedValue.ToString());
                    label4.Text = ComboBoxClass.Text;
                }
                
            }
            if (Process_BUL.CountStudent(ComboBoxClass.SelectedValue.ToString()) >= Rule_BUL.Load().MaxStudent)
            {
                Add.Enabled = false;
            }
            else Add.Enabled = true;
        }
        private void ComboBoxTerm1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Term_BUL.LoadBySC(SchoolYearComboBox.SelectedValue.ToString()) == null)
            {
                Add.Enabled = false;
                return;
            }
            else
            {
                Add.Enabled = true;
            }
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //List Student = null
            if (Student_BUL.Load() == null) return;
            //SelectedRows >= Number of students of Selected-class.
            if (dataGridView1.SelectedRows.Count + Process_BUL.CountStudent(ComboBoxClass.SelectedValue.ToString())>Rule_BUL.Load().MaxStudent)
            {
                Add.Enabled = false;
            }
            else
            {
                Add.Enabled = true;
            }
        }
        private void ComboboxChangeClass1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ChangeClass.Checked == false) return;
            if (Class_BUL.LoadBySC(SchoolYearComboBox.SelectedValue.ToString()) == null)
            {
                buttonSwitch.Enabled = false;
                return;
            }
            else
            {
                buttonSwitch.Enabled = true;
                if (Process_BUL.LoadByClass(ComboboxChangeClass1.SelectedValue.ToString()) == null)
                {
                    label4.Text = ComboboxChangeClass1.Text;
                }
                else
                {
                    dataGridView2.DataSource = Process_BUL.LoadByClass(ComboboxChangeClass1.SelectedValue.ToString());
                    label4.Text = ComboboxChangeClass1.Text;
                }
            }
        }
        private void ComboboxChangeClass2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ComboBoxTerm2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
