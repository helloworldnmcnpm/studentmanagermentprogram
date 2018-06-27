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
using System.Data.OleDb;
using System.Data.SqlClient;
namespace APP
{
    public partial class AddScore : MaterialSkin.Controls.MaterialForm
    {
        Correct_Input_Data cid = new Correct_Input_Data();
        public AddScore()
        {
            InitializeComponent();
            metroGrid1.VirtualMode = true;
            metroGrid2.VirtualMode = true;
        }

        private void AddScore_Load(object sender, EventArgs e)
        {
            if (SchoolYear_BUL.Load() == null)
            {
                ComboBoxListClass.Enabled = ComboBoxListTerm.Enabled = ComboBoxSchoolYear.Enabled = false;
                ComboBoxListClass.DataSource = ComboBoxListTerm.DataSource = ComboBoxSchoolYear.DataSource = null;
            }
            else
            {
                ComboBoxListClass.Enabled = ComboBoxListTerm.Enabled = ComboBoxSchoolYear.Enabled = true;
                ComboBoxSchoolYear.DataSource = SchoolYear_BUL.Load();
            }
            if (Subject_BUL.Load() == null)
            {
                BtnAdd.Enabled = BtnUpdate.Enabled = BtnDelete.Enabled = false;
                ComboboxSubject.Enabled = false;
                ComboboxSubject.DataSource = null;
            }
            else
            {
                BtnAdd.Enabled = BtnUpdate.Enabled = BtnDelete.Enabled = true;
                ComboboxSubject.Enabled = true;
                ComboboxSubject.DisplayMember = "Name";
                ComboboxSubject.ValueMember = "ID";
                ComboboxSubject.DataSource = Subject_BUL.Load();
            }
            if (TypeExam_BUL.Load() == null)
            {
                BtnAdd.Enabled = BtnUpdate.Enabled = BtnDelete.Enabled = false;
                ComboboxTypeExam.Enabled = false;
                ComboboxTypeExam.DataSource = null;
            }
            else
            {
                BtnAdd.Enabled = BtnUpdate.Enabled = BtnDelete.Enabled = true;
                ComboboxTypeExam.Enabled = true;
                ComboboxTypeExam.DisplayMember = "Name";
                ComboboxTypeExam.ValueMember = "ID";
                ComboboxTypeExam.DataSource = TypeExam_BUL.Load();
            }
        }

