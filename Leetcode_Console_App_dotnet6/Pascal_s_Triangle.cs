using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Pascal_s_Triangle
    {
        //Problem link: https://leetcode.com/problems/pascals-triangle/

        public IList<IList<int>> Generate(int numRows)
        {
            List<IList<int>> triangle = new List<IList<int>>();

            if (numRows == 0)
                return triangle;

            //First layer
            triangle.Add(new List<int>() { 1 });

            if (numRows == 1)
                return triangle;

            //Second layer
            triangle.Add(new List<int>() { 1, 1 });

            if (numRows == 2)
                return triangle;

            //Other layer
            int prev = 1;
            while (numRows != 2)
            {
                IList<int> add = new List<int>();
                add.Add(1);

                for (int i = 0; i < triangle[prev].Count() - 1; i++)
                {
                    add.Add(triangle[prev][i] + triangle[prev][i + 1]);
                }

                add.Add(1);
                triangle.Add(add);

                prev++;
                numRows--;
            }

            return triangle;
        }
    }
}
