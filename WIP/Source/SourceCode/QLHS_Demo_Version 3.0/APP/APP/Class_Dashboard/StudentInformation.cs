using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
using DTO;
using CID;
namespace APP
{
    public partial class StudentInformation : MetroFramework.Forms.MetroForm
    {
        public string SchoolYearID { get; set; }
        public string TermID { get; set; }
        public string ClassID { get; set; }
        Correct_Input_Data cid = new Correct_Input_Data();
        public int ID { get; set; }

        public StudentInformation()
        {
            InitializeComponent();
           
        }

        private void StudentInformation_Load(object sender, EventArgs e)
        {
            List<string> ethnics = new List<string>();
            {
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
            }
            {
                ComboBoxListEthnic.DataSource = ethnics;
                Student_DTO student_DTO = Student_BUL.LoadAStudent(ID);
                Nametxt.Text = student_DTO.Name;
                Addresstxt.Text = student_DTO.Address;
                BirthPlacetxt.Text = student_DTO.Birthplace;
                Birthday.Value = student_DTO.Birthday;
                if (student_DTO.Sex == "Nam") Male.Checked = true;
                else Female.Checked = true;
                Phonenumbertxt.Text = student_DTO.Phone;
                FatherNametxt.Text = student_DTO.Father;
                FatherJob.Text = student_DTO.FJob;
                MotherName.Text = student_DTO.Mother;
                MotherJob.Text = student_DTO.MJob;
                ComboBoxListEthnic.Text = student_DTO.National;
                Religiontxt.Text = student_DTO.Religion;
            }
            ComboBoxListEthnic.Enabled = false;
            Birthday.Enabled = false;
            Male.Enabled = Female.Enabled = false;
        }

        private void BtnChangeInformation_Click(object sender, EventArgs e)
        {
            ConfigInformationStudent addStudent = new ConfigInformationStudent();
            addStudent.student_DTO = Student_BUL.LoadAStudent(ID);
            addStudent.Show();
            StudentInformation_Load(sender, e);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnScoreBoard_Click(object sender, EventArgs e)
        {
            ScoreBoard scoreBySubjectStudent = new ScoreBoard();
            scoreBySubjectStudent.SchoolYearID = SchoolYearID;
            scoreBySubjectStudent.TermID = TermID;
            scoreBySubjectStudent.ClassID = ClassID;
            scoreBySubjectStudent.ID = ID;
            scoreBySubjectStudent.ShowDialog();
        }
    }
}
