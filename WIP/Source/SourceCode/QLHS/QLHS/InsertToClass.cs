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





        /// <summary>
        /// LOAD
        /// </summary>
        public InsertToClass()
        {
            InitializeComponent();
        }
        private void InsertToClass_Load(object sender, EventArgs e)
        {
            //Load Schoolyear
            if (SchoolYear_BUL.Load() == null)
            {
                panel2.Visible = false;
                Add.Enabled = false;
                ChangeClass.Visible = false;
                dataGridView1.Enabled = false;
                dataGridView2.Enabled = false;
                dataGridView3.Enabled = false;
            }
            else
            {
                SchoolYearComboBox.DataSource = SchoolYear_BUL.Load();
                panel2.Visible = true;
                Add.Enabled = true;
                ChangeClass.Visible = true;
                dataGridView1.Enabled = true;
                dataGridView2.Enabled = true;
                dataGridView3.Enabled = true;
                label3.Text = "Số học sinh tối đa:" + Rule_BUL.Load().MaxStudent;
            }
            if (Student_BUL.Load() == null) dataGridView1.DataSource = null;
            else
            {
                dataGridView1.DataSource = Student_BUL.Load();
            }
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
                dataGridView3.Enabled = true;
                ComboboxChangeClass1.DataSource = Class_BUL.LoadBySC(SchoolYearComboBox.SelectedValue.ToString());
                ComboboxChangeClass2.DataSource = Class_BUL.LoadBySC(SchoolYearComboBox.SelectedValue.ToString());
                ComboBoxTerm2.DataSource = Term_BUL.LoadBySC(SchoolYearComboBox.SelectedValue.ToString());
                Add.Enabled = false;
                dataGridView1.Enabled = false;
                ComboBoxClass.Enabled = false;
                ComboBoxTerm1.Enabled = false;
            }
            else
            {
                PanelSwitchStudent.Visible = false;
                dataGridView3.Enabled = false;
                Add.Enabled = true;
                dataGridView1.Enabled = true;
                ComboBoxClass.Enabled = true;
                ComboBoxTerm1.Enabled = true;
                dataGridView3.DataSource = null;
            }
        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count + Process_BUL.CountStudent(ComboBoxClass.SelectedValue.ToString()) >= Rule_BUL.Load().MaxStudent)
            {
                MessageBox.Show("Số học sinh đã chọn vượt quá số học sinh quy định trong một lớp! Tuy nhiên, một số học sinh có thể thêm vào lớp này!", "Thông báo!");
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    if (Process_BUL.CountStudent(ComboBoxClass.SelectedValue.ToString()) < Rule_BUL.Load().MaxStudent)
                    {
                        Process_BUL.InitialProcess(ComboBoxClass.SelectedValue.ToString(), int.Parse(dataGridView1.SelectedRows[i].Cells[1].Value.ToString()), ComboBoxTerm1.SelectedValue.ToString());
                        Student_DTO student_DTO = ChangeType(dataGridView1.SelectedRows[i]);
                        student_DTO.Status = "Inserted";
                        Student_BUL.Update(student_DTO);
                    }
                    else break;
                }
                dataGridView1.DataSource = Student_BUL.Load();
                dataGridView2.DataSource = Process_BUL.LoadByClass(ComboBoxClass.SelectedValue.ToString());
                label5.Text = "Sĩ số:" + Process_BUL.CountStudent(ComboBoxClass.SelectedValue.ToString());
                return;
            }
            else
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    Process_BUL.InitialProcess(ComboBoxClass.SelectedValue.ToString(), int.Parse(dataGridView1.SelectedRows[i].Cells[1].Value.ToString()), ComboBoxTerm1.SelectedValue.ToString());
                    Student_DTO student_DTO = ChangeType(dataGridView1.SelectedRows[i]);
                    student_DTO.Status = "Inserted";
                    Student_BUL.Update(student_DTO);
                }
                dataGridView1.DataSource = Student_BUL.Load();
                dataGridView2.DataSource = Process_BUL.LoadByClass(ComboBoxClass.SelectedValue.ToString());
                label5.Text = "Sĩ số:" + Process_BUL.CountStudent(ComboBoxClass.SelectedValue.ToString());
            }
        }
        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count + Process_BUL.CountStudent(ComboboxChangeClass2.SelectedValue.ToString()) >= Rule_BUL.Load().MaxStudent)
            {
                MessageBox.Show("Số học sinh đã chọn và sĩ số lớp hiện tại vượt quá quy định, vì vậy chỉ có thể thêm một số học sinh vào lớp!", "Thông báo");
                for (int i = 0; i < dataGridView2.SelectedRows.Count; i++)
                {
                    if (Process_BUL.CountStudent(ComboboxChangeClass2.SelectedValue.ToString()) < Rule_BUL.Load().MaxStudent)
                    {
                        Student_BUL.ChangeClass(int.Parse(dataGridView2.SelectedRows[i].Cells[1].Value.ToString()), ComboBoxTerm2.SelectedValue.ToString(), ComboboxChangeClass2.SelectedValue.ToString());
                    }
                    else break;
                }
                dataGridView2.DataSource = Process_BUL.LoadByClass(ComboboxChangeClass1.SelectedValue.ToString());
                dataGridView3.DataSource = Process_BUL.LoadByClass(ComboboxChangeClass2.SelectedValue.ToString());
            }
            else
            {
                for (int i = 0; i < dataGridView2.SelectedRows.Count; i++)
                {
                    Student_BUL.ChangeClass(int.Parse(dataGridView2.SelectedRows[i].Cells[1].Value.ToString()), ComboBoxTerm2.SelectedValue.ToString(), ComboboxChangeClass2.SelectedValue.ToString());
                }
                dataGridView2.DataSource = Process_BUL.LoadByClass(ComboboxChangeClass1.SelectedValue.ToString());
                dataGridView3.DataSource = Process_BUL.LoadByClass(ComboboxChangeClass2.SelectedValue.ToString());
            }
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
            if (Class_BUL.LoadBySC(SchoolYearComboBox.SelectedValue.ToString()) == null)
            {
                Add.Enabled = false;
            }
            else
            {
                Add.Enabled = true;
                ComboBoxClass.DataSource = Class_BUL.LoadBySC(SchoolYearComboBox.SelectedValue.ToString());
                if (Term_BUL.LoadBySC(SchoolYearComboBox.SelectedValue.ToString()) == null)
                {
                    Add.Enabled = false;
                }
                else
                {
                    Add.Enabled = true;
                    ComboBoxTerm1.DataSource = Term_BUL.LoadBySC(SchoolYearComboBox.SelectedValue.ToString());
                }
            }
        }
        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Text = "Sĩ số:" + Process_BUL.CountStudent(ComboBoxClass.SelectedValue.ToString());
            label4.Text = ComboBoxClass.Text;
            if (Process_BUL.CountStudent(ComboBoxClass.SelectedValue.ToString())>=Rule_BUL.Load().MaxStudent)
            {
                Add.Enabled = false;
            }else
            {
                Add.Enabled = true;
            }
            if (Process_BUL.LoadByClass(ComboBoxClass.SelectedValue.ToString()) == null) dataGridView2.DataSource=null;
            else
            {
                dataGridView2.DataSource = Process_BUL.LoadByClass(ComboBoxClass.SelectedValue.ToString());
            }
        }
        private void ComboBoxTerm1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.DataSource == null) return;
        }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView3.DataSource== null) return;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.DataSource == null) return;
        }
        private void ComboboxChangeClass1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = ComboboxChangeClass1.Text;
            if (Class_BUL.LoadBySC(SchoolYearComboBox.SelectedValue.ToString()) == null)
            {
                buttonSwitch.Enabled = false;
            }
            else
            {
                if (ComboboxChangeClass1.Text == ComboboxChangeClass2.Text)
                {
                    buttonSwitch.Enabled = false;
                    if (Process_BUL.LoadByClass(ComboboxChangeClass1.SelectedValue.ToString()) == null) dataGridView2.DataSource = null;
                    else dataGridView2.DataSource = Process_BUL.LoadByClass(ComboboxChangeClass1.SelectedValue.ToString());
                }
                else
                {
                    buttonSwitch.Enabled = true;
                    if (Process_BUL.LoadByClass(ComboboxChangeClass1.SelectedValue.ToString()) == null)
                    {
                        dataGridView2.DataSource = null;
                        buttonSwitch.Enabled = false;
                    }
                    else
                    {
                        buttonSwitch.Enabled = true;
                        dataGridView2.DataSource = Process_BUL.LoadByClass(ComboboxChangeClass1.SelectedValue.ToString());
                        if (Term_BUL.LoadBySC(SchoolYearComboBox.SelectedValue.ToString()) == null)
                        {
                            buttonSwitch.Enabled = false;
                        }
                        else
                        {
                            buttonSwitch.Enabled = true;
                            ComboBoxTerm2.DataSource = Term_BUL.LoadBySC(SchoolYearComboBox.SelectedValue.ToString());
                        }
                    }
                }
            }
        }
        private void ComboboxChangeClass2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label12.Text = ComboboxChangeClass2.Text;
            if (Class_BUL.LoadBySC(SchoolYearComboBox.SelectedValue.ToString()) == null)
            {
                buttonSwitch.Enabled = false;
            }
            else
            {
                buttonSwitch.Enabled = true;
                dataGridView2.Enabled = true;
                if (ComboboxChangeClass1.Text == ComboboxChangeClass2.Text) buttonSwitch.Enabled = false;
                else buttonSwitch.Enabled = true;
                if (Process_BUL.LoadByClass(ComboboxChangeClass2.SelectedValue.ToString()) == null)
                    dataGridView3.DataSource = null;
                else
                {
                    dataGridView3.DataSource = Process_BUL.LoadByClass(ComboboxChangeClass2.SelectedValue.ToString());
                }
            }
        }
        private void ComboBoxTerm2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            InsertToClass_Load(sender, e);
        }
    }
}
