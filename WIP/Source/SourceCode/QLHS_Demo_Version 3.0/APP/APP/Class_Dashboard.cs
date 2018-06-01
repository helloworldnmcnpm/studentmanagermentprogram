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
namespace APP
{
    public partial class Class_Dashboard : MetroFramework.Forms.MetroForm
    {
        public bool IsSearch { get; set; }
        public string SchoolYearID { get; set; }
        public string TermID { get; set; }
        public Class_Dashboard()
        {
            InitializeComponent();
        }

        private void Class_Dashboard_Load(object sender, EventArgs e)
        {
            if (Class_BUL.LoadBySC(SchoolYearID) == null)
            {
                metroComboBox1.DataSource = null;
                metroGrid.DataSource = null;
                metroComboBox1.Enabled = metroGrid.Enabled = false;
            }
            else
            {
                metroComboBox1.ValueMember = "ID";
                metroComboBox1.DisplayMember = "Name";
                metroComboBox1.DataSource = Class_BUL.LoadBySC(SchoolYearID);
            }
            if (IsSearch == true)
            {
                
            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsSearch == true)
            {

            }
            else
                if (Process_BUL.LoadByClass(metroComboBox1.SelectedValue.ToString(), TermID) != null)
                    metroGrid.DataSource = Process_BUL.LoadByClass(metroComboBox1.SelectedValue.ToString(), TermID);
                else
                {
                    metroGrid.DataSource = null;
                }
        }
    }
}
