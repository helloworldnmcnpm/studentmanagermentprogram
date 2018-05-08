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
    public partial class Grade : UserControl
    {
        /// <summary>
        /// CHECK/CREATE INSTANCE
        /// </summary>
        private static Grade _instance;
        public static Grade Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Grade();
                }
                return _instance;
            }
        }
        private bool CheckData()
        {
            if (IDtxt.Text == "" || Nametxt.Text == "") return false;
            return true;
        }
        List<Grade_DTO> grade_DTOs = new List<Grade_DTO>();
        private void LoadList()
        {
            grade_DTOs = Grade_BUL.Load();
            dataGridView1.DataSource = grade_DTOs;
        }
        public Grade()
        {
            InitializeComponent();
        }

        private void Grade_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Grade_DTO grade_DTO = new Grade_DTO();
            grade_DTO.ID = IDtxt.Text;
            grade_DTO.Name = Nametxt.Text;
            if (!CheckData()) {
                MessageBox.Show("Thêm thất bại, không được để trống dữ liệu!", "Thất bại");
                return;
            }
            if (Grade_BUL.Insert(grade_DTO))
            {
                LoadList();
            } else MessageBox.Show("Không thể thêm vào database!", "!Database");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Grade_BUL.Load() == null) return;
            IDtxt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Nametxt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            Grade_DTO grade_DTO = new Grade_DTO();
            grade_DTO.ID = IDtxt.Text;
            grade_DTO.Name = Nametxt.Text;
            if (!CheckData())
            {
                MessageBox.Show("Cập nhật thất bại, không được để trống dữ liệu!", "Thất bại");
                return;
            }
            if (Grade_BUL.Update(grade_DTO))
            {
                LoadList();
            }
            else MessageBox.Show("Không thể cập nhật vào database!", "!<Database>");
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (Grade_BUL.Load() == null) return;
            string ID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (Grade_BUL.Delete(ID))
            {
                LoadList();
            } else MessageBox.Show("Xóa thất bại! Cần kiểm tra database!", "X<Database>");
        }
    }
}
