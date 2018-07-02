using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//excel
using System.Data.OleDb;
using System.IO;

using CID;
using DTO;
using BUL;

namespace APP.ImportFromExcel
{
    public partial class Import_From_Excel : MetroFramework.Forms.MetroForm
    {
        Correct_Input_Data cid = new Correct_Input_Data();

        DataTable dt = new DataTable();
        private string fileName;

        public Import_From_Excel()
        {
            InitializeComponent();
        }

        private void Import_From_Excel_Load(object sender, EventArgs e)
        {
            if (SchoolYear_BUL.Load() != null&&Subject_BUL.Load()!=null)
            {
                metroGrid.Enabled = SchoolYearCombo.Enabled = TermCombo.Enabled = ClassCombo.Enabled = true;
                SchoolYearCombo.DataSource = SchoolYear_BUL.Load();
                SubjectCombo.DataSource = Subject_BUL.Load();
                SubjectCombo.DisplayMember = "Name";
                SubjectCombo.ValueMember = "ID";
                SchoolYearCombo.DisplayMember = "Name";
                SchoolYearCombo.ValueMember = "ID";
            }
            else
            {
                metroGrid.Enabled = SchoolYearCombo.Enabled = TermCombo.Enabled = ClassCombo.Enabled = false;
            }
            
        }

        private void Upfile_Click(object sender, EventArgs e)
        {
            metroGrid.DataSource = null;
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();  //create openfileDialog Object
                openFileDialog1.Filter = "XML Files (*.xml; *.xls; *.xlsx; *.xlsm; *.xlsb) |*.xml; *.xls; *.xlsx; *.xlsm; *.xlsb";//open file format define Excel Files(.xls)|*.xls| Excel Files(.xlsx)|*.xlsx| 
                openFileDialog1.FilterIndex = 3;

                openFileDialog1.Multiselect = false;        //not allow multiline selection at the file selection level
                openFileDialog1.Title = "Open Text File-R13";   //define the name of openfileDialog
                openFileDialog1.InitialDirectory = @"Desktop"; //define the initial directory

                if (openFileDialog1.ShowDialog() == DialogResult.OK)        //executing when file open
                {
                    string pathName = openFileDialog1.FileName;
                    fileName = System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                    DataTable tbContainer = new DataTable();
                    string strConn = string.Empty;
                    string sheetName = fileName;

                    FileInfo file = new FileInfo(pathName);
                    if (!file.Exists) { throw new Exception("Error, file doesn't exists!"); }
                    string extension = file.Extension;
                    switch (extension)
                    {
                        case ".xls":
                            strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
                            break;
                        case ".xlsx":
                            strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + pathName + ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=1;'";
                            break;
                        default:
                            strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
                            break;
                    }
                    OleDbConnection cnnxls = new OleDbConnection(strConn);
                    OleDbDataAdapter oda = new OleDbDataAdapter(string.Format("select * from [{0}$]", NameSheet.Text), cnnxls);
                    oda.Fill(tbContainer);
                    metroGrid.DataSource = tbContainer;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
            }

        }

