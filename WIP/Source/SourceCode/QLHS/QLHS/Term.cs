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
    public partial class Term : UserControl
    {
        /// <summary>
        /// INITIAL
        /// </summary>
        private static Term _instance;
        public static Term Instance
        {
            get
            {
                if (_instance == null) _instance = new Term();
                return _instance;
            }
        }
        private bool CheckData()
        {
            if (IDtxt.Text==""||Nametxt.Text==""||SCIDtxt.Text=="") return false;
            return true;
        }
        List<Term_DTO> term_DTOs = new List<Term_DTO>();
        List<SchoolYear_DTO> schoolYear_DTOs = new List<SchoolYear_DTO>();



        /// <summary>
        /// LOAD
        /// </summary>
        private void LoadList()
        {
            term_DTOs = Term_BUL.Load();
            schoolYear_DTOs = SchoolYear_BUL.Load();
            dataGridView1.DataSource = term_DTOs;
            SCIDtxt.DataSource = schoolYear_DTOs;
        }
        public Term()
        {
            InitializeComponent();
        }
        private void Term_Load(object sender, EventArgs e)
        {
            LoadList();
            if (SchoolYear_BUL.Load() == null)
            {
                Add.Enabled = false;
                ButtonUpdate.Enabled = false;
                ButtonDelete.Enabled = false;
                dataGridView1.Enabled = false;
            }
            else
            {
                Add.Enabled = true;
                ButtonUpdate.Enabled = true;
                ButtonDelete.Enabled = true;
                dataGridView1.Enabled = true;
            }
        }




        /// <summary>
        /// BUTTON
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Click(object sender, EventArgs e)
        {
            if (!CheckData())
            {
                MessageBox.Show("Nhập sai, yêu cầu bạn đọc kĩ quy định.", "Nhập lại");
                return;
            }
            Term_DTO term_DTO = new Term_DTO();
            term_DTO.ID = IDtxt.Text;
            term_DTO.Name = Nametxt.Text;
            term_DTO.SCID = SCIDtxt.SelectedValue.ToString();
            if (Term_BUL.Insert(term_DTO))
            {
                LoadList();
            }
            else MessageBox.Show("Không thể thêm vào database!", "!Database");
        }
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {

            if (term_DTOs == null) return;
            if (!CheckData())
            {
                MessageBox.Show("Nhập sai, yêu cầu bạn đọc kĩ quy định.", "Nhập lại");
                return;
            }
            Term_DTO term_DTO = new Term_DTO();
            term_DTO.ID = IDtxt.Text;
            term_DTO.Name = Nametxt.Text;
            term_DTO.SCID = SCIDtxt.SelectedValue.ToString();
            if (Term_BUL.Update(term_DTO))
            {
                LoadList();
            }
            else
            {
                MessageBox.Show("Nhập sai, yêu cầu bạn đọc kĩ quy định.", "Nhập lại");
                return;
            }
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (term_DTOs == null) return;
            string ID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (Term_BUL.Delete(ID))
            {
                LoadList();
            }
            else MessageBox.Show("Xóa thất bại! Cần kiểm tra database!", "X<Database>");

        }




        /// <summary>
        /// EVENT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (term_DTOs == null) return;
            IDtxt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Nametxt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            SCIDtxt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}
