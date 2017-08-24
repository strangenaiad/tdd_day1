using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserProfit
{
    public class UserProfitDaily
    {
        internal int Sum( int[]arr )
        {
            int sum = 0;
            for (var i = 0; i < arr.Length; i++)
                sum += arr[i];

            return sum;
        }

        public int[] Summary( List<int>all, int period )
        {
            List<int> ret = new List<int>();

            var i = 0;
            while (i < all.Count())
            {
                var num = all.Count() - i;
                if (num > period)
                    num = period;

                int[] arr = new int[num];
                all.CopyTo(i, arr, 0, num);
                ret.Add(Sum(arr));

                i += num;
            }

            return ret.ToArray();
        }

        public int[] SummarySheet( List<List<int>>sheet, int col, int period )
        {
            return Summary(sheet[col], period);
        }
    }
}
