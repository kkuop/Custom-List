using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace UnitTests
{
    [TestClass]
    public class CustomListTests
    {
        //Add tests
        [TestMethod]
        public void AddIntegerToListCheckIndexZero()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 1;
            int actual;
            //act
            customList.Add(1);
            actual = customList[0];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddStringsToListCheckIndexFive()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>();
            string expected = "world!";
            string actual;
            //act
            customList.Add("Hello");
            customList.Add("it's");
            customList.Add("a");
            customList.Add("whole");
            customList.Add("new");
            customList.Add("world!");
            actual = customList[5];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddObjectsToListCheckCount()
        {
            //arrange
            CustomList<Random> customList = new CustomList<Random>();
            int expected = 3;
            int actual;
            //act
            customList.Add(new Random());
            customList.Add(new Random());
            customList.Add(new Random());
            actual = customList.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddDoublesToList()
        {
            //arrange
            CustomList<double> customList = new CustomList<double>();
            double expected = 4.4;
            double actual;
            //act
            customList.Add(4.4);
            actual = customList[0];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddFiveIntsToListCheckCapacity()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 8;
            int actual;
            //act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);
            actual = customList.Capacity;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddOneIntToListCheckCapacity()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 4;
            int actual;
            //act
            customList.Add(1);
            actual = customList.Capacity;
            //assert
            Assert.AreEqual(expected, actual);
        }
        //Remove tests
        [TestMethod]
        public void RemoveIntsFromListCheckCount()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 1;
            int actual;
            //act
            customList.Add(1);
            customList.Add(2);
            customList.Remove(1);
            actual = customList.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveStringFromListCheckIndexZero()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>();
            string expected = "World";
            string actual;
            //act
            customList.Add("Hello");
            customList.Add("World");
            customList.Remove("Hello");
            actual = customList[0];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveObjectFromListCheckCount()
        {
            //arrange
            CustomList<Random> customList = new CustomList<Random>();
            Random rng = new Random();
            Random rng1 = new Random();
            int expected = 1;
            int actual;
            //act
            customList.Add(rng);
            customList.Add(rng1);
            customList.Remove(rng);
            actual = customList.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveDoubleFromListCheckIndexThree()
        {
            //arrange
            CustomList<double> customList = new CustomList<double>();
            double expected = 5.51;
            double actual;
            //act
            customList.Add(5.55);
            customList.Add(5.54);
            customList.Add(5.53);
            customList.Add(5.52);
            customList.Add(5.51);
            customList.Remove(5.52);
            actual = customList[3];
            //assert
            Assert.AreEqual(expected, actual);
        }

        //Count tests

        //Capacity tests

        //Indexer tests

        //ToString tests

        //Overload add tests

        //Overload minus tests

        //Zipper tests

        //Iterate tests

        //BONUS sort tests
    }
}
