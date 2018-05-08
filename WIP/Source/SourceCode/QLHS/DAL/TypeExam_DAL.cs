using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class TypeExam_DAL
    {
        public static List<TypeExam_DTO> Load()
        {
            string QueryString = @"Select * from HINHTHUCKIEMTRA";
            DataTable dt = DataProvider.dataTableQuery(QueryString);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<TypeExam_DTO> typeExam_DTOs = new List<TypeExam_DTO>();
                TypeExam_DTO typeExam_DTO;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    typeExam_DTO = new TypeExam_DTO();
                    typeExam_DTO.ID = dt.Rows[i]["MaHinhThucKiemTra"].ToString();
                    typeExam_DTO.Name = dt.Rows[i]["TenHinhThucKiemTra"].ToString();
                    typeExam_DTO.Index =Convert.ToInt32(dt.Rows[i]["HeSo"].ToString());
                    typeExam_DTOs.Add(typeExam_DTO);
                }
                return typeExam_DTOs;
            }
            return null;
        }
        public static bool Insert(TypeExam_DTO typeExam_DTO)
        {
            string QueryString = string.Format("Insert into HINHTHUCKIEMTRA(MaHinhThucKiemTra,TenHinhThucKiemTra,HeSo) values('{0}',N'{1}','{2}')", typeExam_DTO.ID, typeExam_DTO.Name, typeExam_DTO.Index);
            return DataProvider.ExecuteNonQueryMethod(QueryString);
        }
        public static bool Update(TypeExam_DTO typeExam_DTO)
        {
            string QueryString = string.Format("Update HINHTHUCKIEMTRA set TenHinhThucKiemTra=N'{0}', HeSo='{1}' where MaHinhThucKiemTra='{2}'", typeExam_DTO.Name, typeExam_DTO.Index, typeExam_DTO.ID);
            return DataProvider.ExecuteNonQueryMethod(QueryString);
        }
        public static bool Delete(string ID)
        {
            return DataProvider.ExecuteNonQueryMethod(string.Format("Delete from HINHTHUCKIEMTRA where MaHinhThucKiemTra='{0}'", ID));
        }
    }
}
