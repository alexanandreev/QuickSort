using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QuickSortTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSort()
        {
            var array = QuickSort.Program.GenerateArray(3);
            QuickSort.Program.QuickSort(array);

            Assert.AreEqual(array[0] < array[1], true);
            Assert.AreEqual(array[1] < array[2], true);
        }

        [TestMethod]
        public void TestSortHundred()
        {
            var array = new int[100];
            for (int i = 0; i < 100; i++) array[i] = 1;
            QuickSort.Program.QuickSort(array);

            Assert.AreEqual(array[0] <= array[1], true);
        }

        [TestMethod]
        public void TestSortThousand()
        {
            var array = QuickSort.Program.GenerateArray(1000);
            QuickSort.Program.QuickSort(array);
            Random x = new Random();

            for (int i = 0; i < 10; i++) Assert.AreEqual(array[x.Next(0, 500)] <= array[x.Next(500, 999)], true);
        }

        [TestMethod]
        public void TestSortEmpty()
        {
            var array = QuickSort.Program.GenerateArray(0);
            QuickSort.Program.QuickSort(array);
        }

        [TestMethod]
        public void TestSortBig()
        {
            var array = QuickSort.Program.GenerateArray(100000000);
            QuickSort.Program.QuickSort(array);
            Random x = new Random();

            Assert.AreEqual(array[0] < array[x.Next(1, array.Length - 1)], true);
        }
    }
}