        private void ComboBoxSchoolYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Class_BUL.LoadBySC(ComboBoxSchoolYear.SelectedValue.ToString()) == null)
            {
                ComboBoxListClass.DataSource = null;
                ComboBoxListTerm.DataSource = null;
                ComboBoxListTerm.Enabled = false;
                ComboBoxListClass.Enabled = false;
            }
            else
            {
                ComboBoxListTerm.DisplayMember = ComboBoxListClass.DisplayMember = "Name";
                ComboBoxListTerm.ValueMember = ComboBoxListClass.ValueMember = "ID";
                ComboBoxListClass.Enabled = true;
                ComboBoxListTerm.Enabled = true;
                ComboBoxListClass.DataSource = Class_BUL.LoadBySC(ComboBoxSchoolYear.SelectedValue.ToString());
                ComboBoxListTerm.DataSource = Term_BUL.LoadBySC(ComboBoxSchoolYear.SelectedValue.ToString());
            }
        }
        private void ComboBoxListClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxListTerm.DataSource == null || ComboBoxListClass.DataSource == null)
            {
                metroGrid1.DataSource = null;
                metroGrid1.Enabled = false;
                return;
            }
            else
            {
                metroGrid1.Enabled = true;
                metroGrid1.DataSource = Process_BUL.LoadByClass(ComboBoxListClass.SelectedValue.ToString(), ComboBoxListTerm.SelectedValue.ToString());
            }
        }
        private void ComboBoxListTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxListClass.DataSource == null || ComboBoxListTerm.DataSource == null)
            {
                metroGrid1.DataSource = null;
                metroGrid1.Enabled = false;
                return;
            }
            else
            {
                metroGrid1.Enabled = true;
                metroGrid1.DataSource = Process_BUL.LoadByClass(ComboBoxListClass.SelectedValue.ToString(), ComboBoxListTerm.SelectedValue.ToString());
            }
        }
        private void ComboboxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroGrid1.DataSource == null || metroGrid1.SelectedRows.Count == 0)
            {
                metroGrid2.Enabled = false;
                metroGrid2.DataSource = null;
                return;
            }
            else
            {
                metroGrid2.Enabled = true;
                int ProcessID = Process_BUL.GetProcess(int.Parse(metroGrid1.SelectedRows[0].Cells[0].Value.ToString()), ComboBoxListTerm.SelectedValue.ToString(), ComboBoxListClass.SelectedValue.ToString()).ID;
                string SubjectID = ComboboxSubject.SelectedValue.ToString();
                string ScoreBySubjectID = ScoreBySubject_BUL.GetID(ProcessID, SubjectID);
                metroGrid2.DataSource = DetailScore_BUL.LoadBySBSID(ScoreBySubjectID);
            }
        }
        private void Scoretxt_TextChanged(object sender, EventArgs e)
        {
            if (Scoretxt.Text == ".") Scoretxt.Text = "0.";
            if (Scoretxt.Text == "")
            {
                BtnAdd.Enabled = BtnDelete.Enabled = false;
            }
            else
            {
                BtnAdd.Enabled = BtnDelete.Enabled = true;
                cid.InputString = Scoretxt.Text;
                Scoretxt.Text = cid.Real;
                Scoretxt.SelectionStart = Scoretxt.Text.Length;
                if (double.Parse(Scoretxt.Text) > 10 || double.Parse(Scoretxt.Text) < 0)
                {
                    Scoretxt.Text = "";
                }
            }
        }
        private void metroGrid1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid1.SelectedRows.Count == 0 || ComboboxSubject.DataSource == null)
            {
                metroGrid2.Enabled = false;
                metroGrid2.DataSource = null;
                return;
            }
            else
            {
                metroGrid2.Enabled = true;
                int ProcessID = Process_BUL.GetProcess(int.Parse(metroGrid1.SelectedRows[0].Cells[0].Value.ToString()), ComboBoxListTerm.SelectedValue.ToString(), ComboBoxListClass.SelectedValue.ToString()).ID;
                string SubjectID = ComboboxSubject.SelectedValue.ToString();
                string ScoreBySubjectID = ScoreBySubject_BUL.GetID(ProcessID, SubjectID);
                metroGrid2.DataSource = DetailScore_BUL.LoadBySBSID(ScoreBySubjectID);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (Scoretxt.Text == "")
            {
                BtnAdd.Enabled = BtnUpdate.Enabled = false;
                return;
            }
            int ProcessID = Process_BUL.GetProcess(int.Parse(metroGrid1.SelectedRows[0].Cells[0].Value.ToString()), ComboBoxListTerm.SelectedValue.ToString(), ComboBoxListClass.SelectedValue.ToString()).ID;
            string SubjectID = ComboboxSubject.SelectedValue.ToString();
            string ScoreBySubjectID = ScoreBySubject_BUL.GetID(ProcessID, SubjectID);
            //ADDSCORE
            {
                if (DetailScore_BUL.InsertScoreByStudent(ScoreBySubjectID, ComboboxTypeExam.SelectedValue.ToString(), Convert.ToDouble(Scoretxt.Text)))
                {
                    metroGrid2.DataSource = DetailScore_BUL.LoadBySBSID(ScoreBySubjectID);
                }
                else
                {
                    MessageBox.Show("Kiểm tra lại cơ sở dữ liệu!", "Thông báo!");
                }
            }
            //UPDATE SCORE IN SCOREBYSUBJECT
            {
                int count_index = 0;
                double score = 0;
                for (int i = 0; i < metroGrid2.RowCount; i++)
                {
                    int index = TypeExam_BUL.GetIndex(metroGrid2.Rows[i].Cells[0].Value.ToString());
                    score += Convert.ToDouble(metroGrid2.Rows[i].Cells[2].Value.ToString()) * index;
                    count_index += index;
                }
                if (ScoreBySubject_BUL.UpdateScore(ScoreBySubjectID, score / count_index))
                {
                    //UPDATEPROCESS
                    Process_BUL.InitialFinalScore(ProcessID);
                }
                else
                {
                    MessageBox.Show("Cập nhật bảng điểm môn <Điểm TBM> thất bại!", "Thông báo!");
                }
            }

        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (metroGrid2.DataSource == null || metroGrid2.SelectedRows.Count == 0)
            {
                BtnDelete.Enabled = false;
                return;
            }
            else
            {
                for (int i = 0; i < metroGrid2.SelectedRows.Count; i++)
                {
                    if (DetailScore_BUL.DeleteScoreByStudent(Convert.ToInt32(metroGrid2.SelectedRows[i].Cells[1].Value.ToString())))
                    {

                    }
                    else
                    {
                        MessageBox.Show("Kiểm tra lại cơ sở dữ liệu!", "Thông báo!");
                    }
                }
                int ProcessID = Process_BUL.GetProcess(int.Parse(metroGrid1.SelectedRows[0].Cells[0].Value.ToString()), ComboBoxListTerm.SelectedValue.ToString(), ComboBoxListClass.SelectedValue.ToString()).ID;
                string SubjectID = ComboboxSubject.SelectedValue.ToString();
                string ScoreBySubjectID = ScoreBySubject_BUL.GetID(ProcessID, SubjectID);
                metroGrid2.DataSource = DetailScore_BUL.LoadBySBSID(ScoreBySubjectID);
                {
                    int count_index = 0;
                    double score = 0;
                    if (metroGrid2.RowCount == 0)
                    {
                        if (ScoreBySubject_BUL.UpdateScore(ScoreBySubjectID, 0))
                        {
                            //UPDATEPROCESS
                            Process_BUL.InitialFinalScore(ProcessID);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật bảng điểm môn <Điểm TBM> thất bại!", "Thông báo!");
                        }
                    }
                    else
                    {
                        for (int i = 0; i < metroGrid2.RowCount; i++)
                        {
                            int index = TypeExam_BUL.GetIndex(metroGrid2.Rows[i].Cells[0].Value.ToString());
                            score += Convert.ToDouble(metroGrid2.Rows[i].Cells[2].Value.ToString()) * index;
                            count_index += index;
                        }
                        if (ScoreBySubject_BUL.UpdateScore(ScoreBySubjectID, score / count_index))
                        {
                            //UPDATEPROCESS
                            Process_BUL.InitialFinalScore(ProcessID);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật bảng điểm môn <Điểm TBM> thất bại!", "Thông báo!");
                        }
                    }
                }
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (Scoretxt.Text == "")
            {
                BtnAdd.Enabled = BtnUpdate.Enabled = false;
                return;
            }
            int ProcessID = Process_BUL.GetProcess(int.Parse(metroGrid1.SelectedRows[0].Cells[0].Value.ToString()), ComboBoxListTerm.SelectedValue.ToString(), ComboBoxListClass.SelectedValue.ToString()).ID;
            string SubjectID = ComboboxSubject.SelectedValue.ToString();
            string ScoreBySubjectID = ScoreBySubject_BUL.GetID(ProcessID, SubjectID);
            {
                if (DetailScore_BUL.UpdateScoreByStudent(Convert.ToInt32(metroGrid2.SelectedRows[0].Cells[1].Value.ToString()), Convert.ToDouble(Scoretxt.Text)))
                {
                    metroGrid2.DataSource = DetailScore_BUL.LoadBySBSID(ScoreBySubjectID);
                }
                else
                {
                    MessageBox.Show("Kiểm tra lại cơ sở dữ liệu!", "Thông báo!");
                }
            }
            {
                int count_index = 0;
                double score = 0;
                for (int i = 0; i < metroGrid2.RowCount; i++)
                {
                    int index = TypeExam_BUL.GetIndex(metroGrid2.Rows[i].Cells[0].Value.ToString());
                    score += Convert.ToDouble(metroGrid2.Rows[i].Cells[2].Value.ToString()) * index;
                    count_index += index;
                }
                if (ScoreBySubject_BUL.UpdateScore(ScoreBySubjectID, score / count_index))
                {
                    //UPDATEPROCESS
                    Process_BUL.InitialFinalScore(ProcessID);
                }
                else
                {
                    MessageBox.Show("Cập nhật bảng điểm môn <Điểm TBM> thất bại!", "Thông báo!");
                }
            }

        }

        private void InsertScoreByExcel_Click(object sender, EventArgs e)
        {
            /*
            string ssqltable = "QUANLYHOCSINH";
            //string myexceldataquery =...;
            try
            {
                //create our connection strings
                string sexcelconnectionstring = @"provider=microsoft.jet.oledb.4.0;data source=" + excelfilepath +
                ";extended properties=" + "\"excel 8.0;hdr=yes;\"";
                string ssqlconnectionstring = "server=mydatabaseservername;user
                id = dbuserid; password = dbuserpassword; database = databasename; connection reset = false";
                //execute a query to erase any previous data from our destination table
        string sclearsql = "delete from " + ssqltable;
                sqlconnection sqlconn = new sqlconnection(ssqlconnectionstring);
                sqlcommand sqlcmd = new sqlcommand(sclearsql, sqlconn);
                sqlconn.open();
                sqlcmd.executenonquery();
                sqlconn.close();
                //series of commands to bulk copy data from the excel file into our sql table
                oledbconnection oledbconn = new oledbconnection(sexcelconnectionstring);
                oledbcommand oledbcmd = new oledbcommand(myexceldataquery, oledbconn);
                oledbconn.open();
                oledbdatareader dr = oledbcmd.executereader();
                sqlbulkcopy bulkcopy = new sqlbulkcopy(ssqlconnectionstring);
                bulkcopy.destinationtablename = ssqltable;
                while (dr.read())
                {
                    bulkcopy.writetoserver(dr);
                }

                oledbconn.close();
            }
            catch (exception ex)
            {
                //handle exception
            }
            */
        }
    }
}
