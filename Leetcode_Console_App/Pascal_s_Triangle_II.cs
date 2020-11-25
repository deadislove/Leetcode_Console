using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Pascal_s_Triangle_II
    {
        //Problem link: https://leetcode.com/problems/pascals-triangle-ii/

        public IList<int> GetRow(int rowIndex)
        {
            IList<int> list = new List<int>();

            //First layer
            list.Add(1);

            if (rowIndex == 0)
                return list;

            //Second layer
            list.Add(1);
            if (rowIndex == 1)
                return list;

            //Other layer
            while (rowIndex != 1)
            {
                List<int> tempList = new List<int>();
                tempList.Add(1);

                for (int i = 0; i < list.Count() - 1; i++)
                {
                    tempList.Add(list[i] + list[i + 1]);
                }

                tempList.Add(1);
                list = tempList;
                rowIndex--;
            }

            return list;
        }
    }
}
