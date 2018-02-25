using System;
using NUnit.Framework;

namespace HackerRank
{
    public class Task
    {
        public int getNumber(string[] origItems,float[] origPrices, string[] items, float[] prices)
        {
            int result = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (origPrices[Array.IndexOf(origItems, items[i])] != prices[i])
                    result++;
            }
            return result;
        }

        [Test]
        public void getNumberTest1()
        {
            var origItems = new [] {"rice", "sugar", "wheat", "cheese"};
            var origPrices = new [] {16.89f, 56.92f, 20.89f, 345.99f};
            var items = new [] {"rice", "cheese"};
            var prices = new [] {10.89f, 340.99f};
            Assert.AreEqual(getNumber(origItems, origPrices, items, prices), 2);
        }
        
        
        [Test]
        public void getNumberTest2()
        {
            var origItems = new [] {"rice", "sugar", "wheat", "cheese"};
            var origPrices = new [] {16.89f, 56.92f, 20.89f, 345.99f};
            var items = new [] {"rice", "cheese"};
            var prices = new [] {16.89f, 340.99f};
            Assert.AreEqual(getNumber(origItems, origPrices, items, prices), 1);
        }
    }
}