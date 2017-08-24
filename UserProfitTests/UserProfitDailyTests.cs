using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserProfit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserProfit.Tests
{
    [TestClass()]
    public class UserProfitDailyTests
    {
        [TestMethod()]
        public void SummaryTest_cost_with_3_period()
        {
            List<int> Cost = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            var target = new UserProfitDaily();

            int[] expect = { 6, 15, 24, 21 };
            int[] actual = target.Summary(Cost, 3);

            CollectionAssert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void SummaryTest_revenue_with_3_period()
        {
            List<int> Revenue = new List<int> { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 };
            var target = new UserProfitDaily();

            int[] expect = { 50, 66, 60 };
            int[] actual = target.Summary(Revenue, 4);

            CollectionAssert.AreEqual(expect, actual);
        }

    }
}
