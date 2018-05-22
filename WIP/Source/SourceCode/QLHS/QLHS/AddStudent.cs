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

        /// <summary>
        /// INITIAL USERCONTROL
        /// </summary>
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
            //Kiem tra so dien thoai
            if (!IsNumber2(Phonetxt.Text)) return false;
            //Kiem tra de trong ten, dia chi, gioi tinh va dien thoai
            if (Nametxt.Text == "" || Addresstxt.Text == "" || (!Male.Checked && !Female.Checked) || Phonetxt.Text == "") return false;
            //Kiemr tra ngay sinh
            if ((int.Parse(DateTime.Now.Year.ToString()) - int.Parse(Birthday.Value.Year.ToString()) < Rule_BUL.Load().MinAge)
                || (int.Parse(DateTime.Now.Year.ToString()) - int.Parse(Birthday.Value.Year.ToString()) > Rule_BUL.Load().MaxAge)) return false;
            return true;
        }
        private void AddStudent_Load(object sender, EventArgs e)
        {
            Male.Checked = true;
            LoadList();
            Rule_DTO rule_DTO = new Rule_DTO();
            rule_DTO = Rule_BUL.Load();
            label15.Text = "Khoảng hợp lệ:"+ (DateTime.Now.Year-rule_DTO.MaxAge)+ '-' + (DateTime.Now.Year-rule_DTO.MinAge);
            label15.Visible = true;
        }
        private bool CheckValidString(string text)
        {
            char[] specialKey = { '\'', '"', '@', '=', '+', '*', '!', '#', '$', '~', '`', '%', '^', '&', '*', '(', ')', '_', '+', '=', '}', '{', ']', '[', '|', ':', ';', '<', '>', '.', '?', '/' };
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] > '0' && text[i] < '9') return false;
                if (specialKey.Contains(text[i])) return false;
            }
            return true;
        }





        /// <summary>
        /// BUTTON CLICK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Click(object sender, EventArgs e)
        {
            if (!CheckData())
            {
                MessageBox.Show("Hãy kiểm tra lại thông tin nhập vào!");
                return;
            }


            Student_DTO student_DTO = new Student_DTO();


      
            student_DTO.Name = Nametxt.Text;
            if (Male.Checked==true) student_DTO.Sex = "Nam";
            if (Female.Checked==true) student_DTO.Sex = "Nữ";
            student_DTO.Birthday = Birthday.Value;
            student_DTO.Address = Addresstxt.Text;
            student_DTO.Birthplace = Birthplacetxt.Text;
            student_DTO.Phone = Phonetxt.Text;
            student_DTO.Father = Fathertxt.Text;
            student_DTO.Mother = Mothertxt.Text;
            student_DTO.FJob = FJobtxt.Text;
            student_DTO.MJob = MJobtxt.Text;
            student_DTO.Religion = Religiontxt.Text;
            student_DTO.National = Nationaltxt.Text;
            student_DTO.Status = "Ready";


            if (Student_BUL.Insert(student_DTO))
            {
                LoadList();
                label25.Text = "Thêm thành công!";
            }
            else MessageBox.Show("Không thể thêm vào database!", "Lỗi DataAccessLayer");
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
                label25.Text = "Cập nhật thành công!";
            }
            else MessageBox.Show("Không thể cập nhật vào database!", "Lỗi DataAccessLayer");
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
                label25.Text = "Xóa thành công!";
            }
            else MessageBox.Show("Cần kiểm tra DataAccessLayer", "Lỗi DataAccessLayer");
        }
        private void ButtonGuide_Click(object sender, EventArgs e)
        {

        }





        /// <summary>
        /// CHECK DATA IN TEXTBOX
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Nametxt_TextChanged(object sender, EventArgs e)
        {
            if (Nametxt.Text=="")
            {
                label14.ForeColor = Color.Red;
                label14.Text = "Tên không được để trống!";
                label14.Visible = true;
            }
            else
            {
                if (!CheckValidString(Nametxt.Text))
                {
                    label14.ForeColor = Color.Red;
                    label14.Text = "Tên không được có ký tự đặc biệt hoặc số!";
                    label14.Visible = true;
                }
                else
                {
                    label14.ForeColor = Color.FromArgb(18, 148, 246);
                    label14.Text = "Tên hợp lệ!";
                    label14.Visible = true;
                }
            }
        }
        private void Birthplacetxt_TextChanged(object sender, EventArgs e)
        {
            if (!CheckValidString(Birthplacetxt.Text))
            {
                label16.ForeColor = Color.Red;
                label16.Text = "Nơi sinh không được có ký tự đặc biệt hoặc số!";
                label16.Visible = true;
            }
            else
            {
                label16.ForeColor = Color.FromArgb(18, 148, 246);
                label16.Text = "Nơi sinh hợp lệ!";
                label16.Visible = true;
            }
        }
        private void Addresstxt_TextChanged(object sender, EventArgs e)
        {
            if (Addresstxt.Text == "")
            {
                label17.ForeColor = Color.Red;
                label17.Text = "Địa chỉ không được để trống!";
                label17.Visible = true;
            }
            else
            {
                if (!CheckValidString(Addresstxt.Text))
                {
                    label17.ForeColor = Color.Red;
                    label17.Text = "Địa chỉ không được có ký tự đặc biệt hoặc số!";
                    label17.Visible = true;
                }
                else
                {
                    label17.ForeColor = Color.FromArgb(18, 148, 246);
                    label17.Text = "Địa chỉ hợp lệ!";
                    label17.Visible = true;
                }
            }
        }
        private void Nationaltxt_TextChanged(object sender, EventArgs e)
        {
            if (!CheckValidString(Nationaltxt.Text))
            {
                label18.ForeColor = Color.Red;
                label18.Text = "Dân tộc không được có ký tự đặc biệt hoặc số!";
                label18.Visible = true;
            }
            else
            {
                label18.ForeColor = Color.FromArgb(18, 148, 246);
                label18.Text = "Dân tộc hợp lệ!";
                label18.Visible = true;
            }
        }
        private void Religiontxt_TextChanged(object sender, EventArgs e)
        {
            if (!CheckValidString(Addresstxt.Text))
            {
                label19.ForeColor = Color.Red;
                label19.Text = "Tôn giáo không được có ký tự đặc biệt hoặc số!";
                label19.Visible = true;
            }
            else
            {
                label19.ForeColor = Color.FromArgb(18, 148, 246);
                label19.Text = "Tôn giáo hợp lệ!";
                label19.Visible = true;
            }
        }
        private void Phonetxt_TextChanged(object sender, EventArgs e)
        {
            if (Phonetxt.Text == "")
            {
                label20.ForeColor = Color.Red;
                label20.Text = "Số điện thoại không được để trống!";
                label20.Visible = true;
            }
            else
            {
                if (!IsNumber2(Phonetxt.Text))
                {
                    label20.ForeColor = Color.Red;
                    label20.Text = "Số điện thoại không được chứa ký tự chữ cái!";
                    label20.Visible = true;
                }
                else
                {
                    label20.ForeColor = Color.FromArgb(18, 148, 246);
                    label20.Text = "Số điện thoại hợp lệ!";
                    label20.Visible = true;
                }
            }
        }
        private void Fathertxt_TextChanged(object sender, EventArgs e)
        {
            if (!CheckValidString(Fathertxt.Text))
            {
                label21.ForeColor = Color.Red;
                label21.Text = "Họ tên cha không được có ký tự đặc biệt hoặc số!";
                label21.Visible = true;
            }
            else
            {
                label21.ForeColor = Color.FromArgb(18, 148, 246);
                label21.Text = "Họ tên cha hợp lệ!";
                label21.Visible = true;
            }
        }
        private void FJobtxt_TextChanged(object sender, EventArgs e)
        {
            if (!CheckValidString(FJobtxt.Text))
            {
                label22.ForeColor = Color.Red;
                label22.Text = "Nghề nghiệp cha không được có ký tự đặc biệt hoặc số!";
                label22.Visible = true;
            }
            else
            {
                label22.ForeColor = Color.FromArgb(18, 148, 246);
                label22.Text = "Nghề nghiệp cha hợp lệ!";
                label22.Visible = true;
            }
        }
        private void Mothertxt_TextChanged(object sender, EventArgs e)
        {
            if (!CheckValidString(Mothertxt.Text))
            {
                label23.ForeColor = Color.Red;
                label23.Text = "Họ tên mẹ không được có ký tự đặc biệt hoặc số!";
                label23.Visible = true;
            }
            else
            {
                label23.ForeColor = Color.FromArgb(18, 148, 246);
                label23.Text = "Họ tên mẹ hợp lệ!";
                label23.Visible = true;
            }
        }
        private void MJobtxt_TextChanged(object sender, EventArgs e)
        {
            if (!CheckValidString(MJobtxt.Text))
            {
                label24.ForeColor = Color.Red;
                label24.Text = "Nghề nghiệp mẹ không được có ký tự đặc biệt hoặc số!";
                label24.Visible = true;
            }
            else
            {
                label24.ForeColor = Color.FromArgb(18, 148, 246);
                label24.Text = "Nghề nghiệp mẹ hợp lệ!";
                label24.Visible = true;
            }
        }
        private void Birthday_ValueChanged(object sender, EventArgs e)
        {
            Rule_DTO rule_DTO = new Rule_DTO();
            rule_DTO = Rule_BUL.Load();
            if (Birthday.Value.Year < (DateTime.Now.Year - rule_DTO.MaxAge) || Birthday.Value.Year> (DateTime.Now.Year - rule_DTO.MinAge))
            {
                label15.ForeColor =Color.Red;
            }
            else
            {
                label15.ForeColor = Color.FromArgb(18, 148, 246);
            }
        }
    }
}
