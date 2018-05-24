using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class Student_DAL
    {
        /// <summary>
        /// ADD STUDENT & INSERT STUDENT INTO A CLASS
        /// </summary>
        /// <returns></returns>
        public static List<Student_DTO> Load()
        {
            string QueryString = string.Format("Select * From HOCSINH where PhanLop = 'Ready'");
            DataTable Dt = DataProvider.dataTableQuery(QueryString);
            if (Dt != null && Dt.Rows.Count > 0)
            {
                List<Student_DTO> ListStudentDTO = new List<Student_DTO>();
                Student_DTO stdDTO;
                for (int i = 0; i < Dt.Rows.Count; i++)
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
                    ListStudentDTO.Add(stdDTO);
                }
                return ListStudentDTO;
            }
            return null;
        }
        /// <summary>
        /// ADD STUDENT
        /// </summary>
        /// <param name="stdDTO"></param>
        /// <returns></returns>
        public static bool Insert(Student_DTO stdDTO)
        {
            string QueryString = string.Format("Insert into HOCSINH(HoTen,NgaySinh,NoiSinh,GioiTinh,DanToc,TonGiao,DiaChi,DienThoai,HoTenCha,NgheNghiepCha,HoTenMe,NgheNghiepMe,PhanLop) Values(N'{0}','{1}',  N'{2}',   N'{3}', N'{4}', N'{5}',N'{6}' ,'{7}',     N'{8}',     N'{9}',   N'{10}',   N'{11}',  '{12}')", stdDTO.Name, stdDTO.Birthday, stdDTO.Birthplace, stdDTO.Sex, stdDTO.National, stdDTO.Religion, stdDTO.Address, stdDTO.Phone, stdDTO.Father, stdDTO.FJob, stdDTO.Mother, stdDTO.MJob, stdDTO.Status);
            bool Result = DataProvider.ExecuteNonQueryMethod(QueryString);
            return Result;
        }
        /// <summary>
        /// ADD STUDENT & INSERT STUDENT INTO A CLASS - TYPE = UPDATE INSERTED
        /// </summary>
        /// <param name="stdDTO"></param>
        /// <returns></returns>
        public static bool Update(Student_DTO stdDTO)
        {
            string QueryString = string.Format("Update HOCSINH set HoTen=N'{0}',NgaySinh='{1}', NoiSinh=N'{2}', GioiTinh=N'{3}', DanToc=N'{4}', TonGiao=N'{5}',DiaChi=N'{6}',DienThoai='{7}', HoTenCha=N'{8}',NgheNghiepCha=N'{9}', HoTenMe=N'{10}', NgheNghiepMe=N'{11}',PhanLop='{12}'" +
                "WHERE MaHocSinh='{13}'",
                stdDTO.Name, stdDTO.Birthday, stdDTO.Birthplace, stdDTO.Sex, stdDTO.National, stdDTO.Religion, stdDTO.Address, stdDTO.Phone, stdDTO.Father, stdDTO.FJob, stdDTO.Mother, stdDTO.MJob, stdDTO.Status, stdDTO.ID);
            bool Result = DataProvider.ExecuteNonQueryMethod(QueryString);
            return Result;
        }
        /// <summary>
        /// ADD STUDENT & SEARCH INFO STUDENT
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static bool Delete(int ID)
        {
            string QueryString = string.Format("Delete From HOCSINH WHERE MaHocSinh='{0}'", ID);
            bool Result = DataProvider.ExecuteNonQueryMethod(QueryString);
            return Result;
        }
        /// <summary>
        /// INSERT STUDENT INTO A CLASS TYPE = CHANGE CLASS
        /// </summary>
        /// <param name="StudentID"></param>
        /// <param name="TermID"></param>
        /// <param name="ClassID"></param>
        /// <returns></returns>
        public static bool ChangeClass(int StudentID, string TermID, string ClassID)
        {
            string QueryString = string.Format("exec USP_ChuyenLop '{0}','{1}','{2}'", TermID, ClassID, StudentID);
            bool Result = DataProvider.ExecuteNonQueryMethod(QueryString);
            return Result;
        }

        public static int CountStudent()
        {
            string QueryString = string.Format("Select Count (*) from HOCSINH");
            return int.Parse(DataProvider.ExecuteScalaMethod(QueryString));
        }
    }
}
