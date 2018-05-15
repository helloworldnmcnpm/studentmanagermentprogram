﻿using System;
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
        List<Class_DTO> class_DTOs = new List<Class_DTO>();
        private void LoadList()
        {
            ListReady = Student_BUL.Load();
            ListClass = Class_BUL.Load();
            ListTerm = Term_BUL.Load();
            class_DTOs = Class_BUL.Load();
            dataGridView1.DataSource = ListReady;
            comboBox1.DataSource = ListClass;
            ComboboxChangeClass.DataSource = class_DTOs;
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
                label7.Visible = true;
                comboBox2.Visible = true;
                label9.Visible = true;
                buttonSwitch.Visible = true;
                classDTOBindingSource1.DataSource = Class_BUL.Load();
                
            }
            else
            {
                label6.Visible = false;
                ComboboxChangeClass.Visible = false;
                label7.Visible = false;
                comboBox2.Visible = false;
                label9.Visible = false;
                buttonSwitch.Visible = false;
            }
        }

        private void InsertToClass_Load(object sender, EventArgs e)
        {
            label6.Visible = false;
            ComboboxChangeClass.Visible = false;
            label7.Visible = false;
            comboBox2.Visible = false;
            label9.Visible = false;
            buttonSwitch.Visible = false;
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
                label8.Text = "Trạng thái: Thêm vào lớp " + comboBox1.SelectedValue.ToString() + " Thành công!";
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
            ComboboxChangeClass.DataSource = class_DTOs;
            if (comboBox1.SelectedValue.ToString() == ComboboxChangeClass.SelectedValue.ToString())
            {
                label9.ForeColor = Color.Red;
                label9.Text = "Lớp trùng, không thể chuyển! Hãy chọn lớp khác!";
                return;
            }
            else
            if (Process_BUL.CountStudent(ComboboxChangeClass.SelectedValue.ToString()) == Rule_BUL.Load().MaxStudent)
            {
                label9.ForeColor = Color.Red;
                label9.Text = "Lớp đã đầy, không thể chuyển lớp!";
            }
            else
            {
                label9.Text = "Có thể chuyển lớp!";
                label9.ForeColor = Color.FromArgb(18, 148, 246);
            }
        }

        private void ComboboxChangeClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListClass == null) return;
            if (ListTerm == null) return;
 //           Process_BUL.LoadByClass(ComboboxChangeClass.SelectedValue.ToString()) == null) return;
            label5.Text =ComboboxChangeClass.Text;
            if (comboBox1.SelectedValue.ToString() == ComboboxChangeClass.SelectedValue.ToString())
            {
                label9.ForeColor = Color.Red;
                label9.Text = "Lớp trùng, không thể chuyển! Hãy chọn lớp khác!";
            }
            else
            if (Process_BUL.CountStudent(ComboboxChangeClass.SelectedValue.ToString()) == Rule_BUL.Load().MaxStudent)
            {
                label9.ForeColor = Color.Red;
                label9.Text = "Lớp đã đầy, không thể chuyển lớp!";
            }
            else
            {
                label9.Text = "Có thể chuyển lớp!";
                label9.ForeColor = Color.FromArgb(18, 148, 246);
            }
            if (Class_BUL.Load() != null)
            {
                if (label10.Text == "Sĩ số hiện tại:")
                    label10.Text += " " + Process_BUL.CountStudent(ComboboxChangeClass.SelectedValue.ToString());
                else
                {
                    label10.Text = "Sĩ số hiện tại:" + " " + Process_BUL.CountStudent(ComboboxChangeClass.SelectedValue.ToString());
                }
            }
            dataGridView3.DataSource = Process_BUL.LoadByClass(ComboboxChangeClass.SelectedValue.ToString());
            
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            InsertToClass_Load(sender, e);
        }

        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            if (ListClass == null) return;
            if (ListTerm == null) return;
            if (Process_BUL.LoadByClass(comboBox1.SelectedValue.ToString()) == null) return;
            if (ComboboxChangeClass.SelectedValue.ToString() == comboBox1.SelectedValue.ToString())
            {
                MessageBox.Show("Hãy chọn lớp khác!");
                return;
            }
            int studentID = int.Parse(dataGridView2.SelectedRows[0].Cells[1].Value.ToString());
            string ClassID = ComboboxChangeClass.SelectedValue.ToString();
            string TermID = comboBox2.SelectedValue.ToString();
            if (Process_BUL.CountStudent(ComboboxChangeClass.SelectedValue.ToString()) == Rule_BUL.Load().MaxStudent)
            {
                MessageBox.Show("Lớp đã đầy, không thể chuyển. Hãy chọn lớp khác!", "Lớp đầy!");
                return;
            }
            if (Student_BUL.ChangeClass(studentID, TermID, ClassID))
            {
                dataGridView3.DataSource = Process_BUL.LoadByClass(ClassID);
                label8.Text = "Trạng thái: Chuyển thành công!";
                dataGridView3.Refresh();
                dataGridView2.DataSource = Process_BUL.LoadByClass(comboBox1.SelectedValue.ToString());
                if (label10.Text == "Sĩ số hiện tại:")
                    label10.Text += " " + Process_BUL.CountStudent(ComboboxChangeClass.SelectedValue.ToString());
                else
                {
                    label10.Text = "Sĩ số hiện tại:" + " " + Process_BUL.CountStudent(ComboboxChangeClass.SelectedValue.ToString());
                }
                if (label2.Text == "Sĩ số hiện tại:")
                    label2.Text += " " + Process_BUL.CountStudent(comboBox1.SelectedValue.ToString());
                else
                {
                    label2.Text = "Sĩ số hiện tại:" + " " + Process_BUL.CountStudent(comboBox1.SelectedValue.ToString());
                }

            }
            else MessageBox.Show("Chuyển lớp thất bại!");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Process_BUL.LoadByClass(comboBox1.SelectedValue.ToString()) == null) return;
        }

        private void classDTOBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Process_BUL.LoadByClass(ComboboxChangeClass.SelectedValue.ToString()) == null) return;
        }

        private void ButtonGuide_Click(object sender, EventArgs e)
        {

        }
    }
}
