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
namespace APP
{
    public partial class SwitchClass : MaterialSkin.Controls.MaterialForm
    {
        public SwitchClass()
        {
            InitializeComponent();
            metroGrid1.VirtualMode = true;
            metroGrid2.VirtualMode = true;
        }
        private void SwitchClass_Load(object sender, EventArgs e)
        {
            if (SchoolYear_BUL.Load() == null)
            {
                BtnSwitch.Enabled = BtnSwitchUp.Enabled = ComboboxTargetSchoolYear.Enabled = ComboBoxClass.Enabled = ComboBoxTerm.Enabled = ComboBoxTargetClass.Enabled = ComboBoxTargetTerm.Enabled =ComboBoxSchoolYear.Enabled= false;
            }
            else
            {
                BtnSwitch.Enabled = BtnSwitchUp.Enabled = ComboboxTargetSchoolYear.Enabled = ComboBoxClass.Enabled = ComboBoxTerm.Enabled = ComboBoxTargetClass.Enabled = ComboBoxTargetTerm.Enabled = ComboBoxSchoolYear.Enabled = true;
                ComboBoxSchoolYear.DataSource = SchoolYear_BUL.Load();
                ComboboxTargetSchoolYear.DataSource = SchoolYear_BUL.Load();
            }
        }
        private void ComboBoxSchoolYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxClass.DataSource = Class_BUL.LoadBySC(ComboBoxSchoolYear.SelectedValue.ToString());
            ComboBoxClass.ValueMember = "ID";
            ComboBoxClass.DisplayMember = "Name";
        }
        private void ComboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxTerm.DataSource = Term_BUL.LoadBySC(ComboBoxSchoolYear.SelectedValue.ToString());
            ComboBoxTerm.ValueMember = "ID";
            ComboBoxTerm.DisplayMember = "Name";
            if (Class_BUL.LoadBySC(ComboBoxSchoolYear.SelectedValue.ToString()) == null && Term_BUL.LoadBySC(ComboBoxSchoolYear.SelectedValue.ToString()) == null)
            {
                metroGrid1.Enabled = BtnSwitch.Enabled = false;
                metroGrid1.DataSource = null;
            }
            else
            {
                metroGrid1.Enabled = BtnSwitch.Enabled = true;
                metroGrid1.DataSource = Process_BUL.LoadByClass(ComboBoxClass.SelectedValue.ToString(), ComboBoxTerm.SelectedValue.ToString());
            }
        }
        private void ComboBoxTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Class_BUL.LoadBySC(ComboBoxSchoolYear.SelectedValue.ToString()) == null && Term_BUL.LoadBySC(ComboBoxSchoolYear.SelectedValue.ToString()) == null)
            {
                metroGrid1.Enabled = BtnSwitch.Enabled = false;
                metroGrid1.DataSource = null;
            }
            else
            {
                metroGrid1.Enabled = BtnSwitch.Enabled = true;
                metroGrid1.DataSource = Process_BUL.LoadByClass(ComboBoxClass.SelectedValue.ToString(), ComboBoxTerm.SelectedValue.ToString());
            }
        }
        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Process_BUL.LoadByClass(ComboBoxClass.SelectedValue.ToString(),ComboBoxTerm.SelectedValue.ToString())==null && metroGrid1.SelectedRows.Count + Process_BUL.CountStudent(ComboBoxClass.SelectedValue.ToString(), ComboBoxTerm.SelectedValue.ToString()) >= Rule_BUL.Load().MaxStudent)
            {
                BtnSwitch.Enabled = false;
                return;
            }
            else
            {
                BtnSwitch.Enabled = true;
            }
        }
        private void metroGrid1_MultiSelectChanged(object sender, EventArgs e)
        {
            if (Process_BUL.LoadByClass(ComboBoxClass.SelectedValue.ToString(), ComboBoxTerm.SelectedValue.ToString()) == null && metroGrid1.SelectedRows.Count + Process_BUL.CountStudent(ComboBoxClass.SelectedValue.ToString(), ComboBoxTerm.SelectedValue.ToString()) >= Rule_BUL.Load().MaxStudent)
            {
                BtnSwitch.Enabled = false;
                return;
            }
            else
            {
                BtnSwitch.Enabled = true;
            }
        }
        private void BtnSwitch_Click(object sender, EventArgs e)
        {
            if (ComboBoxSchoolYear.SelectedValue.ToString() != ComboboxTargetSchoolYear.SelectedValue.ToString())
            {
                MessageBox.Show("Không thể chuyển vì khác năm học!");
                return;
            }
            if (Class_BUL.LoadBySC(ComboBoxSchoolYear.SelectedValue.ToString()) == null || Term_BUL.LoadBySC(ComboBoxSchoolYear.SelectedValue.ToString()) == null) return;
            for (int i = 0; i < metroGrid1.SelectedRows.Count; i++)
            {
                if (!Student_BUL.ChangeClass(int.Parse(metroGrid1.SelectedRows[i].Cells[1].Value.ToString()), ComboBoxTargetTerm.SelectedValue.ToString(), ComboBoxTargetClass.SelectedValue.ToString())){
                    MessageBox.Show("Không thể chuyển học sinh!", "Thông báo!");
                    break;
                }
            }
            metroGrid1.DataSource = Process_BUL.LoadByClass(ComboBoxClass.SelectedValue.ToString(), ComboBoxTerm.SelectedValue.ToString());
            metroGrid2.DataSource = Process_BUL.LoadByClass(ComboBoxTargetClass.SelectedValue.ToString(), ComboBoxTargetTerm.SelectedValue.ToString());
        }
        /// <summary>
        /// TARGET
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboboxTargetSchoolYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxTargetClass.DataSource = Class_BUL.LoadBySC(ComboboxTargetSchoolYear.SelectedValue.ToString());
            ComboBoxTargetClass.ValueMember = "ID";
            ComboBoxTargetClass.DisplayMember = "Name";
        }        
        private void ComboBoxTargetClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxTargetTerm.DataSource = Term_BUL.LoadBySC(ComboboxTargetSchoolYear.SelectedValue.ToString());
            ComboBoxTargetTerm.ValueMember = "ID";
            ComboBoxTargetTerm.DisplayMember = "Name";
            if (Class_BUL.LoadBySC(ComboboxTargetSchoolYear.SelectedValue.ToString()) == null && Term_BUL.LoadBySC(ComboboxTargetSchoolYear.SelectedValue.ToString()) == null)
            {
                metroGrid2.DataSource = null;
                metroGrid2.Enabled = BtnSwitchUp.Enabled = false;
            }
            else
            {
                metroGrid2.Enabled = BtnSwitchUp.Enabled = true;
                metroGrid2.DataSource = Process_BUL.LoadByClass(ComboBoxTargetClass.SelectedValue.ToString(), ComboBoxTargetTerm.SelectedValue.ToString());
            }
        }
        private void ComboBoxTargetTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Class_BUL.LoadBySC(ComboboxTargetSchoolYear.SelectedValue.ToString()) == null && Term_BUL.LoadBySC(ComboboxTargetSchoolYear.SelectedValue.ToString()) == null)
            {
                metroGrid2.Enabled = BtnSwitchUp.Enabled = false;
                metroGrid2.DataSource = null;
            }
            else
            {
                metroGrid2.Enabled = BtnSwitchUp.Enabled = true;
                metroGrid2.DataSource = Process_BUL.LoadByClass(ComboBoxTargetClass.SelectedValue.ToString(), ComboBoxTargetTerm.SelectedValue.ToString());
            }
        }
        private void metroGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Process_BUL.LoadByClass(ComboBoxTargetClass.SelectedValue.ToString(),ComboBoxTargetTerm.SelectedValue.ToString())==null && metroGrid2.SelectedRows.Count + Process_BUL.CountStudent(ComboBoxTargetClass.SelectedValue.ToString(), ComboBoxTargetTerm.SelectedValue.ToString()) >= Rule_BUL.Load().MaxStudent)
            {
                BtnSwitchUp.Enabled = false;
                return;
            }
            else
            {
                BtnSwitchUp.Enabled = true;
            }
        }
        private void BtnSwitchUp_Click(object sender, EventArgs e)
        {
            if (ComboBoxSchoolYear.SelectedValue.ToString()!=ComboboxTargetSchoolYear.SelectedValue.ToString())
            {
                MessageBox.Show("Không thể chuyển vì khác năm học!");
                return;
            }
            if (Class_BUL.LoadBySC(ComboBoxSchoolYear.SelectedValue.ToString()) == null || Term_BUL.LoadBySC(ComboBoxSchoolYear.SelectedValue.ToString()) == null) return;

            for (int i = 0; i < metroGrid2.SelectedRows.Count; i++)
            {
                if(!Student_BUL.ChangeClass(int.Parse(metroGrid2.SelectedRows[i].Cells[1].Value.ToString()), ComboBoxTerm.SelectedValue.ToString(), ComboBoxClass.SelectedValue.ToString()))
                {
                    MessageBox.Show("Không thể chuyển học sinh!", "Thông báo!");
                    break;
                }
            }
            metroGrid1.DataSource = Process_BUL.LoadByClass(ComboBoxClass.SelectedValue.ToString(), ComboBoxTerm.SelectedValue.ToString());
            metroGrid2.DataSource = Process_BUL.LoadByClass(ComboBoxTargetClass.SelectedValue.ToString(), ComboBoxTargetTerm.SelectedValue.ToString());
        }
        private void BtnGuide_Click(object sender, EventArgs e)
        {
            Tutorial.Tutorial_SwitchClass tutorial_SwitchClass = new Tutorial.Tutorial_SwitchClass();
            tutorial_SwitchClass.ShowDialog();
            this.Refresh();
        }
    }
}
