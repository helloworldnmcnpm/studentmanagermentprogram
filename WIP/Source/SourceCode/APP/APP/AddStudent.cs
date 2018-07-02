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
    public partial class AddStudent : MaterialSkin.Controls.MaterialForm
    {
        /// <summary>
        /// INITIAL
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        Correct_Input_Data cid=new Correct_Input_Data();





        /// <summary>
        /// LOAD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public AddStudent()
        {
            InitializeComponent();
            if (Student_BUL.Load() == null) metroGrid1.DataSource = null;
            else
            {
                metroGrid1.DataSource = Student_BUL.Load();
            }
            Male.Checked = true;
            BtnAdd.Enabled = false;
            metroGrid1.VirtualMode = true;
        }
        private void AddStudent_Load(object sender, EventArgs e)
        {
            Rule_DTO rule_DTO = Rule_BUL.Load();
            Birthday.MaxDate = new DateTime(DateTime.Now.Year - rule_DTO.MinAge, 12, 31);
            Birthday.MinDate = new DateTime(DateTime.Now.Year - rule_DTO.MaxAge, 1, 1);
            {
                {
                    List<string> ethnics = new List<string>();
                    ethnics.Add("Kinh");
                    ethnics.Add("Tày");
                    ethnics.Add("Thái");
                    ethnics.Add("Mường");
                    ethnics.Add("Khơ Me");
                    ethnics.Add("H'Mông");
                    ethnics.Add("Nùng");
                    ethnics.Add("Hoa");
                    ethnics.Add("Dao");
                    ethnics.Add("Gia Rai");
                    ethnics.Add("Ê Đê");
                    ethnics.Add("Ba Na");
                    ethnics.Add("Xơ Đăng");
                    ethnics.Add("Sán Chay");
                    ethnics.Add("Cơ Ho");
                    ethnics.Add("Chăm");
                    ethnics.Add("Sán Dìu");
                    ethnics.Add("HRê");
                    ethnics.Add("Ra Glai");
                    ethnics.Add("M'Nông");
                    ethnics.Add("X'Tiêng");
                    ethnics.Add("Bru-Vân Kiều");
                    ethnics.Add("Thổ");
                    ethnics.Add("Khơ Mú");
                    ethnics.Add("Cơ Tu");
                    ethnics.Add("Giáy");
                    ethnics.Add("Giẻ Triêng");
                    ethnics.Add("Tà Ôi");
                    ethnics.Add("Mạ");
                    ethnics.Add("Co");
                    ethnics.Add("Chơ Ro");
                    ethnics.Add("Xinh Mun");
                    ethnics.Add("Hà Nhì");
                    ethnics.Add("Chu Ru");
                    ethnics.Add("Lào");
                    ethnics.Add("Kháng");
                    ethnics.Add("La Chí");
                    ethnics.Add("Phù Lá");
                    ethnics.Add("La Hủ");
                    ethnics.Add("La Ha");
                    ethnics.Add("Pà Thẻn");
                    ethnics.Add("Chứt");
                    ethnics.Add("Lự");
                    ethnics.Add("Lô Lô");
                    ethnics.Add("Mảng");
                    ethnics.Add("Cờ Lao");
                    ethnics.Add("Bố Y");
                    ethnics.Add("Cống");
                    ethnics.Add("Ngái");
                    ethnics.Add("Si La");
                    ethnics.Add("Pu Péo");
                    ethnics.Add("Rơ Măm");
                    ethnics.Add("Brâu");
                    ethnics.Add("Ơ Đu");
                    ethnics.Sort();
                    ComboBoxListEthnic.DataSource = ethnics;
                    ComboBoxListEthnic.SelectedItem = "Kinh";
                }
            }

        }


        /// <summary>
        /// BUTTON
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            {
                if (Phonetxt.Text.Length != 10 && Phonetxt.Text.Length != 11)
                {
                    MessageBox.Show("Số điện thoại phải bằng 10 hoặc 11 số!");
                    return;
                }
            }

            if (Nametxt.Text == "" || Addresstxt.Text == "" || Phonetxt.Text == "")
            {
                
                if (Nametxt.Text == "")
                {
                    MessageBox.Show("Tên không được để trống!");
                    Nametxt_TextChanged(sender, e);
                    Nametxt.SelectionStart = Nametxt.Text.Length;
                    return;
                }
                if (Addresstxt.Text == "")
                {
                    MessageBox.Show("Địa chỉ không được để trống!");
                    Addresstxt_TextChanged(sender, e);
                    Addresstxt.SelectionStart = Addresstxt.Text.Length;
                    return;
                }
                if (Phonetxt.Text == "")
                {
                    MessageBox.Show("Số điện thoại không được để trống!");
                    Phonetxt_TextChanged(sender, e);
                    Phonetxt.SelectionStart = Phonetxt.Text.Length;
                    return;
                }
            }
            Student_DTO student_DTO = new Student_DTO();
            student_DTO.Name = Nametxt.Text;
            if (Male.Checked == true) student_DTO.Sex = "Nam";
            if (Female.Checked == true) student_DTO.Sex = "Nữ";
            student_DTO.Birthday = Birthday.Value;
            student_DTO.Address = Addresstxt.Text;
            student_DTO.Birthplace = BirthPlacetxt.Text;
            student_DTO.Phone = Phonetxt.Text;
            student_DTO.Father = Fathernametxt.Text;
            student_DTO.Mother = Mothernametxt.Text;
            student_DTO.FJob = FatherJobtxt.Text;
            student_DTO.MJob = MotherJobtxt.Text;
            student_DTO.Religion = Religiontxt.Text;
            student_DTO.National = ComboBoxListEthnic.SelectedItem.ToString();
            student_DTO.Status = "Ready";
            if (Student_BUL.Insert(student_DTO))
            {
                metroGrid1.DataSource = Student_BUL.Load();
                Btndeletespace_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Kiểm tra lại cơ sở dữ liệu!", "Thông báo!");
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (Student_BUL.Load() == null) return;
            if (Nametxt.Text == "" || Addresstxt.Text == "" || Phonetxt.Text == "")
            {
                Nametxt_TextChanged(sender, e);
                Addresstxt_TextChanged(sender, e);
                Phonetxt_TextChanged(sender, e);
                return;
            }
            Student_DTO student_DTO = new Student_DTO();
            student_DTO.Name = Nametxt.Text;
            if (Male.Checked == true) student_DTO.Sex = "Nam";
            if (Female.Checked == true) student_DTO.Sex = "Nữ";
            student_DTO.Birthday = Birthday.Value;
            student_DTO.Address = Addresstxt.Text;
            student_DTO.Birthplace = BirthPlacetxt.Text;
            student_DTO.Phone = Phonetxt.Text;
            student_DTO.Father = Fathernametxt.Text;
            student_DTO.Mother = Mothernametxt.Text;
            student_DTO.FJob = FatherJobtxt.Text;
            student_DTO.MJob = MotherJobtxt.Text;
            student_DTO.Religion = Religiontxt.Text;
            student_DTO.National = ComboBoxListEthnic.SelectedItem.ToString();
            student_DTO.Status = "Ready";
            student_DTO.ID = Convert.ToInt32(metroGrid1.SelectedRows[0].Cells[1].Value.ToString());
            int index = metroGrid1.SelectedRows[0].Index;
            if (Student_BUL.Update(student_DTO))
            {
                metroGrid1.DataSource = Student_BUL.Load();
                metroGrid1.Rows[0].Selected = false;
                metroGrid1.Rows[index].Selected = true;
                Btndeletespace_Click(sender, e);
                BtnUpdate.Enabled = false;
                MessageBox.Show("Đã cập nhật!", "Thông báo!");
            }
            else
            {
                MessageBox.Show("Kiểm tra lại cơ sở dữ liệu!", "Thông báo!");
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (Student_BUL.Load() == null) return;

            for (int i = 0; i < metroGrid1.SelectedRows.Count; i++)
            {
                int ID = int.Parse(metroGrid1.SelectedRows[i].Cells[1].Value.ToString());
                if (Student_BUL.Delete(ID))
                {
                    continue;
                }
                else
                {
                    MessageBox.Show("Kiểm tra lại cơ sở dữ liệu!", "Thông báo!");
                    break;
                }
            }
            metroGrid1.DataSource = Student_BUL.Load();
        }




        /// <summary>
        /// EVENT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Nametxt_TextChanged(object sender, EventArgs e)
        {
            Nametxt.Text= Nametxt.Text.TrimStart();
            if (Nametxt.Text != "")
            {
                cid.InputString = Nametxt.Text;
                Nametxt.Text = cid.TrueName;
                Nametxt.SelectionStart = Nametxt.Text.Length;
                BtnAdd.Enabled = BtnUpdate.Enabled = true;
            }
            else
            {
                BtnAdd.Enabled = BtnUpdate.Enabled = false;
            }
            
        }
        private void Religiontxt_TextChanged(object sender, EventArgs e)
        {
            Religiontxt.Text = Religiontxt.Text.TrimStart();
            if (Religiontxt.Text != "")
            {
                cid.InputString = Religiontxt.Text;
                Religiontxt.Text = cid.OnlyText;
                Religiontxt.SelectionStart = Religiontxt.Text.Length;
            }

        }
        private void Phonetxt_TextChanged(object sender, EventArgs e)
        {
            if (Phonetxt.Text=="")
            {
                BtnAdd.Enabled = BtnUpdate.Enabled = false;
            }
            else
            {
                BtnAdd.Enabled = BtnUpdate.Enabled = true;
                cid.InputString = Phonetxt.Text;
                Phonetxt.Text = cid.OnlyNumber;
                if (Phonetxt.Text.Length > 11)
                {
                    Phonetxt.Text = Phonetxt.Text.Remove(11);
                }
                else
                {
                    Phonetxt.SelectionStart = Phonetxt.Text.Length;
                }
            }
            
        }
        private void Fathernametxt_TextChanged(object sender, EventArgs e)
        {
            Fathernametxt.Text = Fathernametxt.Text.TrimStart();
            if (Fathernametxt.Text != "")
            {
                cid.InputString = Fathernametxt.Text;
                Fathernametxt.Text = cid.TrueName;
                Fathernametxt.SelectionStart = Fathernametxt.Text.Length;
            }
        }
        private void FatherJobtxt_TextChanged(object sender, EventArgs e)
        {
            FatherJobtxt.Text = FatherJobtxt.Text.TrimStart();
            if (FatherJobtxt.Text != "")
            {
                cid.InputString = FatherJobtxt.Text;
                FatherJobtxt.Text = cid.OnlyText;
                FatherJobtxt.SelectionStart = FatherJobtxt.Text.Length;
            }
        }
        private void Mothernametxt_TextChanged(object sender, EventArgs e)
        {
            Mothernametxt.Text = Mothernametxt.Text.TrimStart();
            if (Mothernametxt.Text != "")
            {
                cid.InputString = Mothernametxt.Text;
                Mothernametxt.Text = cid.TrueName;
                Mothernametxt.SelectionStart = Mothernametxt.Text.Length;
            }
        }
        private void MotherJobtxt_TextChanged(object sender, EventArgs e)
        {
            MotherJobtxt.Text = MotherJobtxt.Text.TrimStart();
            if (MotherJobtxt.Text != "")
            {
                cid.InputString = MotherJobtxt.Text;
                MotherJobtxt.Text = cid.OnlyText;
                MotherJobtxt.SelectionStart = MotherJobtxt.Text.Length;
            }
        }
        private void Birthday_ValueChanged(object sender, EventArgs e)
        {
        }
        private void Addresstxt_TextChanged(object sender, EventArgs e)
        {
            Addresstxt.Text = Addresstxt.Text.TrimStart();
            if (Addresstxt.Text != "")
            {
                cid.InputString = Addresstxt.Text;
                Addresstxt.Text = cid.ValidAddress;
                Addresstxt.SelectionStart = Addresstxt.Text.Length;
                BtnAdd.Enabled = BtnUpdate.Enabled = true;
            }
            else
            {
                BtnAdd.Enabled = BtnUpdate.Enabled = false;

            }
        }
        private void BirthPlacetxt_TextChanged(object sender, EventArgs e)
        {
            BirthPlacetxt.Text = BirthPlacetxt.Text.TrimStart();
            if (BirthPlacetxt.Text != "")
            {
                cid.InputString = BirthPlacetxt.Text;
                BirthPlacetxt.Text = cid.ValidAddress;
                BirthPlacetxt.SelectionStart = BirthPlacetxt.Text.Length;
            }
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Nametxt_Leave(object sender, EventArgs e)
        {
            Nametxt.Text = Nametxt.Text.Trim();
        }

        private void Addresstxt_Leave(object sender, EventArgs e)
        {
            Addresstxt.Text = Addresstxt.Text.Trim();
            if (Addresstxt.Text != "")
                if (Addresstxt.Text[Addresstxt.Text.Length - 1] == ',')
                Addresstxt.Text = Addresstxt.Text.Remove(Addresstxt.Text.Length-1);
        }

        private void Religiontxt_Leave(object sender, EventArgs e)
        {
            Religiontxt.Text = Religiontxt.Text.Trim();
        }

        private void BirthPlacetxt_Leave(object sender, EventArgs e)
        {
            BirthPlacetxt.Text = BirthPlacetxt.Text.Trim();
            if (BirthPlacetxt.Text != "")
                if (BirthPlacetxt.Text[BirthPlacetxt.Text.Length - 1] == ',')
                BirthPlacetxt.Text = BirthPlacetxt.Text.Remove(BirthPlacetxt.Text.Length - 1);

        }

        private void FatherJobtxt_Leave(object sender, EventArgs e)
        {
            FatherJobtxt.Text = FatherJobtxt.Text.Trim();

        }

        private void MotherJobtxt_Leave(object sender, EventArgs e)
        {
            MotherJobtxt.Text = MotherJobtxt.Text.Trim();

        }

        private void Fathernametxt_Leave(object sender, EventArgs e)
        {
            Fathernametxt.Text = Fathernametxt.Text.Trim();

        }

        private void Mothernametxt_Leave(object sender, EventArgs e)
        {
            Mothernametxt.Text = Mothernametxt.Text.Trim();

        }

        private void metroGrid1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (Student_BUL.Load() == null) return;
            if (metroGrid1.SelectedRows.Count == 0) return;
            DataGridViewRow dr = metroGrid1.SelectedRows[0];
            Nametxt.Text = dr.Cells[2].Value.ToString();
            if (dr.Cells[3].Value.ToString() == "Nam") Male.Checked = true;
            else Female.Checked = true;
            Birthday.Value = Convert.ToDateTime(dr.Cells[4].Value.ToString());
            BirthPlacetxt.Text = dr.Cells[5].Value.ToString();
            Addresstxt.Text = dr.Cells[6].Value.ToString();
            Religiontxt.Text = dr.Cells[7].Value.ToString();
            ComboBoxListEthnic.SelectedItem = dr.Cells[8].Value.ToString();
            Phonetxt.Text = dr.Cells[9].Value.ToString();
            Fathernametxt.Text = dr.Cells[10].Value.ToString();
            FatherJobtxt.Text = dr.Cells[11].Value.ToString();
            Mothernametxt.Text = dr.Cells[12].Value.ToString();
            MotherJobtxt.Text = dr.Cells[13].Value.ToString();
        }

        private void Btndeletespace_Click(object sender, EventArgs e)
        {
            Nametxt.Text = Addresstxt.Text = Phonetxt.Text = Religiontxt.Text = FatherJobtxt.Text = Fathernametxt.Text = MotherJobtxt.Text = Mothernametxt.Text
                = BirthPlacetxt.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnGuide_Click(object sender, EventArgs e)
        {
            Tutorial.Tutorial_AddStudent tutorial_AddStudent = new Tutorial.Tutorial_AddStudent();
            tutorial_AddStudent.ShowDialog();
            this.Refresh();
        }
    }
}
