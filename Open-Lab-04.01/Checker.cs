﻿using System;

namespace Open_Lab_04._01
{
    public class Checker
    {
        public bool DoubleLetters(string str)
        {
            string str2 = "";
            for (int a = 0; a < str.Length -1; a++)
            {
               if (str[a] == str[a + 1])
               {
                    return true;
               }
            }
            return false;
        }
    }
}
&