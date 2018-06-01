using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using BUL;
using DTO;
using CID;
namespace APP
{
    public partial class AddGrade : MaterialSkin.Controls.MaterialForm
    {
        Correct_Input_Data cid = new Correct_Input_Data();
        public AddGrade()
        {
            InitializeComponent();
        }

        private void AddGrade_Load(object sender, EventArgs e)
        {
            if(Grade_BUL.Load() == null){
                BtnUpdate.Enabled = BtnDelete.Enabled = false;
            }else{
                BtnUpdate.Enabled = BtnDelete.Enabled = true;
                metroGrid1.DataSource = Grade_BUL.Load();
            }
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Grade_BUL.Load() == null) return;
            IDtxt.Text = metroGrid1.SelectedRows[0].Cells[0].Value.ToString();
            Nametxt.Text = metroGrid1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Grade_DTO grade_DTO = new Grade_DTO();
            grade_DTO.ID = IDtxt.Text;
            grade_DTO.Name = Nametxt.Text;
            if (grade_DTO.Name == "" || grade_DTO.ID == "")
            {
                BtnAdd.Enabled = BtnUpdate.Enabled = false;
                return;
            }
            if (Grade_BUL.Insert(grade_DTO))
            {
                metroGrid1.DataSource = Grade_BUL.Load();
            }
            else
            {
                MessageBox.Show("Kiểm tra lại cơ sở dữ liệu!", "Thông báo!");
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Grade_DTO grade_DTO = new Grade_DTO();
            grade_DTO.ID = IDtxt.Text;
            grade_DTO.Name = Nametxt.Text;
            if (grade_DTO.Name == "" || grade_DTO.ID == "")
            {
                BtnAdd.Enabled = BtnUpdate.Enabled = false;
                return;
            }
            if (Grade_BUL.Update(grade_DTO))
            {
                metroGrid1.DataSource = Grade_BUL.Load();
            }
            else
            {
                MessageBox.Show("Kiểm tra lại cơ sở dữ liệu!", "Thông báo!");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (Grade_BUL.Load() == null) return;
            for (int i = 0; i < metroGrid1.SelectedRows.Count; i++)
            {
                if (Grade_BUL.Delete(metroGrid1.SelectedRows[i].Cells[0].Value.ToString()))
                {
                    continue;
                }
                else
                {
                    MessageBox.Show("Kiểm tra lại cơ sở dữ liệu!", "Thông báo!");
                    break;
                }
            }
            metroGrid1.DataSource = Grade_BUL.Load();
        }

        private void IDtxt_TextChanged(object sender, EventArgs e)
        {
            if (IDtxt.Text == "")
            {
                BtnAdd.Enabled = false;
            }
            else
            {
                BtnAdd.Enabled = true;
                cid.InputString = IDtxt.Text;
                IDtxt.Text = cid.TrueID;
                IDtxt.SelectionStart = IDtxt.Text.Length;
            }
        }

        private void Nametxt_TextChanged(object sender, EventArgs e)
        {
            if (Nametxt.Text == "")
            {
                BtnAdd.Enabled = BtnUpdate.Enabled = false;
            }
            else
            {
                BtnAdd.Enabled = BtnUpdate.Enabled = true;
                cid.InputString = Nametxt.Text;
                Nametxt.Text = cid.UpcaseSpaceAndNumber;
                Nametxt.SelectionStart = Nametxt.Text.Length;
            }
        }

        private void Nametxt_Leave(object sender, EventArgs e)
        {
            Nametxt.Text = Nametxt.Text.Trim();
        }
    }
}
