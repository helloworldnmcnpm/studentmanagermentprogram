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

namespace APP
{
    public partial class ScoreBoard : MetroFramework.Forms.MetroForm
    {
        public string SchoolYearID { get; set; }
        public string TermID { get; set; }
        public string ClassID { get; set; }
        public int ID { get; set; }
        private Process_DTO ProcessStudent;
        private List<ScoreBySubject_DTO> ListScoreBySubject = new List<ScoreBySubject_DTO>();
        DataTable dt = new DataTable();
        public ScoreBoard()
        {
            InitializeComponent();
            {
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
                    dt.Columns.Add(new DataColumn("Môn", typeof(string)));
                    for (int i = 0; i < typeExam_DTOs.Count; i++)
                    {
                        dt.Columns.Add(new DataColumn(typeExam_DTOs[i].Name, typeof(string)));

                    }
                    metroGrid.DataSource = dt;
                    dt.Columns.Add(new DataColumn("Điểm trung bình", typeof(string)));

                    metroGrid.DataSource = dt;
                }
            }


        }

        private void ScoreBoard_Load(object sender, EventArgs e)
        {
            Student_DTO student_DTO = new Student_DTO();
            student_DTO = Student_BUL.LoadAStudent(ID);
            NameLabel.Text +=" "+ student_DTO.Name;
            ClassLabel.Text += " " + Class_BUL.GetName(ClassID);
            TermLabel.Text += " " + Term_BUL.GetName(TermID);
            SchoolYearLabel.Text += " " + SchoolYear_BUL.LoadASY(SchoolYearID).Name;
            FinalScore.Text += " " + Math.Round(Process_BUL.GetProcess(ID, TermID, ClassID).TotalScore, 2, MidpointRounding.AwayFromZero);
            if (Subject_BUL.Load() == null) return;
            for (int i = 0; i < Subject_BUL.Load().Count; i++)
            {
                DataRow row = dt.NewRow();
                row["Môn"] = Subject_BUL.Load()[i].Name;
                ProcessStudent = Process_BUL.GetProcess(ID, TermID, ClassID);
                if (ProcessStudent == null) break;
                ListScoreBySubject = ScoreBySubject_BUL.LoadByProcessID(ProcessStudent.ID);
                if (ListScoreBySubject == null) break;
                for (int j = 0; j < ListScoreBySubject.Count; j++)
                {
                    if (ListScoreBySubject[j].SubjectID == Subject_BUL.Load()[i].ID)
                    {
                        row["Điểm trung bình"] = Math.Round(ListScoreBySubject[j].FinalScore, 2, MidpointRounding.AwayFromZero);
                        if (DetailScore_BUL.LoadBySBSID(ListScoreBySubject[j].ID) == null) break;
                        for (int k = 0; k < DetailScore_BUL.LoadBySBSID(ListScoreBySubject[j].ID).Count; k++)
                        {
                            for (int h = 0; h < metroGrid.ColumnCount; h++)
                                if (TypeExam_BUL.GetName(DetailScore_BUL.LoadBySBSID(ListScoreBySubject[i].ID)[k].TypeExamID) == metroGrid.Columns[h].Name.ToString())
                                {
                                    row[h] = row[h].ToString() + " " + DetailScore_BUL.LoadBySBSID(ListScoreBySubject[i].ID)[k].Score.ToString();
                                }
                        }
                    }
                }
                dt.Rows.Add(row);
                dt.AcceptChanges();
                metroGrid.DataSource = dt;
            }
            int count = 0, count1 = 0;
            for (int i = 0; i < metroGrid.RowCount; i++)
            {
                if (Convert.ToDouble(metroGrid.Rows[i].Cells["Điểm trung bình"].Value.ToString()) >= 5)
                {
                    count++;
                }
                else count1++;
            }
            AbovePass.Text += " " + count +" ("+Math.Round((double)count/(double)metroGrid.RowCount,2,MidpointRounding.AwayFromZero)*100+"%)";
            UnderPass.Text += " " + count1 + " (" + Math.Round((double)count1 / (double)metroGrid.RowCount, 2, MidpointRounding.AwayFromZero) * 100 + "%)";
            if (Math.Round(Process_BUL.GetProcess(ID, TermID, ClassID).TotalScore, 2, MidpointRounding.AwayFromZero) >= 8)
            {
                FameLabel.Text += " Học sinh giỏi.";
            }else if (Math.Round(Process_BUL.GetProcess(ID, TermID, ClassID).TotalScore, 2, MidpointRounding.AwayFromZero)<8&& Math.Round(Process_BUL.GetProcess(ID, TermID, ClassID).TotalScore, 2, MidpointRounding.AwayFromZero) >= 6.5)
            {
                FameLabel.Text += " Học sinh khá.";
            }
            else
            {
                if (Math.Round(Process_BUL.GetProcess(ID, TermID, ClassID).TotalScore, 2, MidpointRounding.AwayFromZero)>=5&& Math.Round(Process_BUL.GetProcess(ID, TermID, ClassID).TotalScore, 2, MidpointRounding.AwayFromZero) < 6.5)
                {
                    FameLabel.Text += " Học sinh trung bình.";
                }
                else
                {
                    if (Math.Round(Process_BUL.GetProcess(ID, TermID, ClassID).TotalScore, 2, MidpointRounding.AwayFromZero) < 5)
                    {
                        FameLabel.Text += " Học sinh yếu.";
                    }
                }
            }
        }
        private void copyAlltoClipboard()
        {
            metroGrid.SelectAll();
            DataObject dataObj = metroGrid.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }


        private void BtnExport_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void metroGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
