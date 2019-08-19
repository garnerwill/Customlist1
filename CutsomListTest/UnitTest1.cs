using CustomListProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace CutsomListTest
{
    [TestClass]
    public class UnitTest1

    {
        [TestMethod]
        public void Add_AddToEmptyList_ItemGoesToIndexZero()
        {    // Indexer


            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 4;
            int actual;

            // act
            testList.Add(1);
            actual = testList.Capacity;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddToListWithExistingItem_NewItemGoesToEndOfList()
        {
            // Indexer



            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 0;
            int actual;
            int count;
            // act
            testList.Add(1);
            testList.Add(2);
            actual = testList[1];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddToListWithmultibleItem()

        {
            //index property




            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 6;
            int actual;
            // act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_Capacity_CapacityDoublesToEight()

        {
            //index property




            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 8;
            int actual;
            // act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(1);
            testList.Add(2);
            actual = testList.Capacity;

            // assert
            Assert.AreEqual(expected, actual);
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////



        [TestMethod]
        public void Remove_ItemfromList_Itemisremoved()

        {    // Indexer


            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = testList.Capacity;
            int actual;

            // act
            testList.Add(1);
            actual = testList.Capacity;

            // assert
            Assert.AreEqual(expected, actual);
        }


        public void Remove_Item1()
        {    // Indexer


            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;

            // act
            testList.Add(1);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }
        public void Remove_Item2()
        {    // Indexer


            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;

            // act
            testList.Add(1);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }
        public void Remove_Item3()
        {    
            
            // Indexer


            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;

            // act
            testList.Add(1);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }
        //public void EmptyList_ForLoopResultsMatchForEachLoop()
        //{
        //    // Arrange
        //    CustomList<int> j = new CustomList<int>();

        //    // Act
        //    string actual = "";
        //    string expected = "";
        //    foreach (int number in j)
        //    {
        //        actual += number.ToString() + ", ";
        //    }

        //    // Assert

        //    string expected1 = "";
        //    for (int i = 0; i < j.Count; i++)
        //    {
        //        expected1 += j[i].ToString() + ", ";
        //    }
        //    Assert.AreEqual(expected, actual);
        //}

    }
}