        private void SchoolYearCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Term_BUL.LoadBySC(SchoolYearCombo.SelectedValue.ToString()) == null || Class_BUL.LoadBySC(SchoolYearCombo.SelectedValue.ToString()) == null)
            {
                ClassCombo.Enabled = TermCombo.Enabled = false;
                metroGrid.DataSource = null;
            }
            else
            {
                ClassCombo.Enabled = TermCombo.Enabled = true;
                ClassCombo.DataSource = Class_BUL.LoadBySC(SchoolYearCombo.SelectedValue.ToString());
                ClassCombo.DisplayMember = "Name";
                ClassCombo.ValueMember = "ID";
                TermCombo.DataSource = Term_BUL.LoadBySC(SchoolYearCombo.SelectedValue.ToString());
                TermCombo.DisplayMember = "Name";
                TermCombo.ValueMember = "ID";
            }
        }

        private void BtnExample_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Mã học sinh", typeof(string)));
            dt.Columns.Add(new DataColumn("Tên học sinh", typeof(string)));
            List<TypeExam_DTO> typeExam_DTOs = new List<TypeExam_DTO>();
            typeExam_DTOs = TypeExam_BUL.Load();
            if (typeExam_DTOs == null) return;
            typeExam_DTOs.Sort(delegate (TypeExam_DTO te1, TypeExam_DTO te2)
            {
                return te1.Index.CompareTo(te2.Index);
            });
            if (typeExam_DTOs == null)
            {
                metroGrid.Enabled = false;
                return;
            }
            else
            {
                metroGrid.Enabled = true;
                for (int i = 0; i < typeExam_DTOs.Count; i++)
                {
                    dt.Columns.Add(new DataColumn(typeExam_DTOs[i].Name, typeof(string)));

                }
                metroGrid.DataSource = dt;
            }
        }

        private bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private string DeleteSpacesBeginAndEnd(string s)
        {
            return s.Trim();
        }
        private string DeleteDoubleSpace(string s)
        {
            for (; s.Contains("  ");) s = s.Replace("  ", " ");
            return s;
        }

        private List<double> ScoreFromString(string s)
        {
            List<double> vs = new List<double>();
            s = DeleteSpacesBeginAndEnd(s);
            s = DeleteDoubleSpace(s);
            string[] ar = s.Split(' ');
            for (int i = 0; i < ar.Length; i++)
            {
                vs.Add(Convert.ToDouble(ar[i]));
            }
            return vs;
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            if (metroGrid.DataSource == null)
            {
                MessageBox.Show("Không có dữ liệu!","Lỗi!");
                return;
            }
            else
            {
                for (int i = 0; i < metroGrid.RowCount; i++)
                {
                    if (!IsNumber(metroGrid.Rows[i].Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("Mã học sinh không chính xác!\n Mã học sinh phải là số nguyên!", "Lỗi!");
                        metroGrid.Rows[i].Selected=true;
                        return;
                    }
                }
                //Mã học sinh đúng! Kiểm tra loại kiểm tra trùng
                List<TypeExam_DTO> typeExam_DTOs = new List<TypeExam_DTO>();
                typeExam_DTOs = TypeExam_BUL.Load();
                if (typeExam_DTOs == null) return;
                int count = 0;
                for (int i = 0; i < typeExam_DTOs.Count; i++)
                {
                    for (int j = 2; j < metroGrid.ColumnCount; j++)
                    {
                        if (metroGrid.Columns[j].Name == typeExam_DTOs[i].Name) count++;
                    }
                }
                if (count != typeExam_DTOs.Count)
                {
                    MessageBox.Show("Tên loại kiểm tra không đúng với dữ liệu trong phần mềm. Vui lòng đổi tên lại cho giống!", "Chú ý!");
                    return;
                }
                //thêm điểm từng dòng cho từng học sinh.
                Process_DTO process_DTO;
                for (int i = 0; i < metroGrid.RowCount; i++)
                {
                    //Dòng thứ i. Lấy quá trình học.
                    process_DTO = new Process_DTO();
                    process_DTO = Process_BUL.GetProcess(Convert.ToInt32(metroGrid.Rows[i].Cells[0].Value.ToString()), TermCombo.SelectedValue.ToString(), ClassCombo.SelectedValue.ToString());
                    //Lấy mã bảng điểm.
                    string ScoreBySubjectID;
                    ScoreBySubjectID = ScoreBySubject_BUL.GetID(process_DTO.ID, SubjectCombo.SelectedValue.ToString());
                    //Thêm điểm. Duyệt cột điểm
                    for (int j = 2; j < metroGrid.ColumnCount; j++)
                    {
                        //lấy mã loại kiểm tra.
                        string TypeExamID="";
                        for (int k = 0; k < typeExam_DTOs.Count; k++)
                        {
                            if (metroGrid.Columns[j].Name == typeExam_DTOs[k].Name) { TypeExamID = typeExam_DTOs[k].ID; break; }
                        }
                        //Lấy dữ liệu điểm.
                        string Score = metroGrid.Rows[i].Cells[j].Value.ToString();
                        if (Score == "" || Score == null) continue;
                        List<Double> ListScore = new List<double>();
                        ListScore = ScoreFromString(Score);
                        if (TypeExamID == "") break;
                        //Thêm điểm.
                        for (int l = 0; l < ListScore.Count; l++)
                        {
                            if (!DetailScore_BUL.InsertScoreByStudent(ScoreBySubjectID, TypeExamID, ListScore[l]))
                            {
                                MessageBox.Show("Thêm thất bại!", "Kiểm tra lại Cơ sở dữ liệu!");
                                break;
                            }
                        }
                    }   
                }
                MessageBox.Show("Tiến trình thêm điểm cho học sinh hoàn tất!", "Hoàn tất!");
                metroGrid.DataSource = null;
            }
        }
    }
}
