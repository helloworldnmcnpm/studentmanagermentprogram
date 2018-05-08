﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUL
{
    public class ScoreBySubject_BUL
    {
        public static bool Insert(ScoreBySubject_DTO scoreBySubject_DTO)
        {
            return ScoreBySubject_DAL.Insert(scoreBySubject_DTO);
        }
        public static List<ScoreBySubject_DTO> LoadByProcessID(int ID)
        {
            return ScoreBySubject_DAL.LoadByProcessID(ID);
        }
        public static bool Delete(string ID)
        {
            return ScoreBySubject_DAL.Delete(ID);
        }
    }
}
