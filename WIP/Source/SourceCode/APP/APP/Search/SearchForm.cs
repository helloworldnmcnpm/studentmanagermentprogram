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
using BUL;
using DTO;

namespace APP.Search
{
    public partial class SearchForm : MetroFramework.Forms.MetroForm
    {
        Correct_Input_Data cid = new Correct_Input_Data();
        public string NameLike;
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            List<Student_DTO> student_DTOs = Search_BUL.SearchStudent(NameLike);
            metroGrid.DataSource = student_DTOs;
            SearchStudent.Text = NameLike;
        }

        private void SearchStudent_TextChanged(object sender, EventArgs e)
        {
            if (SearchStudent.Text == "") pictureBox1.Visible = true;
            else
            {
                pictureBox1.Visible = false;
                cid.InputString = SearchStudent.Text;
                SearchStudent.Text = cid.NoSecialKey;
                SearchStudent.SelectionStart = SearchStudent.Text.Length;
                List<Student_DTO> student_DTOs = Search_BUL.SearchStudent(SearchStudent.Text);
                metroGrid.DataSource = student_DTOs;
            }
        }

        private void SearchStudent_Leave(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;

        }


        private void metroGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
