using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUL;
namespace QLHS
{
    public partial class InfoLogin : Form
    {
        public InfoLogin()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != textBox3.Text) label6.Text = "Nhập lại mật khẩu không khớp!";
            else label6.Text = "Nhập lại mật khẩu đã khớp!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InfoLogin_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            textBox3.UseSystemPasswordChar = true;
            textBox4.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "") return;
            Login_DTO login_DTO = new Login_DTO();
            login_DTO.Name = textBox1.Text;
            login_DTO.Password = textBox2.Text;
            if (Login_BUL.CheckPassword(login_DTO))
            {
                if (Login_BUL.ChangePassword(textBox3.Text, textBox1.Text))
                {
                    MessageBox.Show("Mật khẩu đã thay đổi!", "Thành công!");
                }
            }
            else {
                MessageBox.Show("Sai mật khẩu!", "Sai!");
                return;

            }
        }
    }
}
