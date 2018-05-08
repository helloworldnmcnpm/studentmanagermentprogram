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
    public partial class AddStudent : UserControl
    {
        private static AddStudent _instance;
        public static AddStudent Instance
        {
            get {
                if (_instance == null) _instance = new AddStudent();
                return _instance;
            }
        }
        public AddStudent()
        {
            InitializeComponent();
        }
        List<Student_DTO> student_DTOs = new List<Student_DTO>();

        private void LoadList() {
            student_DTOs = Student_BUL.Load();
            dataGridView1.DataSource = student_DTOs;
        }

        //CHECK ONLY INTEGER
        private bool IsNumber2(string UncheckedString)
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
            if (!IsNumber2(Phonetxt.Text)) return false;
            if (Nametxt.Text == "" || Addresstxt.Text == "" || (!Male.Checked && !Female.Checked) || Phonetxt.Text == "") return false;
            if ((int.Parse(DateTime.Now.Year.ToString()) - int.Parse(Birthday.Value.Year.ToString()) < Rule_BUL.Load().MinAge) || (int.Parse(DateTime.Now.Year.ToString()) - int.Parse(Birthday.Value.Year.ToString()) > Rule_BUL.Load().MaxAge)) return false;
            return true;
        }
        private void AddStudent_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Student_DTO student_DTO = new Student_DTO();
            student_DTO.Name = Nametxt.Text;
            if (Male.Checked) student_DTO.Sex = "Nam";
            else student_DTO.Sex = "Nữ";
            student_DTO.Birthday = Birthday.Value;
            student_DTO.Address = Addresstxt.Text;
            student_DTO.Birthplace = Birthplacetxt.Text;
            student_DTO.Phone = Phonetxt.Text;
            student_DTO.Father = Fathertxt.Text;
            student_DTO.Mother = Mothertxt.Text;
            student_DTO.FJob = FJobtxt.Text;
            student_DTO.MJob = MJobtxt.Text;
            student_DTO.Religion = Religiontxt.Text;
            student_DTO.National = Religiontxt.Text;
            student_DTO.Status = "Ready";
            if (Student_BUL.Insert(student_DTO))
            {
                LoadList();
            }
            else MessageBox.Show("Không thể thêm vào database!", "!Database");
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (student_DTOs == null) return;
            Student_DTO student_DTO = new Student_DTO();
            student_DTO.Name = Nametxt.Text;
            if (Male.Checked) student_DTO.Sex = "Nam";
            else student_DTO.Sex = "Nữ";
            student_DTO.Birthday = Birthday.Value;
            student_DTO.Address = Addresstxt.Text;
            student_DTO.Birthplace = Birthplacetxt.Text;
            student_DTO.Phone = Phonetxt.Text;
            student_DTO.Father = Fathertxt.Text;
            student_DTO.Mother = Mothertxt.Text;
            student_DTO.FJob = FJobtxt.Text;
            student_DTO.MJob = MJobtxt.Text;
            student_DTO.Status = "Ready";
            student_DTO.Religion = Religiontxt.Text;
            student_DTO.National = Nationaltxt.Text;
            student_DTO.ID =Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            if (Student_BUL.Update(student_DTO))
            {
                LoadList();
            }
            else MessageBox.Show("Không thể cập nhật vào database!", "!<Database>");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (student_DTOs == null) return;
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            Nametxt.Text = dr.Cells[2].Value.ToString();
            if (dr.Cells[3].Value.ToString() == "Nam") Male.Checked = true;
            else Female.Checked = true;
            Birthday.Value = Convert.ToDateTime(dr.Cells[4].Value.ToString());
            Birthplacetxt.Text = dr.Cells[5].Value.ToString();
            Addresstxt.Text = dr.Cells[6].Value.ToString();
            Religiontxt.Text = dr.Cells[7].Value.ToString();
            Nationaltxt.Text = dr.Cells[8].Value.ToString();
            Phonetxt.Text = dr.Cells[9].Value.ToString();
            Fathertxt.Text = dr.Cells[10].Value.ToString();
            FJobtxt.Text = dr.Cells[11].Value.ToString();
            Mothertxt.Text = dr.Cells[12].Value.ToString();
            MJobtxt.Text = dr.Cells[13].Value.ToString();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (student_DTOs == null) return;
            int ID =int.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            if (Student_BUL.Delete(ID))
            {
                LoadList();
            }
            else MessageBox.Show("Xóa thất bại! Cần kiểm tra database!", "X<Database>");
        }


    }
}
