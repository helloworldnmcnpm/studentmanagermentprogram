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
    
    public partial class AddClass : MaterialSkin.Controls.MaterialForm
    {
        Correct_Input_Data cid = new Correct_Input_Data();
        public AddClass()
        {
            InitializeComponent();
            metroGrid1.VirtualMode = true;
        }

        private void AddClass_Load(object sender, EventArgs e)
        {
            if (SchoolYear_BUL.Load() == null || Grade_BUL.Load() == null)
            {
                BtnAdd.Enabled = BtnDelete.Enabled = BtnUpdate.Enabled = false;
            }
            else
            {
                BtnAdd.Enabled = BtnDelete.Enabled = BtnUpdate.Enabled = true;
                ComboBoxSchoolYear.DataSource = SchoolYear_BUL.Load();
                ComboBoxGrade.DataSource = Grade_BUL.Load();
            }
            if (Class_BUL.Load() == null)
            {
                metroGrid1.DataSource = null;
            }
            else
            {
                metroGrid1.DataSource = Class_BUL.Load();
            }

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (SchoolYear_BUL.Load() == null || Grade_BUL.Load() == null)
            {
                return;
            }
            else
            {
                Class_DTO class_DTO = new Class_DTO();
                class_DTO.ID = IDtxt.Text;
                class_DTO.Name = Nametxt.Text;
                class_DTO.GradeID = ComboBoxGrade.SelectedValue.ToString();
                class_DTO.SCID = ComboBoxSchoolYear.SelectedValue.ToString();
                if (class_DTO.ID == "" || class_DTO.Name == "")
                {
                    BtnAdd.Enabled = BtnUpdate.Enabled = false;
                    return;
                }
                if (Class_BUL.Insert(class_DTO))
                {
                    metroGrid1.DataSource = Class_BUL.Load();
                }
                else
                {
                    MessageBox.Show("Kiểm tra lại cơ sở dữ liệu!", "Thông báo!");
                }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (SchoolYear_BUL.Load() == null || Grade_BUL.Load() == null)
            {
                return;
            }
            else
            {
                Class_DTO class_DTO = new Class_DTO();
                class_DTO.ID = IDtxt.Text;
                class_DTO.Name = Nametxt.Text;
                if (class_DTO.ID == "" || class_DTO.Name == "")
                {
                    BtnAdd.Enabled = BtnUpdate.Enabled = false;
                    return;
                }
                class_DTO.GradeID = ComboBoxGrade.SelectedValue.ToString();
                class_DTO.SCID = ComboBoxSchoolYear.SelectedValue.ToString();
                if (Class_BUL.Update(class_DTO))
                {
                    metroGrid1.DataSource = Class_BUL.Load();
                }
                else
                {
                    MessageBox.Show("Kiểm tra lại cơ sở dữ liệu!", "Thông báo!");
                }
            }
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Class_BUL.Load() == null) return;
            if (SchoolYear_BUL.Load() == null || Grade_BUL.Load() == null) return;
            IDtxt.Text = metroGrid1.SelectedRows[0].Cells[0].Value.ToString();
            Nametxt.Text = metroGrid1.SelectedRows[0].Cells[1].Value.ToString();
            ComboBoxGrade.SelectedValue = metroGrid1.SelectedRows[0].Cells[3].Value.ToString();
            ComboBoxSchoolYear.SelectedItem = metroGrid1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (Class_BUL.Load() == null) return;
            for (int i = 0; i < metroGrid1.SelectedRows.Count; i++)
            {
                if (Class_BUL.Delete(metroGrid1.SelectedRows[i].Cells[0].Value.ToString()))
                {
                    continue;
                }
                else
                {
                    MessageBox.Show("Kiểm tra lại cơ sở dữ liệu!", "Thông báo!");
                    break;
                }
            }
            metroGrid1.DataSource = Class_BUL.Load();
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

        private void IDtxt_Leave(object sender, EventArgs e)
        {
            
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

        private void BtnGuide_Click(object sender, EventArgs e)
        {
            Tutorial.Tutorial_AddClass tutorial_AddClass = new Tutorial.Tutorial_AddClass();
            tutorial_AddClass.ShowDialog();
            this.Refresh();
        }
    }
}
