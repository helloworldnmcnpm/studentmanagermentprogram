using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace CID
{
    public class Correct_Input_Data: Method
    { 
        public string InputString { get; set; }
        public bool IsUpcase
        {
            get
            {
                if (UpcaseFirstLetterOfEachWord(InputString) == InputString) return true;
                else return false;
            }
        }
        public bool IsAHundered
        {
            get
            {
                if (InputString.Length >= 99) return true;
                else return false;
            }
        }
        public bool IsHaveNumber
        {
            get
            {
                for (char i = '0'; i <= '9'; i++)
                {
                    if (InputString.Contains(i)) return true;
                }
                return false;
            }
        }
        public string Upcase
        {
            get
            {
                return UpcaseFirstLetterOfEachWord(InputString);
            }
        }
        public string UnderAHundered {
            get
            {
                if (IsAHundered) return InputString.Substring(0, 99);
                else return InputString;
            }
        }
        public string NonNumber
        {
            get
            {
                return DeletedNumber(InputString);
            }
        }
        public string OnlyNumber
        {
            get
            {
                return IfNotOnlyNumber(InputString);
            }
        }
        public string NoSpecialKey
        {
            get;
        }
        public string TrueName
        {
            get
            {
                Correct_Input_Data vir = new Correct_Input_Data();
                vir.InputString = InputString;
                return RemoveSpecialKey(DeleteDoubleSpace(UpcaseFirstLetterOfEachWord(DeletedNumber(vir.UnderAHundered))));
            }
        }
        public string ValidAddress
        {
            get
            {
                Correct_Input_Data vir = new Correct_Input_Data();
                vir.InputString = InputString;
                return DeleteDoubleSpace(MakeValidAddress(vir.UnderAHundered));
            }
        }
        public string TrueID
        {
            get
            {
                Correct_Input_Data vir = new Correct_Input_Data();
                vir.InputString = InputString;
                return LowerCaseAll(RemoveSpecialKey(DeleteSpacesBeginAndEnd(vir.UnderAHundered)));
            }
        }
        public string OnlyText
        {
            get
            {
                Correct_Input_Data vir = new Correct_Input_Data();
                vir.InputString = InputString;
                char[] s = RemoveSpecialKey(DeleteDoubleSpace(DeletedNumber(vir.UnderAHundered))).ToLower().ToCharArray();
                if (new string(s) == "") return new string(s);
                s[0] = Char.ToUpper(s[0]);
                return new string(s);
            }
        }
        public string Real
        {
            get
            {
                return ConvertToReal(UnderAHundered);
            }
        }
        public string UpcaseSpaceAndNumber
        {
            get
            {
                return UpcaseSpaceNumber(UnderAHundered);
            }
        }
    }
}
