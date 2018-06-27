using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class Class_DAL
    {
        public static List<Class_DTO> Load()
        {
            string QueryString = @"Select * from LOP";
            DataTable dt = DataProvider.dataTableQuery(QueryString);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<Class_DTO> ListClassDTO = new List<Class_DTO>();
                Class_DTO ClassDTO;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ClassDTO = new Class_DTO();
                    ClassDTO.ID = dt.Rows[i]["MaLop"].ToString();
                    ClassDTO.GradeID = dt.Rows[i]["MaKhoi"].ToString();
                    ClassDTO.SCID = dt.Rows[i]["MaNamHoc"].ToString();
                    ClassDTO.Name = dt.Rows[i]["TenLop"].ToString();
                    ClassDTO.Students = Convert.ToInt32(dt.Rows[i]["SiSo"].ToString());
                    ListClassDTO.Add(ClassDTO);
                }
                return ListClassDTO;
            }
            return null;
        }
        public static bool Delete(string ID)
        {
            string QueryString = string.Format("Delete from LOP Where MaLop='{0}'", ID);
            bool Result = DataProvider.ExecuteNonQueryMethod(QueryString);
            return Result;
        }
        public static bool Update(Class_DTO ClassDTO)
        {
            string QueryString = string.Format("Update LOP set MaKhoi='{0}', MaNamHoc='{1}', TenLop='{2}' where MaLop='{3}'", ClassDTO.GradeID, ClassDTO.SCID, ClassDTO.Name, ClassDTO.ID);
            bool Result = DataProvider.ExecuteNonQueryMethod(QueryString);
            return Result;
        }
        public static bool Insert(Class_DTO ClassDTO)
        {
            string QueryString = String.Format("Insert into LOP(MaLop, TenLop,MaNamHoc,MaKhoi,SiSo) Values('{0}',N'{1}','{2}','{3}','{4}')",
                                                                ClassDTO.ID, ClassDTO.Name, ClassDTO.SCID, ClassDTO.GradeID,ClassDTO.Students);
            bool Result = DataProvider.ExecuteNonQueryMethod(QueryString);
            return Result;
        }
        public static bool UpdateNumberStudent(int i,string classID)
        {
            string QueryString = string.Format("Update LOP set SiSo='{0}' where MaLop='{1}'", i, classID);
            return DataProvider.ExecuteNonQueryMethod(QueryString);
        }
        public static List<Class_DTO> LoadBySC(string ID)
        {
            string QueryString = string.Format("select * from LOP where MaNamHoc='{0}'", ID);
            DataTable dt = DataProvider.dataTableQuery(QueryString);
            if (dt!=null && dt.Rows.Count > 0)
            {
                List<Class_DTO> class_DTOs = new List<Class_DTO>();
                Class_DTO class_DTO;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    class_DTO = new Class_DTO();
                    class_DTO.ID = dt.Rows[i]["MaLop"].ToString();
                    class_DTO.Name = dt.Rows[i]["TenLop"].ToString();
                    class_DTO.SCID = dt.Rows[i]["MaNamHoc"].ToString();
                    class_DTO.GradeID = dt.Rows[i]["MaKhoi"].ToString();
                    class_DTO.Students =Convert.ToInt32(dt.Rows[i]["SiSo"].ToString());
                    class_DTOs.Add(class_DTO);
                }
                return class_DTOs;
            }
            return null;
        }
        public static int Count()
        {
            string QueryString = string.Format("select Count (*) from LOP");
            return int.Parse(DataProvider.ExecuteScalaMethod(QueryString));
        }
        public static int CountBySC(string SchoolYearID)
        {
            string QueryString = string.Format("select Count (*) from LOP where MaNamHoc='{0}'", SchoolYearID);
            return int.Parse(DataProvider.ExecuteScalaMethod(QueryString));
        }
        public static string GetName(string ClassID)
        {
            string QueryString = string.Format("Select TenLop from LOP where MaLop='{0}'", ClassID);
            return DataProvider.ExecuteScalaMethod(QueryString);
        }
    }
}
