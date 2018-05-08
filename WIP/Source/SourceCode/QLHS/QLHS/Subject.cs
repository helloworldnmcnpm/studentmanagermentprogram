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
    public partial class Subject : UserControl
    {
        private static Subject _instance        ;
        public static Subject Instance
        {
            get
            {
                if (_instance == null) _instance = new Subject();
                return _instance;
            }
        }
        List<Subject_DTO> subject_DTOs = new List<Subject_DTO>();
        private void LoadList()
        {
            subject_DTOs = Subject_BUL.Load();
            dataGridView1.DataSource = subject_DTOs;
        }

        private bool CheckData()
        {
            if (IDtxt.Text == "" || Nametxt.Text == "") return false;
            return true;
        }
        public Subject()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (subject_DTOs == null) return;
            IDtxt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Nametxt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

        }

        private void Subject_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Subject_DTO subject_DTO = new Subject_DTO();
            subject_DTO.ID = IDtxt.Text;
            subject_DTO.Name = Nametxt.Text;
            if (!CheckData())
            {
                MessageBox.Show("Nhập sai, yêu cầu bạn đọc kĩ quy định.", "Nhập lại");
                return;
            }
            if (Subject_BUL.Insert(subject_DTO))
            {
                LoadList();
            }
            else MessageBox.Show("Không thể thêm vào database!", "!Database");
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (subject_DTOs == null) return;
            if (!CheckData())
            {
                MessageBox.Show("Nhập sai, yêu cầu bạn đọc kĩ quy định.", "Nhập lại");
                return;
            }
            Subject_DTO subject_DTO = new Subject_DTO();
            subject_DTO.ID = IDtxt.Text;
            subject_DTO.Name = Nametxt.Text;
            if (Subject_BUL.Update(subject_DTO))
            {
                LoadList();
            }
            else MessageBox.Show("Không thể cập nhật vào database!", "!<Database>");
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (subject_DTOs == null) return;
            string ID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (Subject_BUL.Delete(ID))
            {
                LoadList();
            }
            else MessageBox.Show("Xóa thất bại! Cần kiểm tra database!", "X<Database>");
        }

        private void ButtonAddStudent_Click(object sender, EventArgs e)
        {
            Activities.Visible = false;
        }

        private void buttonInsertToClass_Click(object sender, EventArgs e)
        {
            Activities.Visible = true;
            if (!Activities.Controls.Contains(ScoreBySubject.Instance))
            {
                Activities.Controls.Add(ScoreBySubject.Instance);
                ScoreBySubject.Instance.Dock = DockStyle.Fill;
                ScoreBySubject.Instance.BringToFront();
            }
            else ScoreBySubject.Instance.BringToFront();
        }
    }
}
