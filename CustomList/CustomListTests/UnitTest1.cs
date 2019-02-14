using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Add_CheckCount_Increases()
        {
            //        -	Check if count increases

            //Arrange

            CustomList<int> list = new CustomList<int>();

            int itemOne = 5;
            int actualResult = list.Count;
            int expectedResult = 1;


            //Act
            list.add(itemOne);


            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void Add_AddValue_CorrectIndex()
        {

            //Arrange
            CustomList<int> list = new CustomList<int>();
            // int correctIndex;
            int itemOne = 5;
            int expectedResult = 5;
            int actualResult = list[0];
            //Act
            list.add(itemOne);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void Add_StringValue_CorrectString()
        {
            //-	Check if string value is correctly added

            //Arrange
            CustomList<string> list = new CustomList<string>();

            string itemOne = "5";


            string expectedResult;
            string actualResult;
            expectedResult = 5;

            //Act
            list.add(itemOne);
            actualResult = list[0];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);


        }

        [TestMethod]
        public void Add_AddItems_LastIndex()
        {
            //-	Check if each added item appears at the last index of array

            CustomList<int> list = new CustomList<int>();

            int itemOne = 5;
            int itemTwo = 3;
            int expectedResult;
            int actualResult;
            expectedResult = 3;

            //Arrange


            actualResult = list[list.Count];
            //Act

            list.add(itemOne);
            list.add(itemTwo);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void Add_AddValue_DoesNotDisturbOtherValues()
        {
            //-	

            //Arrange

            CustomList<int> list = new CustomList<int>();

            int itemOne = 5;
            int itemTwo = 2;
            int actualResult;
            int expectedResult;
            expectedResult = 5;

            //Act
            list.add(itemOne);
            list.add(itemTwo);

            actualResult = list[0];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }


        [TestMethod]
        public void Sub_RemoveItem_DecreaseCount()
        {
            //-	Check if count decreases

            //Arrange
            CustomList<int> list = new CustomList<int>();

            int itemOne = 5;
            int itemTwo = 2;
            int actualResult;
            int expectedResult = 1;
            int firstCount;
            int secondCount;

            //Act
            list.add(itemOne);
            list.add(itemTwo);
            firstCount = list.Count;
            list.Remove(itemTwo);
            secondCount = list.Count;


            actualResult = firstCount - secondCount;


            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }


        [TestMethod]
        public void Sub_RemoveItem_SpecificIndex()
        {
            //-	Check for value removed at specific index

            //Arrange
            CustomList<int> list = new CustomList<int>();
            int correctIndex;
            int itemOne = 5;
            int itemTwo = 2;
            int expectedResult;
            int actualResult;

            //Act
            list.add(itemOne);
            list.addAt(correctIndex, itemTwo);
            actualResult = list[correctIndex];
            expectedResult = itemTwo;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void Sub_LastIndex_ReturnsNull()
        {
            //-	Check if previous last index of array is now null

            //Arrange
            CustomList<int> list = new CustomList<int>();
            int itemOne;
            int itemTwo;
            expectedResult;
            actualResult;

            //Act
            list.add(itemOne);
            list.add(itemTwo);
            list.remove(itemTwo);
            actualResult = list[1];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }


        [TestMethod]
        public void TestMethod1()
        {
            //-	Check if previous last value has one less index

            //Arrange


            //Act

            //Assert


        }
    }