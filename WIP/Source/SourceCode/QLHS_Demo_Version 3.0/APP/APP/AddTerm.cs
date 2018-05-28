﻿using System;
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
namespace APP
{
    public partial class AddTerm : MaterialSkin.Controls.MaterialForm
    {
        public AddTerm()
        {
            InitializeComponent();
            metroGrid1.VirtualMode = true;
        }

        private void AddTerm_Load(object sender, EventArgs e)
        {
            if (SchoolYear_BUL.Load() == null)
            {
                BtnAdd.Enabled = BtnDelete.Enabled = BtnUpdate.Enabled = false;
            }
            else
            {
                BtnAdd.Enabled = BtnDelete.Enabled = BtnUpdate.Enabled = true;
                ComboBoxSchoolYear.DataSource = SchoolYear_BUL.Load();
                
            }
        }

        private void ComboBoxSchoolYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SchoolYear_BUL.Load() == null) return;
            if (Term_BUL.LoadBySC(ComboBoxSchoolYear.SelectedValue.ToString()) == null)
            {
                BtnDelete.Enabled = BtnUpdate.Enabled = false;
                metroGrid1.DataSource = null;
            }
            else
            {
                BtnDelete.Enabled = BtnUpdate.Enabled = true;
                metroGrid1.DataSource = Term_BUL.LoadBySC(ComboBoxSchoolYear.SelectedValue.ToString());
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (SchoolYear_BUL.Load() == null) return;
            Term_DTO term_DTO = new Term_DTO();
            term_DTO.ID = IDtxt.Text;
            term_DTO.Name = Nametxt.Text;
            term_DTO.SCID = ComboBoxSchoolYear.SelectedValue.ToString();
            if (Term_BUL.Insert(term_DTO))
            {
                metroGrid1.DataSource = Term_BUL.LoadBySC(ComboBoxSchoolYear.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("Kiểm tra lại cơ sở dữ liệu!", "Thông báo!");
            }
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SchoolYear_BUL.Load() == null) return;
            if (Term_BUL.LoadBySC(ComboBoxSchoolYear.SelectedValue.ToString()) == null) return;
            IDtxt.Text = metroGrid1.SelectedRows[0].Cells[0].Value.ToString();
            Nametxt.Text = metroGrid1.SelectedRows[0].Cells[1].Value.ToString();        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (SchoolYear_BUL.Load() == null) return;
            if (Term_BUL.LoadBySC(ComboBoxSchoolYear.SelectedValue.ToString()) == null) return;
            for (int i = 0; i < metroGrid1.SelectedRows.Count; i++)
            {
                if (Term_BUL.Delete(metroGrid1.SelectedRows[i].Cells[0].Value.ToString()))
                {
                    continue;
                }
                else
                {
                    MessageBox.Show("Kiểm tra lại cơ sở dữ liệu!", "Thông báo!");
                    break;
                }
            }
            metroGrid1.DataSource = Term_BUL.LoadBySC(ComboBoxSchoolYear.SelectedValue.ToString());
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (SchoolYear_BUL.Load() == null) return;
            Term_DTO term_DTO = new Term_DTO();
            term_DTO.ID = IDtxt.Text;
            term_DTO.Name = Nametxt.Text;
            term_DTO.SCID = ComboBoxSchoolYear.SelectedValue.ToString();
            if (Term_BUL.Update(term_DTO))
            {
                metroGrid1.DataSource = Term_BUL.LoadBySC(ComboBoxSchoolYear.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("Kiểm tra lại cơ sở dữ liệu!", "Thông báo!");
            }
        }
    }
}
