using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CID
{
    public class Method
    {
        private static bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        public static string UpcaseFirstLetterOfEachWord(string s)
        {
            {
                if (s == "") return "";
                s = s.ToLower();
                char[] charArr = s.ToCharArray();
                charArr[0] = Char.ToUpper(charArr[0]);
                foreach (Match m in Regex.Matches(s, @"(\s\S)"))
                {
                    charArr[m.Index + 1] = m.Value.ToUpper().Trim()[0];
                }
                return new String(charArr);
            }

        }
        public static string LowerCaseAll(string s)
        {
            if (s == "") return "";
            s = s.ToLower();
            return s;
        }
        public static string DeletedNumber(string s)
        {
            return Regex.Replace(s, @"\d", "");
        }
        public static string DeleteSpacesBeginAndEnd(string s)
        {
            return s.Trim();
        }
        public static string DeleteDoubleSpace(string s)
        {
            for (; s.Contains("  ");) s = s.Replace("  ", " ");
            return s;
        }
        public static string DeleteDoubleDash(string s)
        {
            for (; s.Contains(",,");) s = s.Replace(",,", ",");
            return s;
        }
        public static string IfNotOnlyNumber(string s)
        {
            if (s == "") return s;
            string Result="";
            for (int i = 0; i < s.Length; i++)
            {
                if (IsNumber(s[i].ToString())) Result += s[i];
            }
            return Result;
        }
        public static string ConvertToReal(string S)
        {
            if (S == null) return S;
            S = DeleteDoubleDash(Regex.Replace(S, @"[^\w\d\s]", "."));
            string Result = "";
            for (int i = 0; i < S.Length; i++)
            {
                if (IsNumber(S[i].ToString()) || S[i] == '.') Result += S[i];
            }
            int count = 0;
            for (int i = 0; i < Result.Length; i++)
            {
                if (S[i] == '.') count++; //Is Real
                if (count == 2) //Not Real anymore :)
                {
                    Result = Result.Remove(i, 1);
                    i--;
                    count = 1; //Become Real Again
                }
            }
            return Result;
        }
        public static string RemoveSpecialKey(string s)
        {
            if (s == "") return s;
            return Regex.Replace(s, @"[^\w\d\s]","");
        }
        public static string MakeValidAddress(string s)
        {
            if (s == "") return s;
            return DeleteDoubleDash(Regex.Replace(s, @"[^\w\d\s]", ","));
        }
        public static string UpcaseSpaceNumber(string s)
        {
            return RemoveSpecialKey(UpcaseFirstLetterOfEachWord(DeleteDoubleSpace(s)));
        }
        public static string Under7word(string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ') count++;
                if (count == 7) return s = s.Remove(i, 1);
            }
            return s;
        }
    }
}
