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
using System.Text.RegularExpressions;
using System.Globalization;

namespace QLHS
{
    public partial class AddScore : UserControl
    {
        /// <summary>
        /// INITIAL
        /// </summary>
        private static AddScore _instance;
        public static AddScore Instance
        {
            get
            {
                if (_instance == null) _instance = new AddScore();
                return _instance;
            }
        }
        private bool IsNumber(string UncheckString)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(UncheckString);
        }



        /// <summary>
        /// LOAD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        public AddScore()
        {
            InitializeComponent();
        }
        private void AddScore_Load(object sender, EventArgs e)
        {
            
        }




        /// <summary>
        /// BUTTON
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void Add_Click(object sender, EventArgs e)
        {
          
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
          
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            
        }
        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            AddScore_Load(sender, e);
        }




        /// <summary>
        /// EVENT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Classtxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        private void Subjecttxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void Scoretxt_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void SCtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void Termtxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CalculateNow_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}