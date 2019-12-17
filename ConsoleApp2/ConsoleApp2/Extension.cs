using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public static class Extension
    {
        public static int? CharCount(this string str, char letter)
        {
            int i = 0;

            foreach (char item in str)
            {
                if (item==letter) 
                {
                    i++;
                }
            }
            if (i == 0)
            {
                return null;
            }
            return i;
        }
    }
}
