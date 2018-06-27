using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class Search_DAL
    {
        public static List<Student_DTO> SearchStudent(string NameLike)
        {
            string QueryString = string.Format("Select * from HOCSINH where (HoTen LIKE N'%{0}%') OR (MaHocSinh LIKE '%{1}%')", NameLike,NameLike);
            DataTable dt = DataProvider.dataTableQuery(QueryString);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<Student_DTO> ListStudentDTO = new List<Student_DTO>();
                Student_DTO stdDTO;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    stdDTO = new Student_DTO();
                    stdDTO.ID = Convert.ToInt32(dt.Rows[i]["MaHocSinh"].ToString());
                    stdDTO.Name = dt.Rows[i]["HoTen"].ToString();
                    stdDTO.Birthday = Convert.ToDateTime(dt.Rows[i]["NgaySinh"].ToString());
                    stdDTO.Birthplace = dt.Rows[i]["NoiSinh"].ToString();
                    stdDTO.Sex = dt.Rows[i]["GioiTinh"].ToString();
                    stdDTO.Religion = dt.Rows[i]["TonGiao"].ToString();
                    stdDTO.National = dt.Rows[i]["DanToc"].ToString();
                    stdDTO.Address = dt.Rows[i]["DiaChi"].ToString();
                    stdDTO.Phone = dt.Rows[i]["DienThoai"].ToString();
                    stdDTO.Father = dt.Rows[i]["HoTenCha"].ToString();
                    stdDTO.Mother = dt.Rows[i]["HoTenMe"].ToString();
                    stdDTO.FJob = dt.Rows[i]["NgheNghiepCha"].ToString();
                    stdDTO.MJob = dt.Rows[i]["NgheNghiepMe"].ToString();
                    stdDTO.Status = dt.Rows[i]["PhanLop"].ToString();
                    ListStudentDTO.Add(stdDTO);
                }
                return ListStudentDTO;
            }
            return null;
        }
    }
}
