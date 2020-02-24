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
        public void AddIntsToList()
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
        public void AddStringsToList()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>();
            string expected = "Hello world!";
            string actual;
            //act
            customList.Add("Hello world!");
            actual = customList[0];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddObjectsToList()
        {
            //arrange
            CustomList<Random> customList = new CustomList<Random>();
            int expected = 1;
            int actual;
            //act
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

        //Remove tests
        [TestMethod]
        public void RemoveIntsFromList()
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
        public void RemoveStringFromList()
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
        public void RemoveObjectFromList()
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
        public void RemoveDoubleFromList()
        {
            //arrange
            CustomList<double> customList = new CustomList<double>();
            double expected = 5.54;
            double actual;
            //act
            customList.Add(5.55);
            customList.Add(5.54);
            customList.Remove(5.54);
            actual = customList[0];
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
