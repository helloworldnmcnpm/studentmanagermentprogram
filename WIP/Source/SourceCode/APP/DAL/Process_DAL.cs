using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class Process_DAL
    {
        public static bool InitialProcess(string ClassID, int StudentID,string TermID)
        {
            string QueryString = string.Format("Insert into QUATRINHHOC(MaLop,MaHocSinh,MaHocKy,DiemTBHK) values('{0}','{1}','{2}',0)", ClassID, StudentID, TermID);
            return DataProvider.ExecuteNonQueryMethod(QueryString);
        }
        public static Process_DTO GetProcess(int studentID,string TermID, string ClassID)
        {
            string QueryString = string.Format("Select * from QUATRINHHOC where (MaHocSinh='{0}' and MaHocKy='{1}' and MaLop='{2}')", studentID, TermID,ClassID);
            DataTable dt = DataProvider.dataTableQuery(QueryString);
            if (dt!=null && dt.Rows.Count >0){
                Process_DTO process_DTO = new Process_DTO();
                process_DTO.ID =Convert.ToInt32(dt.Rows[0]["MaQuaTrinhHoc"].ToString());
                process_DTO.StudentID =Convert.ToInt32(dt.Rows[0]["MaHocSinh"].ToString());
                process_DTO.TermID = dt.Rows[0]["MaHocKy"].ToString();
                process_DTO.ClassID = dt.Rows[0]["MaLop"].ToString();
                process_DTO.TotalScore = Convert.ToSingle(dt.Rows[0]["DiemTBHK"].ToString());
                return process_DTO;
            }
            return null;
        }
        public static int CountStudent(string ClassID,string TermID)
        {
            string QueryString = string.Format("Select Count(MaHocSinh) from QUATRINHHOC where MaLop='{0}' and MaHocKy='{1}'", ClassID,TermID);
            return Convert.ToInt32(DataProvider.ExecuteScalaMethod(QueryString));
        }
        /// <summary>
        /// INSERT STUDENT INTO A CLASS
        /// </summary>
        /// <param name="classID"></param>
        /// <returns></returns>
        public static List<Student_DTO> LoadByClass(string classID,string termID)
        {
            string QueryString = string.Format("Select HOCSINH.PhanLop, HOCSINH.MaHocSinh, HOCSINH.HoTen, HOCSINH.NgaySinh, HOCSINH.NoiSinh, HOCSINH.GioiTinh, HOCSINH.DanToc, HOCSINH.TonGiao, HOCSINH.DiaChi, HOCSINH.DienThoai, HOCSINH.HoTenCha, HOCSINH.NgheNghiepCha, HOCSINH.NgheNghiepMe, HOCSINH.HoTenMe from QUATRINHHOC, HOCSINH where(QUATRINHHOC.MaLop = '{0}' and HOCSINH.PhanLop = 'Inserted' and HOCSINH.MaHocSinh = QUATRINHHOC.MaHocSinh and QUATRINHHOC.MaHocKy = '{1}')",classID,termID);
            DataTable Dt = DataProvider.dataTableQuery(QueryString);
            if (Dt!=null&& Dt.Rows.Count > 0)
            {
                List<Student_DTO> student_DTOs = new List<Student_DTO>();
                Student_DTO stdDTO;
                for (int i=0; i < Dt.Rows.Count; i++)
                {
                    stdDTO = new Student_DTO();
                    stdDTO.ID = Convert.ToInt32(Dt.Rows[i]["MaHocSinh"].ToString());
                    stdDTO.Name = Dt.Rows[i]["HoTen"].ToString();
                    stdDTO.Birthday = Convert.ToDateTime(Dt.Rows[i]["NgaySinh"].ToString());
                    stdDTO.Birthplace = Dt.Rows[i]["NoiSinh"].ToString();
                    stdDTO.Sex = Dt.Rows[i]["GioiTinh"].ToString();
                    stdDTO.Religion = Dt.Rows[i]["TonGiao"].ToString();
                    stdDTO.National = Dt.Rows[i]["DanToc"].ToString();
                    stdDTO.Address = Dt.Rows[i]["DiaChi"].ToString();
                    stdDTO.Phone = Dt.Rows[i]["DienThoai"].ToString();
                    stdDTO.Father = Dt.Rows[i]["HoTenCha"].ToString();
                    stdDTO.Mother = Dt.Rows[i]["HoTenMe"].ToString();
                    stdDTO.FJob = Dt.Rows[i]["NgheNghiepCha"].ToString();
                    stdDTO.MJob = Dt.Rows[i]["NgheNghiepMe"].ToString();
                    stdDTO.Status = Dt.Rows[i]["PhanLop"].ToString();
                    student_DTOs.Add(stdDTO);
                }
                return student_DTOs;
            }
            return null;
        }
        public static bool InitialFinalScore(int ProcessID)
        {
            string QueryString = string.Format("Select AVG(DiemTBM) from BANGDIEMMON where MaQuaTrinhHoc='{0}'", ProcessID);
            double Result = double.Parse(DataProvider.ExecuteScalaMethod(QueryString));
            QueryString = string.Format("Update QUATRINHHOC set DiemTBHK='{0}' where MaQuaTrinhHoc='{1}'", Result, ProcessID);
            return DataProvider.ExecuteNonQueryMethod(QueryString);
        }
        public static bool UpdateFinalScore(double Score,int processID)
        {
            string QueryString = string.Format("Update QUATRINHHOC set DiemTBHK='{0}' where MaQuaTrinhHoc='{1}'", Score, processID);
            return DataProvider.ExecuteNonQueryMethod(QueryString);
        }
        public static List<Process_DTO> ListStudentByTerm(string TermID)
        {
            string QueryString = string.Format("Select * from QUATRINHHOC where MaHocKy='{0}'", TermID);
            DataTable dt = DataProvider.dataTableQuery(QueryString);
            List<Process_DTO> process_DTOs = new List<Process_DTO>();
            if (dt.Rows.Count > 0)
            {
                Process_DTO process_DTO;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    process_DTO = new Process_DTO();
                    process_DTO.ID =Convert.ToInt32(dt.Rows[i]["MaQuaTrinhHoc"].ToString());
                    process_DTO.StudentID = Convert.ToInt32(dt.Rows[i]["MaHocSinh"].ToString());
                    process_DTO.TermID = dt.Rows[i]["MaHocKy"].ToString();
                    process_DTO.ClassID = dt.Rows[i]["MaLop"].ToString();
                    process_DTO.TotalScore = Convert.ToDouble(dt.Rows[i]["DiemTBHK"].ToString());
                    process_DTOs.Add(process_DTO);
                }
                return process_DTOs;
            }
            return null;
        }
        public static List<Process_DTO> ListProcessByTermAndClass(string TermID, string ClassID)
        {
            string QueryString = string.Format("Select * from QUATRINHHOC where (MaHocKy='{0}' and MaLop='{1}' )", TermID,ClassID);
            DataTable dt = DataProvider.dataTableQuery(QueryString);
            List<Process_DTO> process_DTOs = new List<Process_DTO>();
            if (dt.Rows.Count > 0)
            {
                Process_DTO process_DTO;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    process_DTO = new Process_DTO();
                    process_DTO.ID = Convert.ToInt32(dt.Rows[i]["MaQuaTrinhHoc"].ToString());
                    process_DTO.StudentID = Convert.ToInt32(dt.Rows[i]["MaHocSinh"].ToString());
                    process_DTO.TermID = dt.Rows[i]["MaHocKy"].ToString();
                    process_DTO.ClassID = dt.Rows[i]["MaLop"].ToString();
                    process_DTO.TotalScore = Convert.ToDouble(dt.Rows[i]["DiemTBHK"].ToString());
                    process_DTOs.Add(process_DTO);
                }
                return process_DTOs;
            }
            return null;
        }
        public static List<Process_DTO> ListProcessByClass(string ClassID)
        {
            string QueryString = string.Format("Select * from QUATRINHHOC where MaLop='{0}' ", ClassID);
            DataTable dt = DataProvider.dataTableQuery(QueryString);
            List<Process_DTO> process_DTOs = new List<Process_DTO>();
            if (dt.Rows.Count > 0)
            {
                Process_DTO process_DTO;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    process_DTO = new Process_DTO();
                    process_DTO.ID = Convert.ToInt32(dt.Rows[i]["MaQuaTrinhHoc"].ToString());
                    process_DTO.StudentID = Convert.ToInt32(dt.Rows[i]["MaHocSinh"].ToString());
                    process_DTO.TermID = dt.Rows[i]["MaHocKy"].ToString();
                    process_DTO.ClassID = dt.Rows[i]["MaLop"].ToString();
                    process_DTO.TotalScore = Convert.ToDouble(dt.Rows[i]["DiemTBHK"].ToString());
                    process_DTOs.Add(process_DTO);
                }
                return process_DTOs;
            }
            return null;
        }
        public static List<Process_DTO> ListProcessByTermAndID(int StudentID,string TermID)
        {

            string QueryString = string.Format("Select * from QUATRINHHOC where (MaHocKy='{0}' and MaHocSinh='{1}') ", TermID,StudentID);
            DataTable dt = DataProvider.dataTableQuery(QueryString);
            List<Process_DTO> process_DTOs = new List<Process_DTO>();
            if (dt.Rows.Count > 0)
            {
                Process_DTO process_DTO;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    process_DTO = new Process_DTO();
                    process_DTO.ID = Convert.ToInt32(dt.Rows[i]["MaQuaTrinhHoc"].ToString());
                    process_DTO.StudentID = Convert.ToInt32(dt.Rows[i]["MaHocSinh"].ToString());
                    process_DTO.TermID = dt.Rows[i]["MaHocKy"].ToString();
                    process_DTO.ClassID = dt.Rows[i]["MaLop"].ToString();
                    process_DTO.TotalScore = Convert.ToDouble(dt.Rows[i]["DiemTBHK"].ToString());
                    process_DTOs.Add(process_DTO);
                }
                return process_DTOs;
            }
            return null;
        }
        public static bool DeleteProcess(int ID)
        {
            string QueryString = string.Format("Delete from QUATRINHHOC where MaQuaTrinhHoc ='{0}'", ID);
            return DataProvider.ExecuteNonQueryMethod(QueryString);
        }
    }
}
