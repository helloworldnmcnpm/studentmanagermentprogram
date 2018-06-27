using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUL
{
    public class Term_BUL
    {
        public static List<Term_DTO> Load()
        {
            return Term_DAL.Load();
        }
        public static bool Insert(Term_DTO term_DTO)
        {
            return Term_DAL.Insert(term_DTO);
        }
        public static bool Update(Term_DTO term_DTO)
        {
            return Term_DAL.Update(term_DTO);
        }
        public static bool Delete(string ID)
        {
            return Term_DAL.Delete(ID);
        }
        public static List<Term_DTO> LoadBySC(string ID)
        {
            return Term_DAL.LoadBySC(ID);
        }
        public static string GetName(string ID)
        {
            return Term_DAL.GetName(ID);
        }
    }
}
