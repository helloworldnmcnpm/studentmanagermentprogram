using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA2
{
    public partial class AddStudent : UserControl
    {
        private static AddStudent _instance;
        public static AddStudent Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddStudent();
                return _instance;
            }
        }
        public AddStudent()
        {
            InitializeComponent();
        }

        private void Infomation_Enter(object sender, EventArgs e)
        {

        }

        private void Searchtxt_Enter(object sender, EventArgs e)
        {
            Searchtxt.Text = "";
        }

        private void Searchtxt_Leave(object sender, EventArgs e)
        {
            if (Searchtxt.Text=="")
            Searchtxt.Text = "Nhập tên";
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //CodeSearch


            Searchtxt.Text = "Nhập tên";
        }
    }
}
