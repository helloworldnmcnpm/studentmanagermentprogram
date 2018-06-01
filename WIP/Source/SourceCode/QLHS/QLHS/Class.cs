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
    public partial class Class : UserControl
    {
        /// <summary>
        /// INITIAL
        /// </summary>
        private static Class _instance;
        public static Class Instance
        {
            get
            {
                if (_instance == null) _instance = new Class();
                return _instance;
            }
        }  



        /// <summary>
        /// LOAD
        /// </summary>
        /// <returns></returns>
        /// 
        public Class()
        {
            InitializeComponent();
        }
        private void Class_Load(object sender, EventArgs e)
        {
            if (SchoolYear_BUL.Load() == null||Grade_BUL.Load()==null)
            {
                Add.Enabled = false;
                ButtonDelete.Enabled = false;
                ButtonUpdate.Enabled = false;
                dataGridView1.Enabled = false;
            }
            else
            {
                Add.Enabled = true;
                ButtonDelete.Enabled = true;
                ButtonUpdate.Enabled = true;
                dataGridView1.Enabled = true;
                SCtxt.DataSource = SchoolYear_BUL.Load();
                gradetxt.DataSource = Grade_BUL.Load();
            }
            if (Class_BUL.Load() != null)
            {
                dataGridView1.DataSource = Class_BUL.Load();
                ButtonDelete.Enabled = true;
                ButtonUpdate.Enabled = true;
            }
            else
            {
                dataGridView1.DataSource = null;
                ButtonDelete.Enabled = false;
                ButtonUpdate.Enabled = false;
            }
            LabelMaxStudent.Text = "Số học sinh tối đa:" + Rule_BUL.Load().MaxStudent;
        }




        /// <summary>
        /// BUTTON
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Click(object sender, EventArgs e)
        {
            Class_DTO class_DTO = new Class_DTO();
            class_DTO.ID = IDtxt.Text;
            class_DTO.Name = Nametxt.Text;
            class_DTO.SCID = SCtxt.SelectedValue.ToString();
            class_DTO.Students = 0;
            class_DTO.GradeID = gradetxt.SelectedValue.ToString();
            if (Class_BUL.Insert(class_DTO))
            {
                dataGridView1.DataSource = Class_BUL.Load();
                Reload_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Kiểm tra lại database hoặc DataAccessLayer!", "Thông báo!");
            }
        }
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            Class_DTO class_DTO = new Class_DTO();
            class_DTO.ID = IDtxt.Text;
            class_DTO.Name = Nametxt.Text;
            class_DTO.SCID = SCtxt.SelectedValue.ToString();
            class_DTO.Students = 0;
            class_DTO.GradeID = gradetxt.SelectedValue.ToString();
            if (Class_BUL.Update(class_DTO))
            {
                dataGridView1.DataSource = Class_BUL.Load();
            }
            else
            {
                MessageBox.Show("Kiểm tra lại database hoặc DataAccessLayer!", "Thông báo!");
                Reload_Click(sender, e);
            }
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (Class_BUL.Load() == null) return;
            if (Class_BUL.Delete(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()))
            {
                dataGridView1.DataSource = Class_BUL.Load();
                Reload_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Kiểm tra lại database hoặc DataAccessLayer!", "Thông báo!");
                Reload_Click(sender, e);
            }
        }
        private void Reload_Click(object sender, EventArgs e)
        {
            Class_Load(sender, e);
        }


        /// <summary>
        /// EVENT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Class_BUL.Load() == null) return;
            SCtxt.SelectedValue = dataGridView1.SelectedRows[0].Cells[4].Value;
            gradetxt.SelectedValue = dataGridView1.SelectedRows[0].Cells[3].Value;
            Nametxt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
