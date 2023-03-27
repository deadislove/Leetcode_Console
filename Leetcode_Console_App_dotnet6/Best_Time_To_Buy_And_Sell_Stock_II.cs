using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Best_Time_To_Buy_And_Sell_Stock_II
    {
        //Problem link: https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/

        public int MaxProfit(int[] prices)
        {
            var maxProfit = 0;
            for (var i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    maxProfit += prices[i] - prices[i - 1];
                }
            }
            return maxProfit;
        }
    }
}
