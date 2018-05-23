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
    public partial class Student : UserControl
    {
        private static Student _instance;
        public static Student Instance
        {
            get
            {
                if (_instance == null) _instance = new Student();
                return _instance;
            }
        }
        public Student()
        {
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void ButtonAddStudent_Click(object sender, EventArgs e)
        {
            if (!Activities.Controls.Contains(AddStudent.Instance))
            {
                Activities.Controls.Add(AddStudent.Instance);
                AddStudent.Instance.Dock = DockStyle.Fill;
                AddStudent.Instance.BringToFront();
            }
            else
            {
                AddStudent.Instance.BringToFront();
                AddStudent.Instance.Refresh();
            }
        }

        private void buttonInsertToClass_Click(object sender, EventArgs e)
        {
            if (!Activities.Controls.Contains(InsertToClass.Instance))
            {
                Activities.Controls.Add(InsertToClass.Instance);
                InsertToClass.Instance.Dock = DockStyle.Fill;
                InsertToClass.Instance.BringToFront();
            }
            else
            {
                InsertToClass.Instance.BringToFront();
                InsertToClass.Instance.Refresh();
            }
        }
    }
}