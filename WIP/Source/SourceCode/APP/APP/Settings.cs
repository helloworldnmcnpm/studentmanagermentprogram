using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using CID;
using BUL;
using DTO;
namespace APP
{
    public partial class Settings : MaterialSkin.Controls.MaterialForm
    {
        private Login_DTO Login_DTO = new Login_DTO();
        private Correct_Input_Data cid = new Correct_Input_Data();
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            
        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox4_TextChanged(object sender, EventArgs e)
        {
            if (metroTextBox4.Text == metroTextBox3.Text)
            {
                pictureBox2.Image = APP.Properties.Resources.icons8_Checkmark_24px;
            }
            else
            {
                pictureBox2.Image = APP.Properties.Resources.icons8_Delete_24px;
            }

            if (metroTextBox4.Text.Length > 16) metroTextBox4.Text = metroTextBox4.Text.Remove(16);
            cid.InputString = metroTextBox4.Text;
            metroTextBox4.Text = cid.TrueID;
            metroTextBox4.SelectionStart = metroTextBox4.Text.Length;
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (metroTextBox1.Text.Length > 16) metroTextBox1.Text = metroTextBox1.Text.Remove(16);
            cid.InputString = metroTextBox1.Text;
            metroTextBox1.Text = cid.TrueID;
            metroTextBox1.SelectionStart = metroTextBox1.Text.Length;
        }

        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (metroTextBox2.Text.Length > 16) metroTextBox2.Text = metroTextBox2.Text.Remove(16);
            cid.InputString = metroTextBox2.Text;
            metroTextBox2.Text = cid.TrueID;
            metroTextBox2.SelectionStart = metroTextBox2.Text.Length;
        }

        private void metroTextBox3_TextChanged(object sender, EventArgs e)
        {
            if (metroTextBox3.Text.Length > 16) metroTextBox3.Text = metroTextBox3.Text.Remove(16);
            cid.InputString = metroTextBox3.Text;
            metroTextBox3.Text = cid.TrueID;
            metroTextBox3.SelectionStart = metroTextBox3.Text.Length;

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Login_DTO.Name = metroTextBox1.Text;
            Login_DTO.Password = metroTextBox2.Text;
            if (Login_BUL.CheckPassword(Login_DTO))
            {
                if (metroTextBox3.Text.Length < 4)
                {
                    MessageBox.Show("Mật khẩu phải lớn hơn 4 ký tự!");
                    return;
                }
                if (metroTextBox3.Text != metroTextBox4.Text)
                {
                    MessageBox.Show("Mật khẩu nhập lại không trùng khớp!");
                    return;
                }
                if (Login_BUL.ChangePassword(metroTextBox3.Text, metroTextBox1.Text))
                MessageBox.Show("Đổi mật khẩu thành công!");
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập!");
            }
        }
    }
}

