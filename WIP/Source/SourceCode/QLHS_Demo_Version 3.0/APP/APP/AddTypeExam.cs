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
namespace APP
{
    public partial class AddTypeExam : MaterialSkin.Controls.MaterialForm
    {

        Correct_Input_Data cid = new Correct_Input_Data();
        public AddTypeExam()
        {
            InitializeComponent();
            metroGrid1.VirtualMode = true;
        }

        private void AddTypeExam_Load(object sender, EventArgs e)
        {
            if (TypeExam_BUL.Load()==null)
            {
                BtnAdd.Enabled = BtnDelete.Enabled = BtnUpdate.Enabled = false;
            }
            {
                BtnAdd.Enabled = BtnDelete.Enabled = BtnUpdate.Enabled = true;
                metroGrid1.DataSource = TypeExam_BUL.Load();
            }
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

        private void Indextxt_TextChanged(object sender, EventArgs e)
        {
            if (Indextxt.Text == "")
            {
                BtnUpdate.Enabled = BtnAdd.Enabled= false; 
            }
            else
            {
                BtnUpdate.Enabled= BtnAdd.Enabled = true;
                cid.InputString = Indextxt.Text;
                Indextxt.Text = cid.OnlyNumber;
                if (Indextxt.Text != "")
                    if (Convert.ToInt32(Indextxt.Text) > 10 || Convert.ToInt32(Indextxt.Text) < 0)
                    {
                        Indextxt.Text = "";
                    }
                Indextxt.SelectionStart = Indextxt.Text.Length;
            }
        }

        private void Nametxt_Leave(object sender, EventArgs e)
        {
            Nametxt.Text = Nametxt.Text.Trim();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            TypeExam_DTO typeExam_DTO = new TypeExam_DTO();
            typeExam_DTO.ID = IDtxt.Text;
            typeExam_DTO.Name = Nametxt.Text;

            if (typeExam_DTO.ID == "" || typeExam_DTO.Name == "")
            {
                BtnAdd.Enabled = false;
                return;
            }
            if (Indextxt.Text == "") { BtnAdd.Enabled = false; return; }
            typeExam_DTO.Index = int.Parse(Indextxt.Text);

            if (TypeExam_BUL.Load() != null)
            {
                for (int i = 0; i < TypeExam_BUL.Load().Count; i++)
                {
                    if (TypeExam_BUL.Load()[i].ID == typeExam_DTO.ID)
                    {
                        MessageBox.Show("Đã tồn tại mã loại kiểm tra!", "Thông báo!");
                        IDtxt.Focus();
                        return;
                    }
                    if (TypeExam_BUL.Load()[i].Name == typeExam_DTO.Name)
                    {
                        MessageBox.Show("Đã tồn tại tên loại kiểm tra!", "Thông báo!");
                        Nametxt.Focus();
                        return;
                    }
                }
            }
            if (TypeExam_BUL.Insert(typeExam_DTO))
            {
                metroGrid1.DataSource = TypeExam_BUL.Load();
            }
            else
            {
                MessageBox.Show("Kiểm tra cơ sở dữ liệu!","Thông báo!");
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            TypeExam_DTO typeExam_DTO = new TypeExam_DTO();
            typeExam_DTO.ID = IDtxt.Text;
            typeExam_DTO.Name = Nametxt.Text;
            if (typeExam_DTO.ID == "" || typeExam_DTO.Name == "")
            {
                BtnAdd.Enabled = false;
                return;
            }
            if (Indextxt.Text == "") { BtnAdd.Enabled = false; return; }
            typeExam_DTO.Index = int.Parse(Indextxt.Text);
            if (TypeExam_BUL.Update(typeExam_DTO))
            {
                metroGrid1.DataSource = TypeExam_BUL.Load();
            }
            else
            {
                MessageBox.Show("Kiểm tra lại cơ sở dữ liệu!", "Thông báo!");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (metroGrid1.DataSource != null && TypeExam_BUL.Load() != null)
            {
                for (int i = 0; i < metroGrid1.SelectedRows.Count; i++)
                {
                    if (TypeExam_BUL.Delete(metroGrid1.SelectedRows[i].Cells[0].Value.ToString()))
                    {

                    }
                    else
                    {
                        MessageBox.Show("Kiểm tra lại cơ sở dữ liệu!", "Thông báo!");
                        break;
                    }
                }
                metroGrid1.DataSource = TypeExam_BUL.Load();
            }
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TypeExam_BUL.Load() == null) return;
            IDtxt.Text = metroGrid1.SelectedRows[0].Cells[0].Value.ToString();
            Nametxt.Text = metroGrid1.SelectedRows[0].Cells[1].Value.ToString();
            Indextxt.Text = metroGrid1.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}
