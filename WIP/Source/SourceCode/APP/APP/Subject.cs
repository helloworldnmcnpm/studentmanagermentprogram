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
using DTO;
using BUL;
using CID;

namespace APP
{
    public partial class Subject : MaterialSkin.Controls.MaterialForm
    {
        Correct_Input_Data cid = new Correct_Input_Data();
        public Subject()
        {
            InitializeComponent();
            metroGrid1.VirtualMode = true;
       
        }

        private void Subject_Load(object sender, EventArgs e)
        {
            if (Subject_BUL.Load() == null) metroGrid1.DataSource = null;
            else
            {
                metroGrid1.DataSource = Subject_BUL.Load();
            }
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Subject_BUL.Load() == null) return;
            IDtxt.Text = metroGrid1.SelectedRows[0].Cells[0].Value.ToString();
            Nametxt.Text = metroGrid1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void BtnAdd_Click(object sender, EventArgs e) 
        {
            if (IDtxt.Text == "" || Nametxt.Text == "") return;
            Subject_DTO subject_DTO = new Subject_DTO();
            subject_DTO.ID = IDtxt.Text;
            subject_DTO.Name = Nametxt.Text;
            if (subject_DTO.ID == "" || subject_DTO.Name == "")
            {
                BtnAdd.Enabled = BtnUpdate.Enabled = false;
                return;
            }
            if (Subject_BUL.Load()!=null)
            for (int i = 0; i < Subject_BUL.Load().Count; i++)
            {
                if (Subject_BUL.Load()[i].Name == subject_DTO.Name)
                {
                    MessageBox.Show("Đã có môn trùng tên!", "Thông báo!");
                    Nametxt.Focus();
                    this.Nametxt.Enter += new EventHandler(Nametxt_TextChanged);
                    BtnAdd.Enabled = false;
                    return;
                }
                if (Subject_BUL.Load()[i].ID == subject_DTO.ID)
                {
                    MessageBox.Show("Đã có môn trùng mã!", "Thông báo!");
                    IDtxt.Focus();
                    this.IDtxt.Enter +=new EventHandler(IDtxt_TextChanged);
                    BtnAdd.Enabled = false;
                    return;
                }
            }
            
            if (Subject_BUL.Insert(subject_DTO))
            {
                metroGrid1.DataSource = Subject_BUL.Load();
                IDtxt.Focus();
            }
            else
            {
                MessageBox.Show("Kiểm tra lại cơ sở dữ liệu!", "Thông báo!");
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (Subject_BUL.Load() == null) return;
            if (IDtxt.Text == "" || Nametxt.Text == "") return;
            Subject_DTO subject_DTO = new Subject_DTO();
            subject_DTO.ID = IDtxt.Text;
            subject_DTO.Name = Nametxt.Text;
            if (subject_DTO.ID == "" || subject_DTO.Name == "")
            {
                BtnAdd.Enabled = BtnUpdate.Enabled = false;
                return;
            }
            if (Subject_BUL.Load() != null)
                for (int i = 0; i < Subject_BUL.Load().Count; i++)
                {
                    if (Subject_BUL.Load()[i].Name == subject_DTO.Name)
                    {
                        MessageBox.Show("Đã có môn trùng tên!", "Thông báo!");
                        Nametxt.Focus();
                        this.Nametxt.Enter += new EventHandler(Nametxt_TextChanged);
                        BtnAdd.Enabled = false;
                        return;
                    }
                }
            if (Subject_BUL.Update(subject_DTO))
            {
                metroGrid1.DataSource = Subject_BUL.Load();
                Nametxt.Focus();
            }
            else
            {
                MessageBox.Show("Kiểm tra lại cơ sở dữ liệu!", "Thông báo!");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (Subject_BUL.Load() == null) return;
            for (int i = 0; i < metroGrid1.SelectedRows.Count; i++)
            {
                if (Subject_BUL.Delete(metroGrid1.SelectedRows[i].Cells[0].Value.ToString()))
                {
                    continue;
                }
                else
                {
                    MessageBox.Show("Kiểm tra lại cơ sở dữ liệu!", "Thông báo!");
                }
            }
            metroGrid1.DataSource = Subject_BUL.Load();
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
