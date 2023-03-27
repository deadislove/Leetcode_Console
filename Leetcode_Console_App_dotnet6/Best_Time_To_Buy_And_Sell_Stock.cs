using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Best_Time_To_Buy_And_Sell_Stock
    {
        //Problem link: https://leetcode.com/problems/best-time-to-buy-and-sell-stock/

        public int MaxProfit(int[] prices)
        {
            int result = 0;
            int min = (prices.Length > 0) ? prices[0] : 0;   //记录遍历过的最小值

            for (int i = 0; i < prices.Length; ++i)
            {
                min = Math.Min(min, prices[i]);
                result = Math.Max(result, prices[i] - min);   //对比当前最大值 vs 新增可能最大值
            }
            return result;
        }
    }
}
