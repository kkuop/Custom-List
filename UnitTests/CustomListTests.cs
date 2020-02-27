using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class CustomListTests
    {
        //**************
        //Add tests
        //**************
        [TestMethod]
        public void Add_AddIntegerToListCheckIndexZero()
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
        public void Add_AddStringsToListCheckIndexFive()
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
        public void Add_AddObjectsToListCheckCount()
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
        public void Add_AddDoublesToList()
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
        public void Add_AddFiveIntsToListCheckCapacity()
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
        public void Add_AddOneIntToListCheckCapacity()
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
        //***************
        //Remove tests
        //***************
        [TestMethod]
        public void Remove_RemoveIntsFromListCheckCount()
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
        public void Remove_RemoveStringFromListCheckIndexZero()
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
        public void Remove_RemoveObjectFromListCheckCount()
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
        public void Remove_RemoveDoubleFromListCheckIndexThree()
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
        [TestMethod]
        public void Remove_RemoveIntThatDoesNotExistInList()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 3;
            int actual;
            //act
            customList.Add(4);
            customList.Add(5);
            customList.Add(6);
            customList.Remove(3);
            actual = customList.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveIntAndCheckValuesProperlyShifted()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 4;
            int actual;
            //act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);
            customList.Remove(2);
            actual = customList[2];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_CheckIfMultipleIntsOfSameValueAreRemoved()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            string expected = "1357";
            //act
            customList.Add(1);
            customList.Add(3);
            customList.Add(3);
            customList.Add(5);
            customList.Add(7);
            customList.Remove(3);
            //assert
            Assert.AreEqual(expected, customList.ToString());
        }

        //***************
        //Count tests
        //***************
        [TestMethod]
        public void Count_AddThreeIntsCheckCount ()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 3;
            int actual;
            //act
            customList.Add(5);
            customList.Add(10);
            customList.Add(15);
            actual = customList.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        //****************
        //Capacity tests
        //****************
        [TestMethod]
        public void Capacity_AddNineIntsCheckCapacity()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 16;
            int actual;
            //act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);
            customList.Add(6);
            customList.Add(7);
            customList.Add(8);
            customList.Add(9);
            actual = customList.Capacity;
            //assert
            Assert.AreEqual(expected, actual);
        }
        //****************
        //Indexer tests
        //****************
        [TestMethod]
        public void Indexer_AddThreeIntsCheckIndexTwo()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 3;
            int actual;
            //act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            actual = customList[2];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Indexer_AddThreeIntsCheckIndexThree()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int actual;
            //act
            customList.Add(11);
            customList.Add(12);
            customList.Add(13);
            
            //assert
            Assert.ThrowsException<ArgumentException>(() => actual = customList[3]);
        }
        //*****************
        //ToString tests
        //*****************
        [TestMethod]
        public void ToString_AddThreeInts()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            string expected = "123";
            string actual;
            //act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            actual = customList.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_AddTwoStrings()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>();
            string expected = "Hello World!";
            string actual;
            //act
            customList.Add("Hello ");
            customList.Add("World!");
            actual = customList.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_AddSixDoubles()
        {
            //arrange
            CustomList<double> customList = new CustomList<double>();
            string expected = "1.11.21.31.41.51.6";
            string actual;
            //act
            customList.Add(1.1);
            customList.Add(1.2);
            customList.Add(1.3);
            customList.Add(1.4);
            customList.Add(1.5);
            customList.Add(1.6);
            actual = customList.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }
        //********************
        //Overload add tests
        //********************
        [TestMethod]
        public void OverloadPlus_CreateTwoIntListsAndAddTogether()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList1 = new CustomList<int>();
            string expected = "135246";
            CustomList<int> actual;
            //act
            customList.Add(1);
            customList.Add(3);
            customList.Add(5);
            customList1.Add(2);
            customList1.Add(4);
            customList1.Add(6);
            actual = customList + customList1;
            //assert
            Assert.AreEqual(expected, actual.ToString());
        }
        [TestMethod]
        public void OverloadPlus_CreateTwoStringListsAndAddTogether()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>();
            CustomList<string> customList1 = new CustomList<string>();
            string expected = "Hello World!";
            CustomList<string> actual;
            //act
            customList.Add("Hello ");
            customList1.Add("World!");
            actual = customList+ customList1;
            //assert
            Assert.AreEqual(expected, actual.ToString());
        }
        //**********************
        //Overload minus tests
        //**********************
        [TestMethod]
        public void OverloadMinus_CreateTwoIntListsAndSubtract()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList1 = new CustomList<int>();
            string expected = "135";
            CustomList<int> actual;
            //act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);
            customList.Add(6);
            customList1.Add(2);
            customList1.Add(4);
            customList1.Add(6);
            actual = customList - customList1;
            //assert
            Assert.AreEqual(expected, actual.ToString());
        }
        [TestMethod]
        public void OverloadMinus_CreateTwoStringListsAndSubtract()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>();
            CustomList<string> customList1 = new CustomList<string>();
            string expected = "I am from Milwaukee ";
            CustomList<string> actual;
            //act
            customList.Add("I ");
            customList.Add("am ");
            customList.Add("from ");
            customList.Add("Milwaukee ");
            customList.Add("Wisconsin ");
            customList.Add("United States ");
            customList1.Add("Wisconsin ");
            customList1.Add("United States ");
            actual = customList - customList1;
            //assert
            Assert.AreEqual(expected, actual.ToString());
        }
        [TestMethod]
        public void OverloadMinus_CheckIfMultipleSameIntsAreRemovedFromListOne()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList1 = new CustomList<int>();
            string expected = "13";
            CustomList<int> actual;
            //act
            customList.Add(1);
            customList.Add(3);
            customList.Add(3);
            customList1.Add(2);
            customList1.Add(3);
            customList1.Add(4);
            actual = customList - customList1;
            //assert
            Assert.AreEqual(expected, actual.ToString());
        }
        [TestMethod]
        public void OverloadMinus_CheckIfTooManyLettersAreRemoved()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>() { "M", "A", "R", "Q", "U", "E", "T", "T", "E" };
            CustomList<string> customList1 = new CustomList<string>() { "Q", "U", "E", "T" };
            CustomList<string> resultList = new CustomList<string>();
            string expected = "MARTE";
            //act
            resultList = customList - customList1;
            //assert
            Assert.AreEqual(expected, resultList.ToString());
        }
        //****************
        //Zipper tests
        //****************
        [TestMethod]
        public void Zipper_ZipTwoIntsListsTogether()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList1 = new CustomList<int>();
            string expected = "123456";
            CustomList<int> actual;
            //act
            customList.Add(1);
            customList.Add(3);
            customList.Add(5);
            customList1.Add(2);
            customList1.Add(4);
            customList1.Add(6);
            actual = customList.Zip(customList1);
            //assert
            Assert.AreEqual(expected, actual.ToString()) ;
        }
        [TestMethod]
        public void Zipper_ZipTwoStringListsTogether()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>();
            CustomList<string> customList1 = new CustomList<string>();
            string expected = "Hello I world am ! from Milwaukee ";
            CustomList<string> actual;
            //act
            customList.Add("Hello ");
            customList.Add("world ");
            customList.Add("! ");
            customList1.Add("I ");
            customList1.Add("am ");
            customList1.Add("from ");
            customList1.Add("Milwaukee ");
            actual = customList.Zip(customList1);
            //assert
            Assert.AreEqual(expected, actual.ToString());
        }
        //****************
        //Iterate tests
        //****************
        [TestMethod]
        public void Iterate_ConsoleWriteTheContentsOfTheList()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            string expected = "123456";
            string actual = "";
            //act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);
            customList.Add(6);
            foreach (int item in customList)
            {
                actual = actual + item;
            }
            //assert
            Assert.AreEqual(expected, actual);
        }
        //****************
        //BONUS sort tests
        //****************
        [TestMethod]
        public void Sort_SortIntsIncreasingInValue()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            string expected = "123456";
            //act
            customList.Add(2);
            customList.Add(4);
            customList.Add(6);
            customList.Add(1);
            customList.Add(3);
            customList.Add(5);
            customList.Sort("ascending");
            //assert
            Assert.AreEqual(expected, customList.ToString());
        }
        [TestMethod]
        public void Sort_SortStringsAscending()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>();
            string expected = "am from I Milwaukee ";
            //act
            customList.Add("I ");
            customList.Add("am ");
            customList.Add("from ");
            customList.Add("Milwaukee ");
            customList.Sort("ascending");
            //assert
            Assert.AreEqual(expected, customList.ToString());
        }
        [TestMethod]
        public void Sort_SortDoublesAscending()
        {
            //arrange
            CustomList<double> customList = new CustomList<double>();
            string expected = "1.12.23.34.45.5";
            //act
            customList.Add(4.4);
            customList.Add(2.2);
            customList.Add(5.5);
            customList.Add(1.1);
            customList.Add(3.3);
            customList.Sort("ascending");
            //assert
            Assert.AreEqual(expected, customList.ToString());
        }
        [TestMethod]
        public void Sort_SortIntsDecreasingInValue()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            string expected = "654321";
            //act
            customList.Add(1);
            customList.Add(3);
            customList.Add(5);
            customList.Add(2);
            customList.Add(4);
            customList.Add(6);
            customList.Sort("descending");
            //assert
            Assert.AreEqual(expected, customList.ToString());
        }
        [TestMethod]
        public void Sort_SortStringsDescending()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>();
            string expected = "zippers yellow trees bark alpha ";
            //act 
            customList.Add("trees ");
            customList.Add("yellow ");
            customList.Add("zippers ");
            customList.Add("alpha ");
            customList.Add("bark ");
            customList.Sort("descending");
            //assert
            Assert.AreEqual(expected, customList.ToString());
        }
        [TestMethod]
        public void Sort_SortDoublesDescending()
        {
            //arrange
            CustomList<double> customList = new CustomList<double>();
            string expected = "9.997.255.312.251.1";
            //act
            customList.Add(5.31);
            customList.Add(7.25);
            customList.Add(1.1);
            customList.Add(9.99);
            customList.Add(2.25);
            customList.Sort("descending");
            //assert
            Assert.AreEqual(expected, customList.ToString());
        }
    }
}
