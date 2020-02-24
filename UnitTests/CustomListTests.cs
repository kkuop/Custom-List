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
        public void AddStringsToList()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>();
            //act

            //assert

        }
        public void AddObjectsToList()
        {
            //arrange
            CustomList<Random> customList = new CustomList<Random>(); 
            //act

            //assert

        }
        public void AddDoublesToList()
        {
            //arrange
            CustomList<double> customList = new CustomList<double>();
            //act

            //assert

        }

        //Remove tests
        public void RemoveIntsFromList()
        {
            //arrange

            //act

            //assert

        }
        public void RemoveStringFromList()
        {
            //arrange

            //act

            //assert

        }
        public void RemoveObjectFromList()
        {
            //arrange

            //act

            //assert

        }
        public void RemoveDoubleFromList()
        {
            //arrange

            //act

            //assert

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
