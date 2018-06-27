using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CID;
using DTO;
using BUL;
namespace APP.Login
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        Correct_Input_Data cid = new Correct_Input_Data();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void IDtxt_TextChanged(object sender, EventArgs e)
        {
            if (IDtxt.Text.Length > 16) IDtxt.Text = IDtxt.Text.Remove(16);
            cid.InputString = IDtxt.Text;
            IDtxt.Text = cid.TrueID;
            IDtxt.SelectionStart = IDtxt.Text.Length;
        }

        private void materialSingleLineTextField1_TextChanged(object sender, EventArgs e)
        {
            if (materialSingleLineTextField1.Text.Length > 16) materialSingleLineTextField1.Text = materialSingleLineTextField1.Text.Remove(16); 
            cid.InputString = materialSingleLineTextField1.Text;
            materialSingleLineTextField1.Text = cid.TrueID;
            materialSingleLineTextField1.SelectionStart = materialSingleLineTextField1.Text.Length;
        }
        Login_DTO login_DTO;
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            login_DTO = new Login_DTO();
            login_DTO.Name = IDtxt.Text;
            login_DTO.Password = materialSingleLineTextField1.Text;
            if (Login_BUL.CheckPassword(login_DTO))
            {
                Main main = new Main();
                this.Hide();
                main.ShowDialog();
                this.Close();
            }
        }
    }
}
