using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DTO;
using BUL;

namespace QLHS
{
    public partial class Rule : UserControl
    {
        //CHECK/CREATE INSTANCE
        private static Rule _instance;
        public static Rule Instance
        {
            get
            {
                if (_instance == null) _instance = new Rule();
                return _instance;
            }
        }
        //CHECK FLOAT/INTEGER
        private bool IsNumber(string UncheckString)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(UncheckString);
        }
        //CHECK ONLY INTEGER
        private bool IsNumber2(string UncheckedString)
        {
            foreach (Char c in UncheckedString)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        /// <summary>
        /// IMPORTANT!!!
        /// </summary>
        ///
        private bool CheckData()
        {
            if (!IsNumber2(MAtxt.Text)||!IsNumber2(MItxt.Text)||!IsNumber2(MStxt.Text)||!IsNumber(PStxt.Text)) return false;
            if (Convert.ToInt32(MAtxt.Text) < Convert.ToInt32(MItxt.Text) ||
                Convert.ToInt32(MAtxt.Text) < 15 || Convert.ToInt32(MAtxt.Text) > 20 ||
                Convert.ToInt32(MItxt.Text) < 15 || Convert.ToInt32(MItxt.Text) > 20) return false;
            if (Convert.ToSingle(PStxt.Text) < 0 || Convert.ToSingle(PStxt.Text) > 10) return false;
            return true;
        }
        
        
        /// <summary>
        /// MAIN
        /// </summary>
        public Rule()
        {
            InitializeComponent();
        }

        

        private void Rule_Load(object sender, EventArgs e)
        {
            Rule_DTO rule_DTO = Rule_BUL.Load();
            MAtxt.Text = rule_DTO.MaxAge.ToString();
            MItxt.Text = rule_DTO.MinAge.ToString();
            MStxt.Text = rule_DTO.MaxStudent.ToString();
            PStxt.Text = rule_DTO.PassedScore.ToString();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                Rule_DTO rule_DTO = new Rule_DTO();
                rule_DTO.MaxAge =Convert.ToInt32(MAtxt.Text);
                rule_DTO.MinAge = Convert.ToInt32(MItxt.Text);
                rule_DTO.MaxStudent = Convert.ToInt32(MStxt.Text);
                rule_DTO.PassedScore = Convert.ToSingle(PStxt.Text);
                if (Rule_BUL.Update(rule_DTO)) Rule_Load(sender, e);
            } else
            {
                MessageBox.Show("Cập nhật quy định thất bại, vui lòng đọc kỹ quy định ở bảng bên cạnh.", "Thất bại!");
            }
        }
    }
}
