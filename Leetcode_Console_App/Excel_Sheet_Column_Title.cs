using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Excel_Sheet_Column_Title
    {
        //Problem link: https://leetcode.com/problems/excel-sheet-column-title/

        public string ConvertToTitle(int n)
        {
            string result = string.Empty;
            if (n <= 0)
                return result;

            while (n > 0)
            {
                //Get Remainder 
                result = (char)('A' + (n - 1) % 26) + result;
                //Resetting condition that means let it is a 26 bit.
                n = (n - 1) / 26;
            }
            return result;
        }
    }
}
