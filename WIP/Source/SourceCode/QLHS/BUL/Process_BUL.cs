using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUL
{
    public class Process_BUL
    {
        public static bool InitialProcess(string ClassID,int StudentID, string TermID)
        {
            return Process_DAL.InitialProcess(ClassID, StudentID, TermID);
        }
        public static int CountStudent(string ClassID)
        {
            return Process_DAL.CountStudent(ClassID);
        }
        public static List<Student_DTO> LoadByClass(string classID,string TermID)
        {
            return Process_DAL.LoadByClass(classID,TermID);
        }
        public static Process_DTO GetProcess(int studentID, string TermID, string ClassID)
        {
            return Process_DAL.GetProcess(studentID, TermID, ClassID);
        }
    }
}
