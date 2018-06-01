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
    public partial class Final : UserControl
    {
        /// <summary>
        /// INITIAL
        /// </summary>
        private static Final _instance;
        public static Final Instance
        {
            get
            {
                if (_instance == null) _instance = new Final();
                return _instance;
            }
        }



        /// <summary>
        /// LOAD
        /// </summary>
        public Final()
        {
            InitializeComponent();
        }
        private void Final_Load(object sender, EventArgs e)
        {
            LabelNumberOfStudent.Text=Student_BUL.CountStudent().ToString();
            LabelNumberOfClass.Text = Class_BUL.Count().ToString();
        }
    }
}
