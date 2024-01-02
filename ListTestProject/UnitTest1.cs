using Moq;
using UnitTestingLists.Implementations;
using UnitTestingLists.Interfaces;

namespace ListTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void List_Should_Contain_Item()
        {
            //Arrange
            var mockService = new ListService();
            string fruit = "Watermelon";
            List<string> list = mockService.GetItems();

            //Act
            bool isThere = list.Contains(fruit);

            //Assert
            Assert.IsTrue(isThere);
        }

        [Test]
        public void List_Should_Add_Item()
        {
            //Arrange
            var mockService = new ListService();
            string fruit = "Grapes";
            List<string> list = mockService.GetItems();

            //Act
            mockService.Add(fruit);

            //Assert
            Assert.Contains(fruit, list);
        }

        [Test]
        public void List_Should_Replace_Old_Item_With_New()
        {
            //Arrange
            var mockService = new ListService();
            List<string> list = mockService.GetItems();
            int indexOfRemove = 1;
            string oldFruit = "Orange";
            string newFruit = "Strawberry";

            //Act
            mockService.Edit(oldFruit,newFruit);

            //Assert
            Assert.That(list[indexOfRemove], Is.EqualTo(newFruit));
        }

        [Test]
        public void List_Should_Delete_Item()
        {
            //Arrange
            var mockService = new ListService();
            List<string> list = mockService.GetItems();
            string deleteFruit = "Pear";

            //Act
            mockService.Remove(deleteFruit);

            //Assert
            Assert.IsFalse(list.Contains(deleteFruit));
        }
    }
}