using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
using DTO;
namespace QLHS
{
    public partial class TypeExam : UserControl
    {
        private static TypeExam _instance;
        public static TypeExam Instance
        {
            get
            {
                if (_instance == null) _instance = new TypeExam();
                return _instance;
            }
        }

        private bool CheckData()
        {
            if (IDtxt.Text == "" || Nametxt.Text == ""|| Indextxt.Text=="") return false;
            if (!IsNumber(Indextxt.Text)) return false;
            return true;
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

        List<TypeExam_DTO> typeExam_DTOs = new List<TypeExam_DTO>();
        private void LoadList()
        {
            typeExam_DTOs = TypeExam_BUL.Load();
            dataGridView1.DataSource = typeExam_DTOs;
        }

        public TypeExam()
        {
            InitializeComponent();
        }

        private void TypeExam_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (typeExam_DTOs == null) return;
            
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (!CheckData())
            {
                MessageBox.Show("Nhập sai, yêu cầu bạn đọc kĩ quy định.", "Nhập lại");
                return;
            }
            TypeExam_DTO typeExam_DTO = new TypeExam_DTO();
            typeExam_DTO.ID = IDtxt.Text;
            typeExam_DTO.Name = Nametxt.Text;
            typeExam_DTO.Index = Convert.ToInt32(Indextxt.Text);
            if (TypeExam_BUL.Insert(typeExam_DTO))
            {
                LoadList();
            }
            else MessageBox.Show("Không thể thêm vào database!", "!Database");

        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (typeExam_DTOs == null) return;
            if (!CheckData())
            {
                MessageBox.Show("Nhập sai, yêu cầu bạn đọc kĩ quy định.", "Nhập lại");
                return;
            }
            TypeExam_DTO typeExam_DTO = new TypeExam_DTO();
            typeExam_DTO.ID = IDtxt.Text;
            typeExam_DTO.Name = Nametxt.Text;
            typeExam_DTO.Index = Convert.ToInt32(Indextxt.Text);
            if (TypeExam_BUL.Update(typeExam_DTO))
            {
                LoadList();
            }
            else MessageBox.Show("Không thể cập nhật vào database!", "!<Database>");
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (typeExam_DTOs == null) return;
            string ID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (TypeExam_BUL.Delete(ID))
            {
                LoadList();
            }
            else MessageBox.Show("Xóa thất bại! Cần kiểm tra database!", "X<Database>");
        }

        private void Indextxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
