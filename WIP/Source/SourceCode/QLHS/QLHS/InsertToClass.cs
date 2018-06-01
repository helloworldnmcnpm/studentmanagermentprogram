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
        private static InsertToClass _instance;
        public static InsertToClass Instance
        {
            get
            {
                if (_instance == null) _instance = new InsertToClass();
                return _instance;
            }
        }
        public static void Refresh(object sender,EventArgs e)
        {
            ButtonRefresh_Click(sender,e);
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
            //(1)&(2)
            if (Student_BUL.Load() == null)
            {
                dataGridView1.Enabled = false;
                ComboBoxClass.Enabled = false;
                ComboBoxTerm1.Enabled = false;
                Add.Enabled = false;
            }
            else
            {
                dataGridView1.Enabled = true;
                ComboBoxClass.Enabled = true; 
                ComboBoxTerm1.Enabled = true;
                Add.Enabled = true;
                dataGridView1.DataSource = Student_BUL.Load();
            }
            if (SchoolYear_BUL.Load() == null)
            {
                ChangeClass.Enabled = false;
                ComboBoxClass.Enabled = false;
                ComboBoxTerm1.Enabled = false;
                dataGridView1.Enabled = false;
                dataGridView2.Enabled = false;
                dataGridView3.Enabled = false;
                Add.Enabled = false;
            }
            else
            {
                ChangeClass.Enabled = true;
                ComboBoxClass.Enabled = true;
                ComboBoxTerm1.Enabled = true;
                dataGridView1.Enabled = true;
                dataGridView2.Enabled = true;
                dataGridView3.Enabled = true;
                Add.Enabled = true;
                SchoolYearComboBox.DataSource = SchoolYear_BUL.Load();
            }
        }




        /// <summary>
        /// BUTTON
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeClass_CheckedChanged(object sender, EventArgs e)
        {
        
        }
        private void Add_Click(object sender, EventArgs e)
        {
            
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
            if (Class_BUL.LoadBySC(SchoolYearComboBox.SelectedValue.ToString()) == null || Term_BUL.LoadBySC(SchoolYearComboBox.SelectedValue.ToString()) == null)
            {
                Add.Enabled = false;
                ComboBoxTerm1.Enabled = false;
                ComboBoxClass.Enabled = false;
            }
            else
            {
                Add.Enabled = true;
                ComboBoxTerm1.Enabled = true;
                ComboBoxClass.Enabled = true;
                ComboBoxClass.DataSource = Class_BUL.LoadBySC(SchoolYearComboBox.SelectedValue.ToString());
                ComboBoxTerm1.DataSource = Term_BUL.LoadBySC(SchoolYearComboBox.SelectedValue.ToString());
            }
        }
        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
            if (dataGridView3.DataSource == null) return;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.DataSource == null) return;
        }
        private void ComboboxChangeClass1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
        private void ComboboxChangeClass2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        private void ComboBoxTerm2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private static void ButtonRefresh_Click(object sender, EventArgs e)
        {
            InsertToClass_Load(sender, e);
        }
    }
}
