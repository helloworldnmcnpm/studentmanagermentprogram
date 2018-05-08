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
        private static InsertToClass _instance;
        public static InsertToClass Instance
        {
            get
            {
                if (_instance == null) _instance = new InsertToClass();
                return _instance;
            }
        }
        List<Student_DTO> ListReady = new List<Student_DTO>();
        List<Class_DTO> ListClass = new List<Class_DTO>();
        List<Term_DTO> ListTerm = new List<Term_DTO>();
        private void LoadList()
        {
            ListReady = Student_BUL.Load();
            ListClass = Class_BUL.Load();
            ListTerm = Term_BUL.Load();
            dataGridView1.DataSource = ListReady;
            comboBox1.DataSource = ListClass;
            ComboboxChangeClass.DataSource = ListClass;
            comboBox2.DataSource = ListTerm;
            if (Class_BUL.Load() != null)
            {
                if (label2.Text == "Sĩ số hiện tại:")
                    label2.Text += " " + Process_BUL.CountStudent(comboBox1.SelectedValue.ToString());
                else
                {
                    label2.Text = "Sĩ số hiện tại:" + " " + Process_BUL.CountStudent(comboBox1.SelectedValue.ToString());
                }
            }
        }

        public InsertToClass()
        {
            InitializeComponent();
        }

        private void ChangeClass_CheckedChanged(object sender, EventArgs e)
        {
            if (ChangeClass.Checked == true)
            {
                label6.Visible = true;
                ComboboxChangeClass.Visible = true;
            }
            else
            {
                label6.Visible = false;
                ComboboxChangeClass.Visible = false;
            }
        }

        private void InsertToClass_Load(object sender, EventArgs e)
        {
            
            LoadList();
            if (label3.Text == "Số học sinh tối đa:")
                label3.Text += " " + Rule_BUL.Load().MaxStudent.ToString();
            else
            {
                label3.Text = "Số học sinh tối đa:" + " " + Rule_BUL.Load().MaxStudent.ToString();
            }
        }

        private Student_DTO ChangeType (DataGridViewRow dr)
        {
            Student_DTO student_DTO = new Student_DTO();
            student_DTO.ID =Convert.ToInt32(dr.Cells[1].Value.ToString());
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

        private void Add_Click(object sender, EventArgs e)
        {
            if (ListReady == null) return;
            if (ListClass == null) return;
            if (ListTerm == null) return;
            if (Process_BUL.CountStudent(comboBox1.SelectedValue.ToString())==Rule_BUL.Load().MaxStudent)
            {
                MessageBox.Show("Lớp đã đầy. Hãy chọn lớp khác!", "Lớp đầy!");
                return;
            }
            Class_BUL.UpdateNumberStudent(Process_BUL.CountStudent(comboBox1.SelectedValue.ToString()) + 1, comboBox1.SelectedValue.ToString());
            Student_DTO student_DTO = ChangeType(dataGridView1.SelectedRows[0]);
            student_DTO.Status = "Inserted";
            if (Process_BUL.InitialProcess(comboBox1.SelectedValue.ToString(), student_DTO.ID, comboBox2.SelectedValue.ToString()) &&
            Student_BUL.Update(student_DTO))
            {
                LoadList();
                dataGridView2.DataSource = Process_BUL.LoadByClass(comboBox1.SelectedValue.ToString());
            }
            else MessageBox.Show("Thất bại!", "Thất bại!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ListReady == null) return;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (label2.Text== "Sĩ số hiện tại:")
            label2.Text +=" "+ Process_BUL.CountStudent(comboBox1.SelectedValue.ToString());
            else
            {
                label2.Text= "Sĩ số hiện tại:"+ " " + Process_BUL.CountStudent(comboBox1.SelectedValue.ToString());
            }
            dataGridView2.DataSource = Process_BUL.LoadByClass(comboBox1.SelectedValue.ToString());
            label4.Text = comboBox1.Text;
        }

        private void ComboboxChangeClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListReady == null) return;
            if (ListClass == null) return;
            if (ListTerm == null) return;
            if (Process_BUL.LoadByClass(comboBox1.SelectedValue.ToString()) == null) return;
            if (Process_BUL.CountStudent(ComboboxChangeClass.SelectedValue.ToString()) == Rule_BUL.Load().MaxStudent)
            {
                MessageBox.Show("Lớp đã đầy, không thể chuyển. Hãy chọn lớp khác!", "Lớp đầy!");
                return;
            }
            
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            InsertToClass_Load(sender, e);
        }
    }
}
