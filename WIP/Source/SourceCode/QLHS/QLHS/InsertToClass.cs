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
        List<Student_DTO> student_DTOs = new List<Student_DTO>();
        List<SchoolYear_DTO> schoolYear_DTOs = new List<SchoolYear_DTO>();
        List<Class_DTO> Class_DTOs = new List<Class_DTO>();
        private void LoadList()
        {
            student_DTOs = Student_BUL.Load();
            dataGridView1.DataSource = student_DTOs;
            schoolYear_DTOs = SchoolYear_BUL.Load();
            SchoolYearComboBox.DataSource = schoolYear_DTOs;
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
            LoadList();
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
        private void buttonReload_Click(object sender, EventArgs e)
        {
            InsertToClass_Load(sender, e);
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
            if (SchoolYear_BUL.Load() == null) return;
            Class_DTOs = Class_BUL.LoadBySC(SchoolYearComboBox.SelectedValue.ToString());
            comboBox1.DataSource = Class_DTOs;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Class_DTOs == null) return; //Already has class_DTOs from SchoolYear.

        }
        private void ComboboxChangeClass_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Student_BUL.Load() == null) return;
        }
    }
}
