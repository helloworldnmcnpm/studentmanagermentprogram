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
using CID;
using MaterialSkin;
namespace APP
{
    public partial class AddSchoolYear : MaterialSkin.Controls.MaterialForm
    {
        Correct_Input_Data cid = new Correct_Input_Data();
        public AddSchoolYear()
        {
            InitializeComponent();
            metroGrid1.VirtualMode = true;
            SchoolYear_DTO schoolYear_DTO;
            metroGrid1.DataSource = SchoolYear_BUL.Load();
            List<SchoolYear_DTO> schoolYear_DTOs = new List<SchoolYear_DTO>();
          for (int i = 0; i < 3; i++)
            {
                schoolYear_DTO = new SchoolYear_DTO();
                schoolYear_DTO.Begin = System.DateTime.Now.Year+i;
                schoolYear_DTO.End = System.DateTime.Now.Year +i+ 1;
                schoolYear_DTOs.Add(schoolYear_DTO);
            }
            ComboBoxListYear.DataSource = schoolYear_DTOs;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (IDtxt.Text=="") return;

            SchoolYear_DTO schoolYear_DTO = new SchoolYear_DTO();
            schoolYear_DTO.ID = IDtxt.Text;
            schoolYear_DTO.Begin =Convert.ToInt32(ComboBoxListYear.SelectedValue.ToString());
            schoolYear_DTO.End = schoolYear_DTO.Begin + 1;
            if (SchoolYear_BUL.Load()!=null)
            for (int i = 0; i < SchoolYear_BUL.Load().Count; i++)
            {
                if (SchoolYear_BUL.Load()[i].Begin == schoolYear_DTO.Begin)
                {
                    MessageBox.Show("Đã tồn tại năm học này!", "Thông báo!");
                    return;
                }
            }
            if (SchoolYear_BUL.Insert(schoolYear_DTO))
            {
                metroGrid1.DataSource = SchoolYear_BUL.Load();
            }
            else
            {
                MessageBox.Show("Kiểm tra lại kết nối với cơ sở dữ liệu!", "Thông báo");
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (metroGrid1.DataSource == null||SchoolYear_BUL.Load()==null) return;
            else
            {
                for(int i = 0; i < metroGrid1.SelectedRows.Count; i++)
                {
                    if (!SchoolYear_BUL.Delete(metroGrid1.SelectedRows[i].Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("Kiểm tra lại cơ sở dữ liệu!", "Thông báo");
                        break;
                    }
                }
                metroGrid1.DataSource = SchoolYear_BUL.Load();
            }
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid1.DataSource == null) return;
        }

        private void IDtxt_TextChanged(object sender, EventArgs e)
        {
            if (IDtxt.Text == "")
            {
                ButtonAdd.Enabled = ButtonDelete.Enabled = false;
            }
            else
            {
                ButtonAdd.Enabled = ButtonDelete.Enabled = true;
                cid.InputString = IDtxt.Text;
                IDtxt.Text = cid.TrueID;
                IDtxt.SelectionStart = IDtxt.Text.Length;
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddSchoolYear_Load(object sender, EventArgs e)
        {

        }

        private void AddSchoolYear_Activated(object sender, EventArgs e)
        {
            this.BringToFront();
        }
    }
}
