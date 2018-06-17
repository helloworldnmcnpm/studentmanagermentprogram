using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
using DTO;
using CID;
namespace APP
{
    public partial class ConfigInformationStudent : MetroFramework.Forms.MetroForm
    {
        Correct_Input_Data cid = new Correct_Input_Data();
        public Student_DTO student_DTO { get; set; }
        public ConfigInformationStudent()
        {
            InitializeComponent();
        }

        private void ConfigInformationStudent_Load(object sender, EventArgs e)
        {
            List<string> ethnics = new List<string>();
            {
                ethnics.Add("Kinh");
                ethnics.Add("Tày");
                ethnics.Add("Thái");
                ethnics.Add("Mường");
                ethnics.Add("Khơ Me");
                ethnics.Add("H'Mông");
                ethnics.Add("Nùng");
                ethnics.Add("Hoa");
                ethnics.Add("Dao");
                ethnics.Add("Gia Rai");
                ethnics.Add("Ê Đê");
                ethnics.Add("Ba Na");
                ethnics.Add("Xơ Đăng");
                ethnics.Add("Sán Chay");
                ethnics.Add("Cơ Ho");
                ethnics.Add("Chăm");
                ethnics.Add("Sán Dìu");
                ethnics.Add("HRê");
                ethnics.Add("Ra Glai");
                ethnics.Add("M'Nông");
                ethnics.Add("X'Tiêng");
                ethnics.Add("Bru-Vân Kiều");
                ethnics.Add("Thổ");
                ethnics.Add("Khơ Mú");
                ethnics.Add("Cơ Tu");
                ethnics.Add("Giáy");
                ethnics.Add("Giẻ Triêng");
                ethnics.Add("Tà Ôi");
                ethnics.Add("Mạ");
                ethnics.Add("Co");
                ethnics.Add("Chơ Ro");
                ethnics.Add("Xinh Mun");
                ethnics.Add("Hà Nhì");
                ethnics.Add("Chu Ru");
                ethnics.Add("Lào");
                ethnics.Add("Kháng");
                ethnics.Add("La Chí");
                ethnics.Add("Phù Lá");
                ethnics.Add("La Hủ");
                ethnics.Add("La Ha");
                ethnics.Add("Pà Thẻn");
                ethnics.Add("Chứt");
                ethnics.Add("Lự");
                ethnics.Add("Lô Lô");
                ethnics.Add("Mảng");
                ethnics.Add("Cờ Lao");
                ethnics.Add("Bố Y");
                ethnics.Add("Cống");
                ethnics.Add("Ngái");
                ethnics.Add("Si La");
                ethnics.Add("Pu Péo");
                ethnics.Add("Rơ Măm");
                ethnics.Add("Brâu");
                ethnics.Add("Ơ Đu");
            }
            ComboBoxListEthnic.DataSource = ethnics;
            {
                Nametxt.Text = student_DTO.Name;
                Addresstxt.Text = student_DTO.Address;
                BirthPlacetxt.Text = student_DTO.Birthplace;
                Birthday.Value = student_DTO.Birthday;
                if (student_DTO.Sex == "Nam") Male.Checked = true;
                else Female.Checked = true;
                Phonetxt.Text = student_DTO.Phone;
                Fathernametxt.Text = student_DTO.Father;
                FatherJobtxt.Text = student_DTO.FJob;
                Mothernametxt.Text = student_DTO.Mother;
                MotherJobtxt.Text = student_DTO.MJob;
                ComboBoxListEthnic.Text = student_DTO.National;
                Religiontxt.Text = student_DTO.Religion;
            }
        }
        private void Nametxt_TextChanged(object sender, EventArgs e)
        {
            Nametxt.Text = Nametxt.Text.TrimStart();
            if (Nametxt.Text != "")
            {
                cid.InputString = Nametxt.Text;
                Nametxt.Text = cid.TrueName;
                Nametxt.SelectionStart = Nametxt.Text.Length;
                BtnChangeInformation.Enabled = true;
            }
            else
            {
                BtnChangeInformation.Enabled = false;
            }

        }
        private void Religiontxt_TextChanged(object sender, EventArgs e)
        {
            Religiontxt.Text = Religiontxt.Text.TrimStart();
            if (Religiontxt.Text != "")
            {
                cid.InputString = Religiontxt.Text;
                Religiontxt.Text = cid.OnlyText;
                Religiontxt.SelectionStart = Religiontxt.Text.Length;
            }
        }
        private void Phonetxt_TextChanged(object sender, EventArgs e)
        {

            if (Phonetxt.Text == "")
            {
                BtnChangeInformation.Enabled = false;
            }
            else
            {
                BtnChangeInformation.Enabled = true ;
                cid.InputString = Phonetxt.Text;
                Phonetxt.Text = cid.OnlyNumber;
                if (Phonetxt.Text.Length > 11)
                {
                    Phonetxt.Text = Phonetxt.Text.Remove(11);
                }
                else
                {
                    Phonetxt.SelectionStart = Phonetxt.Text.Length;
                }
            }

        }
        private void Fathernametxt_TextChanged(object sender, EventArgs e)
        {
            Fathernametxt.Text = Fathernametxt.Text.TrimStart();
            if (Fathernametxt.Text != "")
            {
                cid.InputString = Fathernametxt.Text;
                Fathernametxt.Text = cid.TrueName;
                Fathernametxt.SelectionStart = Fathernametxt.Text.Length;
            }
        }
        private void FatherJobtxt_TextChanged(object sender, EventArgs e)
        {
            FatherJobtxt.Text = FatherJobtxt.Text.TrimStart();
            if (FatherJobtxt.Text != "")
            {
                cid.InputString = FatherJobtxt.Text;
                FatherJobtxt.Text = cid.OnlyText;
                FatherJobtxt.SelectionStart = FatherJobtxt.Text.Length;
            }
        }
        private void Mothernametxt_TextChanged(object sender, EventArgs e)
        {
            Mothernametxt.Text = Mothernametxt.Text.TrimStart();
            if (Mothernametxt.Text != "")
            {
                cid.InputString = Mothernametxt.Text;
                Mothernametxt.Text = cid.TrueName;
                Mothernametxt.SelectionStart = Mothernametxt.Text.Length;
            }
        }
        private void MotherJobtxt_TextChanged(object sender, EventArgs e)
        {
            MotherJobtxt.Text = MotherJobtxt.Text.TrimStart();
            if (MotherJobtxt.Text != "")
            {
                cid.InputString = MotherJobtxt.Text;
                MotherJobtxt.Text = cid.OnlyText;
                MotherJobtxt.SelectionStart = MotherJobtxt.Text.Length;
            }
        }
        private void Addresstxt_TextChanged(object sender, EventArgs e)
        {
            Addresstxt.Text = Addresstxt.Text.TrimStart();
            if (Addresstxt.Text != "")
            {
                cid.InputString = Addresstxt.Text;
                Addresstxt.Text = cid.ValidAddress;
                Addresstxt.SelectionStart = Addresstxt.Text.Length;
                BtnChangeInformation.Enabled = true;
            }
            else
            {
                BtnChangeInformation.Enabled = false;
            }
        }
        private void BirthPlacetxt_TextChanged(object sender, EventArgs e)
        {
            BirthPlacetxt.Text = BirthPlacetxt.Text.TrimStart();
            if (BirthPlacetxt.Text != "")
            {
                cid.InputString = BirthPlacetxt.Text;
                BirthPlacetxt.Text = cid.ValidAddress;
                BirthPlacetxt.SelectionStart = BirthPlacetxt.Text.Length;
            }
        }
        private void BtnChangeInformation_Click(object sender, EventArgs e)
        {
            if( MessageBox.Show("Bạn xác định muốn thay đổi thông tin học sinh?", "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                student_DTO.Name = Nametxt.Text;
                student_DTO.Address = Addresstxt.Text;
                student_DTO.Birthplace = BirthPlacetxt.Text;
                student_DTO.Birthday = Birthday.Value;
                if (Male.Checked == true)
                {
                    student_DTO.Sex = "Nam";
                }
                else
                {
                    student_DTO.Sex = "Nữ";
                }
                student_DTO.Phone = Phonetxt.Text;
                student_DTO.Father = Fathernametxt.Text;
                student_DTO.Mother = Mothernametxt.Text;
                student_DTO.FJob = FatherJobtxt.Text;
                student_DTO.MJob = MotherJobtxt.Text;
                student_DTO.National = ComboBoxListEthnic.Text;
                student_DTO.Religion = Religiontxt.Text;
                if (Student_BUL.Update(student_DTO))
                {
                    MessageBox.Show("Thay đổi thông tin học sinh thành công!", "Thông báo!");
                }
                else
                {
                    MessageBox.Show("Thay đổi thất bại!", "Thông báo!");
                }
            }

        }

        private void Nametxt_Leave(object sender, EventArgs e)
        {
            Nametxt.Text = Nametxt.Text.Trim();
        }

        private void Addresstxt_Leave(object sender, EventArgs e)
        {
            Addresstxt.Text = Addresstxt.Text.Trim();
            if (Addresstxt.Text != "") 
            if (Addresstxt.Text[Addresstxt.Text.Length - 1] == ',')
                Addresstxt.Text = Addresstxt.Text.Remove(Addresstxt.Text.Length - 1);
        }

        private void Religiontxt_Leave(object sender, EventArgs e)
        {
            Religiontxt.Text = Religiontxt.Text.Trim();
        }

        private void BirthPlacetxt_Leave(object sender, EventArgs e)
        {
            BirthPlacetxt.Text = BirthPlacetxt.Text.Trim();
            if (BirthPlacetxt.Text!="")
            if ( BirthPlacetxt.Text[BirthPlacetxt.Text.Length - 1] == ',')
                BirthPlacetxt.Text = BirthPlacetxt.Text.Remove(BirthPlacetxt.Text.Length - 1);

        }

        private void FatherJobtxt_Leave(object sender, EventArgs e)
        {
            FatherJobtxt.Text = FatherJobtxt.Text.Trim();

        }

        private void MotherJobtxt_Leave(object sender, EventArgs e)
        {
            MotherJobtxt.Text = MotherJobtxt.Text.Trim();

        }

        private void Fathernametxt_Leave(object sender, EventArgs e)
        {
            Fathernametxt.Text = Fathernametxt.Text.Trim();

        }

        private void Mothernametxt_Leave(object sender, EventArgs e)
        {
            Mothernametxt.Text = Mothernametxt.Text.Trim();

        }
    }
}
