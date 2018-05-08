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
        private static Class _instance;
        public static Class Instance
        {
            get
            {
                if (_instance == null) _instance = new Class();
                return _instance;
            }
        }
        List<Class_DTO> class_DTOs = new List<Class_DTO>();
        List<Grade_DTO> grade_DTOs = new List<Grade_DTO>();
        List<SchoolYear_DTO> schoolYear_DTOs = new List<SchoolYear_DTO>();
        string MS = Rule_BUL.Load().MaxStudent.ToString();
        private void LoadList() {
            class_DTOs = Class_BUL.Load();
            grade_DTOs = Grade_BUL.Load();
            schoolYear_DTOs = SchoolYear_BUL.Load();
            dataGridView1.DataSource = class_DTOs;
            gradetxt.DataSource = grade_DTOs;
            SCtxt.DataSource = schoolYear_DTOs;
        }
        private bool IsNumber(string UncheckedString)
        {
            foreach (Char c in UncheckedString)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private bool CheckData()
        {
            if (IDtxt.Text == "" || Nametxt.Text == "" || SCtxt.SelectedValue == null || gradetxt.SelectedValue == null) return false;
            return true;

        }
        
        public Class()
        {
            InitializeComponent();
        }

        private void Class_Load(object sender, EventArgs e)
        {
            LoadList();
            LabelMaxStudent.Text += MS;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (!CheckData())
            {
                MessageBox.Show("Nhập sai, yêu cầu bạn đọc kĩ quy định.", "Nhập lại");
                return;
            }
            Class_DTO class_DTO = new Class_DTO();
            class_DTO.ID = IDtxt.Text;
            class_DTO.Name = Nametxt.Text;
            class_DTO.GradeID = gradetxt.SelectedValue.ToString();
            class_DTO.SCID = SCtxt.SelectedValue.ToString();
            class_DTO.Students = 0;
            if (Class_BUL.Insert(class_DTO))
            {
                LoadList();
            }
            else MessageBox.Show("Không thể thêm vào database!", "!Database");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Class_BUL.Load() == null) return;
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            Nametxt.Text = dr.Cells[1].Value.ToString();
            gradetxt.Text = dr.Cells[3].Value.ToString();
            SCtxt.Text = dr.Cells[4].Value.ToString();
            IDtxt.Text = dr.Cells[0].Value.ToString();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckData())
            {
                MessageBox.Show("Nhập sai, yêu cầu bạn đọc kĩ quy định.", "Nhập lại");
                return;
            }
            Class_DTO class_DTO = new Class_DTO();
            class_DTO.ID = IDtxt.Text;
            class_DTO.Name = Nametxt.Text;
            class_DTO.GradeID = gradetxt.SelectedValue.ToString();
            class_DTO.SCID = SCtxt.SelectedValue.ToString();
            if (Class_BUL.Update(class_DTO))
            {
                LoadList();
            }
            else MessageBox.Show("Không thể cập nhật vào database!", "!<Database>");
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (Class_BUL.Load() == null) return;
            string ID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (Class_BUL.Delete(ID))
            {
                LoadList();
            }
            else MessageBox.Show("Xóa thất bại! Cần kiểm tra database!", "X<Database>");
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            Class_Load(sender, e);
        }
    }
}
