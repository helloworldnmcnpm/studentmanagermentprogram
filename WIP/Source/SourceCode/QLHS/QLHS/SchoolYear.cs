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
    public partial class SchoolYear : UserControl
    {
        private static SchoolYear _instance;
        public static SchoolYear Instance
        {
            get
            {
                if (_instance == null) _instance = new SchoolYear();
                return _instance;
            }   
        }
        List<SchoolYear_DTO> List = new List<SchoolYear_DTO>();
        
        /// <summary>
        /// CheckData
        /// </summary>
        public void Loadlist()
        {
            List = SchoolYear_BUL.Load();
            dataGridView1.DataSource = SchoolYear_BUL.Load();
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
            if (IDtxt.Text == "" || Begintxt.Text == "" || Endtxt.Text == "") return false;
            if (IsNumber(Begintxt.Text) == false || IsNumber(Endtxt.Text) == false) return false;
            if (-Convert.ToInt32(Begintxt.Text) + Convert.ToInt32(Endtxt.Text) != 1) return false;
            return true;
        }
        /// <summary>
        /// FinishCheck
        /// </summary>
        /// 

        public SchoolYear()
        {
            InitializeComponent();
            Loadlist();
        }

        private void SchoolYear_Load(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (!CheckData())
            {
                MessageBox.Show("Nhập sai, yêu cầu bạn đọc kĩ quy định.", "Nhập lại");
                return;
            }
            SchoolYear_DTO SchoolYearDTO = new SchoolYear_DTO();
            SchoolYearDTO.ID = IDtxt.Text;
            SchoolYearDTO.Begin = Convert.ToInt32(Begintxt.Text);
            SchoolYearDTO.End = Convert.ToInt32(Endtxt.Text);
            if (SchoolYear_BUL.Insert(SchoolYearDTO))
            {
                Loadlist();
            }
            else MessageBox.Show("Không thể thêm vào database!", "!Database");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SchoolYear_BUL.Load()==null) return;
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            IDtxt.Text = dr.Cells[0].Value.ToString();
            Begintxt.Text = dr.Cells[1].Value.ToString();
            Endtxt.Text = dr.Cells[2].Value.ToString();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (SchoolYear_BUL.Load() == null) return;
            if (!CheckData())
            {
                MessageBox.Show("Nhập sai, yêu cầu bạn đọc kĩ quy định.", "Nhập lại");
                return;
            }
            SchoolYear_DTO SchoolYearDTO = new SchoolYear_DTO();
            SchoolYearDTO.ID = IDtxt.Text;
            SchoolYearDTO.Begin = Convert.ToInt32(Begintxt.Text);
            SchoolYearDTO.End = Convert.ToInt32(Endtxt.Text);
            if (SchoolYear_BUL.Update(SchoolYearDTO))
            {
                Loadlist();
            }
            else MessageBox.Show("Không thể cập nhật vào database!", "!<Database>");
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (SchoolYear_BUL.Load() == null) return;
            string ID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (SchoolYear_BUL.Delete(ID))
            {
                Loadlist();
            }
            else MessageBox.Show("Xóa thất bại! Cần kiểm tra database!", "X<Database>");
        }
    }
}
