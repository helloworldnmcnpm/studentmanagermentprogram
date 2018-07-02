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
        public static int CountStudent(string ClassID,string TermID)
        {
            return Process_DAL.CountStudent(ClassID,TermID);
        }
        public static List<Student_DTO> LoadByClass(string classID,string termID)
        {
            return Process_DAL.LoadByClass(classID,termID);
        }
        public static Process_DTO GetProcess(int studentID, string TermID, string ClassID)
        {
            return Process_DAL.GetProcess(studentID, TermID, ClassID);
        }
        public static bool InitialFinalScore(int ProcessID)
        {
            return Process_DAL.InitialFinalScore(ProcessID);
        }
        public static List<Process_DTO> ListStudentByTerm(string TermID)
        {
            return Process_DAL.ListStudentByTerm(TermID);
        }
        public static bool UpdateFinalScore(double score,int ProcessID)
        {
            return Process_DAL.UpdateFinalScore(score, ProcessID);
        }
        public static List<Process_DTO> ListProcessByTermAndClass(string TermID, string ClassID)
        {
            return Process_DAL.ListProcessByTermAndClass(TermID, ClassID);
        }
        public static List<Process_DTO> ListProcessByClass(string ClassID)
        {
            return Process_DAL.ListProcessByClass(ClassID);
        }
    }
}
