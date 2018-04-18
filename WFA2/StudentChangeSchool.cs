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
    public partial class StudentChangeSchool : UserControl
    {
        private static StudentChangeSchool _instance;
        public static StudentChangeSchool Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new StudentChangeSchool();               
                return _instance;
            }
         
        }
        public StudentChangeSchool()
        {
            InitializeComponent();
        }

        private void StudentChangeSchool_Load(object sender, EventArgs e)
        {

        }
    }
}
