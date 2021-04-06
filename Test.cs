using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharRepetition
{
    class Test
    {
        public char CheckRepeatition(String Argument)
        {
            char CharToReturn = '\0';       // 1
            String Checked = "";            // 1
            try
            {
                for (int i = 0; i < Argument.Length; i++)   // 1 + (N+1) + N
                {
                    if (Checked.Contains(Argument[i]))  // 1
                    {
                        CharToReturn = Argument[i];     // 1
                        break;
                    }
                    Checked = String.Format("{0}{1}", Checked, Argument.ToLower()[i]); // 1
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); ;
            }

            return CharToReturn;    //  1
        }
    }
}
