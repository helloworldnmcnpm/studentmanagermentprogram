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

namespace APP.ReportSchoolYear
{
    public partial class ReportBySchoolYear : MetroFramework.Forms.MetroForm
    {
        private DataTable dtReportByTerm = new DataTable();
        private List<ReportByTerm_DTO> reportByTerm_DTOs;

        private void CreateDtReportByTerm(string TermID,string SchoolYear)
        {
            dtReportByTerm.Clear();
            if (!dtReportByTerm.Columns.Contains("Lớp"))
                dtReportByTerm.Columns.Add(new DataColumn("Lớp", typeof(string)));
            if (!dtReportByTerm.Columns.Contains("Sĩ số"))
                dtReportByTerm.Columns.Add(new DataColumn("Sĩ số", typeof(string)));
            if (!dtReportByTerm.Columns.Contains("Số lượng đạt"))
                dtReportByTerm.Columns.Add(new DataColumn("Số lượng đạt", typeof(string)));
            if (!dtReportByTerm.Columns.Contains("Tỷ lệ đạt (%)"))
                dtReportByTerm.Columns.Add(new DataColumn("Tỷ lệ đạt (%)", typeof(string)));
            if (ReportByTerm_BUL.Load(TermID) != null)
            {
                reportByTerm_DTOs = ReportByTerm_BUL.Load(TermID);
                DataRow dr;
                for (int i = 0; i < reportByTerm_DTOs.Count; i++)
                {
                    dr = dtReportByTerm.NewRow();
                    if (Class_BUL.GetName(reportByTerm_DTOs[i].ClassID) != null && Class_BUL.LoadByID(reportByTerm_DTOs[i].ClassID) != null)
                        dr["Lớp"] = Class_BUL.GetName(reportByTerm_DTOs[i].ClassID);
                    else return;
                    dr["Sĩ số"] = Class_BUL.LoadByID(reportByTerm_DTOs[i].ClassID).Students;
                    dr["Số lượng đạt"] = reportByTerm_DTOs[i].NumberOfPassed;
                    dr["Tỷ lệ đạt (%)"] = reportByTerm_DTOs[i].PercentOfPassed;
                    dtReportByTerm.Rows.Add(dr);
                }
                dtReportByTerm.AcceptChanges();
                metroGrid.DataSource = dtReportByTerm;
            }
            else
            {
                //Tạo report
                List<Process_DTO> process_DTOs;
                if (Class_BUL.LoadBySC(SchoolYear) != null)
                { 
                    List<Class_DTO> class_DTOs = Class_BUL.LoadBySC(SchoolYear);
                    for (int i = 0; i < class_DTOs.Count; i++)
                    {
                        int count = 0;
                        if (Process_BUL.ListProcessByTermAndClass(TermID, class_DTOs[i].ID) == null) return;
                        process_DTOs = Process_BUL.ListProcessByTermAndClass(TermID, class_DTOs[i].ID);
                        for (int j = 0; j < process_DTOs.Count; j++)
                        {
                            if (process_DTOs[i].TotalScore >= Rule_BUL.Load().PassedScore) count++;
                        }
                        if (ReportByTerm_BUL.Insert(TermID, class_DTOs[i].ID, count, Math.Round((double)count / (double)process_DTOs.Count, 2, MidpointRounding.AwayFromZero)*100))
                        {
                            CreateDtReportByTerm(TermID,SchoolYear);
                        }
                    }
                } else
                    return;
            }
        }
        public ReportBySchoolYear()
        {
            InitializeComponent();
        }

        private void ReportBySchoolYear_Load(object sender, EventArgs e)
        {
            if (SchoolYear_BUL.Load() == null)
            {
                ComboboxSchoolYear.Enabled = false;
            }
            else
            {
                ComboboxSchoolYear.Enabled = true;
                ComboboxSchoolYear.DisplayMember = "Name";
                ComboboxSchoolYear.ValueMember = "ID";
                ComboboxSchoolYear.DataSource = SchoolYear_BUL.Load();
            }
        }

        private void ComboboxSchoolYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Term_BUL.LoadBySC(ComboboxSchoolYear.SelectedValue.ToString()) == null)
            {
                ComboboxTerm.DataSource = null;
                ComboboxTerm.Enabled = false;
                return;
            }
            else
            {
                ComboboxTerm.DisplayMember = "Name";
                ComboboxTerm.ValueMember = "ID";
                ComboboxTerm.DataSource = Term_BUL.LoadBySC(ComboboxSchoolYear.SelectedValue.ToString());
                ComboboxTerm.Enabled = true;
            }
        }

        private void ComboboxTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboboxTerm.SelectedValue == null)
            {
                metroGrid.DataSource = null;
                return;
            }
            CreateDtReportByTerm(ComboboxTerm.SelectedValue.ToString(), ComboboxSchoolYear.SelectedValue.ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
