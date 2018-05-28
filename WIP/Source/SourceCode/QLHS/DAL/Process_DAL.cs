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

        public static int CountStudent(string ClassID)
        {
            string QueryString = string.Format("Select Count(MaHocSinh) from QUATRINHHOC where MaLop='{0}'", ClassID);
            return Convert.ToInt32(DataProvider.ExecuteScalaMethod(QueryString));
        }

        /// <summary>
        /// INSERT STUDENT INTO A CLASS
        /// </summary>
        /// <param name="classID"></param>
        /// <returns></returns>
        public static List<Student_DTO> LoadByClass(string classID,string TermID)
        {
            string QueryString = string.Format("Select HOCSINH.PhanLop, HOCSINH.MaHocSinh, HOCSINH.HoTen, HOCSINH.NgaySinh, HOCSINH.NoiSinh, " +
                "HOCSINH.GioiTinh,HOCSINH.DanToc,HOCSINH.TonGiao,HOCSINH.DiaChi,HOCSINH.DienThoai,HOCSINH.HoTenCha,HOCSINH.NgheNghiepCha, " +
                "HOCSINH.NgheNghiepMe,HOCSINH.HoTenMe from QUATRINHHOC,HOCSINH, where (QUATRINHHOC.MaLop='{0}' and HOCSINH.PhanLop='Inserted' and HOCSINH.MaHocSinh=QUATRINHHOC.MaHocSinh and QUATRINHHOC.MaHocKy='{1}')", classID,TermID);
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
    }
}
