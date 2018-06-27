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
namespace APP.Class_Dashboard
{
    public partial class Class_ScoreBoard : MetroFramework.Forms.MetroForm
    {
        public string SchoolYearID { get; set; }
        public string TermID { get; set; }
        public string ClassID { get; set; }
        DataTable dt = new DataTable();
        List<Subject_DTO> subject_DTOs;
        List<Student_DTO> student_DTOs;
        public Class_ScoreBoard()
        {
            InitializeComponent();
        }

        private void Class_ScoreBoard_Load(object sender, EventArgs e)
        {
            subject_DTOs = Subject_BUL.Load();
            student_DTOs = Process_BUL.LoadByClass(ClassID, TermID);
            if (subject_DTOs == null) return;
            if (student_DTOs == null) return;
            dt.Columns.Add(new DataColumn("ID", typeof(Int32)));
            dt.Columns.Add(new DataColumn("Họ và tên", typeof(string)));
            for (int i = 0; i < subject_DTOs.Count; i++)
            {
                dt.Columns.Add(new DataColumn(subject_DTOs[i].Name, typeof(string)));
            }
            dt.Columns.Add(new DataColumn("Điểm trung bình", typeof(string)));
            metroGrid.DataSource = dt;
            for (int i = 0; i < student_DTOs.Count; i++)
            {
                DataRow dataRow = dt.NewRow();
                dataRow["Họ và tên"] = student_DTOs[i].Name;
                dataRow["ID"] = student_DTOs[i].ID;
                int ProcessID = Process_BUL.GetProcess(student_DTOs[i].ID, TermID, ClassID).ID;
                List<ScoreBySubject_DTO> scoreBySubject_DTOs = new List<ScoreBySubject_DTO>();
                scoreBySubject_DTOs = ScoreBySubject_BUL.LoadByProcessID(ProcessID);
                for (int j = 2; j < metroGrid.ColumnCount - 1; j++)
                {
                    string SubjectID = Subject_BUL.GetID(metroGrid.Columns[j].Name);

                    if (scoreBySubject_DTOs!=null)
                    for (int k = 0; k < scoreBySubject_DTOs.Count; k++)
                    {
                        if (scoreBySubject_DTOs[k].SubjectID == SubjectID)
                        {
                            dataRow[j] = scoreBySubject_DTOs[k].FinalScore;
                        }
                    }
                    else
                    {
                        dataRow[j] = 0;
                    }
                }
                dataRow["Điểm trung bình"] = Math.Round(Process_BUL.GetProcess(student_DTOs[i].ID, TermID, ClassID).TotalScore,2,MidpointRounding.AwayFromZero);
                dt.Rows.Add(dataRow);
                dt.AcceptChanges();
                metroGrid.DataSource = dt;
            }
            //Report

            {
                double Max = 0;
                string CurrentName = "";
                
                for (int i = 0; i < metroGrid.RowCount; i++)
                {
                    if (Convert.ToDouble(metroGrid.Rows[i].Cells["Điểm trung bình"].Value.ToString()) > Max)
                    {
                        CurrentName = "";
                        Max = Convert.ToDouble(metroGrid.Rows[i].Cells["Điểm trung bình"].Value.ToString());
                        CurrentName = metroGrid.Rows[i].Cells["Họ và tên"].Value.ToString()+" (Mã số "+ metroGrid.Rows[i].Cells["ID"].Value.ToString()+") - "+ Math.Round(Max,2,MidpointRounding.AwayFromZero)+" điểm.";
                    }
                    else if (Convert.ToDouble(metroGrid.Rows[i].Cells["Điểm trung bình"].Value.ToString()) == Max)
                    {
                        CurrentName +="\n"+ metroGrid.Rows[i].Cells["Họ và tên"].Value.ToString()+ " (Mã số " + metroGrid.Rows[i].Cells["ID"].Value.ToString() + ") - " + Math.Round(Max, 2, MidpointRounding.AwayFromZero) + " điểm.";
                    }
                }
                HighestScoreLabel.Text += CurrentName;

                double Min = Max;
                CurrentName = "";
                for (int i = 0; i < metroGrid.RowCount; i++)
                {
                    if (Convert.ToDouble(metroGrid.Rows[i].Cells["Điểm trung bình"].Value.ToString()) < Min)
                    {
                        CurrentName = "";
                        Min = Convert.ToDouble(metroGrid.Rows[i].Cells["Điểm trung bình"].Value.ToString());
                        CurrentName= metroGrid.Rows[i].Cells["Họ và tên"].Value.ToString() + " (Mã số " + metroGrid.Rows[i].Cells["ID"].Value.ToString() + ") - " + Math.Round(Min, 2, MidpointRounding.AwayFromZero) + " điểm.";
                    }
                    else if(Convert.ToDouble(metroGrid.Rows[i].Cells["Điểm trung bình"].Value.ToString()) == Min)
                    {
                        CurrentName += "\n" + metroGrid.Rows[i].Cells["Họ và tên"].Value.ToString() + " (Mã số " + metroGrid.Rows[i].Cells["ID"].Value.ToString() + ") - " + Math.Round(Min, 2, MidpointRounding.AwayFromZero) + " điểm.";
                    }
                }
                LowestScoreLabel.Text += CurrentName;

                int count=0,count2 =0, count3 =0,count4 =0;
                for (int i = 0; i < metroGrid.RowCount; i++)
                {
                    //good.
                    if (Convert.ToDouble(metroGrid.Rows[i].Cells["Điểm trung bình"].Value.ToString()) >= 8) count++;
                    else
                    //Ime
                        if (Convert.ToDouble(metroGrid.Rows[i].Cells["Điểm trung bình"].Value.ToString()) < 8 && Convert.ToDouble(metroGrid.Rows[i].Cells["Điểm trung bình"].Value.ToString()) >= 6.5) count2++;
                    else
                    //Normal
                        if (Convert.ToDouble(metroGrid.Rows[i].Cells["Điểm trung bình"].Value.ToString()) >= 5 && Convert.ToDouble(metroGrid.Rows[i].Cells["Điểm trung bình"].Value.ToString()) < 6.5) count3++;
                    //Weak
                    else count4++;       
                }
                NumberEx.Text +=" "+ count +" học sinh. ("+Math.Round((double)count/(double)metroGrid.RowCount,2,MidpointRounding.AwayFromZero)*100+"%)";
                NumberIme.Text += " " + count2 + " học sinh. (" + Math.Round((double)count2 / (double)metroGrid.RowCount, 2, MidpointRounding.AwayFromZero) * 100 + "%)";
                NumberNor.Text += " " + count3 + " học sinh. (" + Math.Round((double)count3 / (double)metroGrid.RowCount, 2, MidpointRounding.AwayFromZero) * 100 + "%)";
                NumberWeak.Text += " " + count4 + " học sinh. (" + Math.Round((double)count4 / (double)metroGrid.RowCount, 2, MidpointRounding.AwayFromZero) * 100 + "%)";
                AllStudent.Text += " " + metroGrid.RowCount+" học sinh.";
            }
        }

        private void metroGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
