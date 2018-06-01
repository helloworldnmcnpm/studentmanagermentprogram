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
using System.Text.RegularExpressions;
using CID;

namespace APP
{
    public partial class ConfigRule : MaterialSkin.Controls.MaterialForm
    {
        Correct_Input_Data cid = new Correct_Input_Data();
        public ConfigRule()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }
        private void ConfigRule_Load(object sender, EventArgs e)
        {
            List<int> ages = new List<int>();
            List<int> maxages = new List<int>();
            List<int> students = new List<int>();
            for (int i = 16; i < 21; i++) { ages.Add(i);
                maxages.Add(i);
            }
            for (int i = 10; i < 60; i++) students.Add(i);
            ComboBoxMinAge.DataSource = ages;
            ComboBoxMaxAge.DataSource = maxages;
            ComboBoxMaxStudent.DataSource = students;
            if (maxages.Contains(Rule_BUL.Load().MaxAge))
            {
                ComboBoxMaxAge.Text = Rule_BUL.Load().MaxAge.ToString();
            }
            if (ages.Contains(Rule_BUL.Load().MinAge)){
                ComboBoxMinAge.Text = Rule_BUL.Load().MinAge.ToString();
            }
            if (students.Contains(Rule_BUL.Load().MaxStudent))
            {
                ComboBoxMaxStudent.Text = Rule_BUL.Load().MaxStudent.ToString();
            }
            Scoretxt.Text = Rule_BUL.Load().PassedScore.ToString();
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Rule_DTO rule_DTO = new Rule_DTO();
            rule_DTO.MaxAge = int.Parse(ComboBoxMaxAge.SelectedItem.ToString());
            rule_DTO.MinAge = int.Parse(ComboBoxMinAge.SelectedItem.ToString());
            rule_DTO.MaxStudent = int.Parse(ComboBoxMaxStudent.SelectedItem.ToString());
            rule_DTO.PassedScore = double.Parse(Scoretxt.Text);
            if (Rule_BUL.Update(rule_DTO))
            {
                MessageBox.Show("Đã cập nhật!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại, kiểm tra lại kết nối đến cơ sở dữ liệu!", "Thông báo");
            }
        }
        private bool IsNumber(string UncheckString)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(UncheckString);
        }
        private void Scoretxt_TextChanged(object sender, EventArgs e)
        {
            if (Scoretxt.Text == ""||Scoretxt.Text==".")
            {
                BtnUpdate.Enabled = false;
                if (Scoretxt.Text == ".") Scoretxt.Text = "";
            }
            else
            {
                BtnUpdate.Enabled = true;
                cid.InputString = Scoretxt.Text;
                Scoretxt.Text = cid.Real;
                if (Scoretxt.Text != "")
                if (Convert.ToDouble(Scoretxt.Text)>10||Convert.ToDouble(Scoretxt.Text)<0)
                {
                    Scoretxt.Text = "";
                }
                Scoretxt.SelectionStart = Scoretxt.Text.Length;
            }
        }
    }
}
