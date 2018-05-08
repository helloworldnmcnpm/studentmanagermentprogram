using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DeTailScore_DAL
    {
        public static List<DetailScore_DTO> LoadBySubject(string ID)
        {
            string QueryString = string.Format("Select MaChiTietBangDiemMon,MaBangDiemMon,MaHinhThucKiemTra,Diem from CHITIETBANGDIEMMON,BANGDIEMMON" +
                " where (BANGDIEMMON.MaBangDiemMon=CHITIETBANGDIEMMON.MaBangDiemMon and BANGDIEMMON.MaBangDiemMon='{0}')", ID);
            DataTable dt = DataProvider.dataTableQuery(QueryString);
            if (dt!=null && dt.Rows.Count > 0)
            {
                List<DetailScore_DTO> detailScore_DTOs = new List<DetailScore_DTO>();
                DetailScore_DTO detailScore_DTO;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    detailScore_DTO = new DetailScore_DTO();
                    detailScore_DTO.ID = dt.Rows[i]["MaChiTietBangDiemMon"].ToString();
                    detailScore_DTO.SBSID = dt.Rows[i]["MaBangDiemMon"].ToString();
                    detailScore_DTO.TypeExamID = dt.Rows[i]["MaHinhThucKiemTra"].ToString();
                    detailScore_DTO.Score = Convert.ToSingle(dt.Rows[i]["Diem"].ToString());
                    detailScore_DTOs.Add(detailScore_DTO);
                }
                return detailScore_DTOs;
            }
            return null;
        }
        public static List<DetailScore_DTO> LoadByStudent(string StudentID,string TermID)
        {
            string QueryString = string.Format("Select CHITIETBANGDIEMMON.MaChiTietBangDiemMon,CHITIETBANGDIEMMON.MaBangDiemMon,CHITIETBANGDIEMMON.MaHinhThucKiemTra,CHITIETBANGDIEMMON.Diem" +
                "from QUATRINHHOC,CHITIETBANGDIEMMON,HOCSINH,BANGDIEMMON " +
                "where (HOCSINH.MaHocSinh='{0}' and HOCSINH.MaHocSinh=QUATRINHHOC.MaHocSinh and QUATRINHHOC.MaHocKy='{1}'" +
                "and QUATRINHHOC.MaQuaTrinhHoc=BANGDIEMMON.MaQuaTrinhHoc and CHITIETBANGDIEMMON.MaBangDiemMon=BANGDIEMMON.MaBangDiemMon) ", StudentID, TermID);
            DataTable dt = DataProvider.dataTableQuery(QueryString);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<DetailScore_DTO> detailScore_DTOs = new List<DetailScore_DTO>();
                DetailScore_DTO detailScore_DTO;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    detailScore_DTO = new DetailScore_DTO();
                    detailScore_DTO.ID = dt.Rows[i]["MaChiTietBangDiemMon"].ToString();
                    detailScore_DTO.SBSID = dt.Rows[i]["MaBangDiemMon"].ToString();
                    detailScore_DTO.TypeExamID = dt.Rows[i]["MaHinhThucKiemTra"].ToString();
                    detailScore_DTO.Score = Convert.ToSingle(dt.Rows[i]["Diem"].ToString());
                    detailScore_DTOs.Add(detailScore_DTO);
                }
                return detailScore_DTOs;
            }
            return null;
        }


        /*public static bool InsertScoreByStudent(string ScoreBySubjectID, float Score)
        {
            string QueryString = string.Format("Insert into CHITIETBANGDIEMMON(MaBangDiemMon,MaHinhThucKiemTra,Diem)")
        }*/
    }
}
