namespace P01_Database.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;

    [TestFixture]
    public class DatabaseTests
    {
        private int[] array;
        private int[] largerArray;
        private int[] fullArray;

        [SetUp]
        public void SetUp()
        {
            this.array = Enumerable.Range(1, 8).ToArray();
            this.largerArray = Enumerable.Range(1, 17).ToArray();
            this.fullArray = Enumerable.Range(1, 16).ToArray();
        }

        [Test]
        public void ConstructorShouldInitializeData()
        {
            var database = new Database(array);

            int[] actualResult = database.Fetch();

            Assert.AreEqual(array, actualResult);
        }

        [Test]
        public void ConstructorShoudThrowInvalidOperationExceptionWithLagerArray()
        {            
            Assert.That(() => new Database(largerArray), Throws.InvalidOperationException.With.Message.EqualTo("Legth cannot be more than 16!"));
        }

        [Test]
        public void AddMethodShouldAddElement()
        {
            var database = new Database(this.array);
            database.Add(9);

            var expectedResult = this.array.Concat(new int[] { 9 }).ToArray();
            var actualResult = database.Fetch();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void AddElementToFullArrayShouldThrowInvalidOperationException()
        {
            var database = new Database(fullArray);
           
            Assert.That(() => database.Add(17), Throws.InvalidOperationException.With.Message.EqualTo("Array is full!"));
        }

        [Test]
        public void RemoveMethodShouldRemoveElement()
        {
            var database = new Database(this.array);
            database.Remove();

            var expectedResult = this.array.Skip(this.array.Length - 2).Take(1).Last();
            var actualResult = database.Fetch().Last();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void RemoveMethodShouldThrowInvalidOperationExceptionIfEmpty()
        {
            var database = new Database();

            Assert.That(() => database.Remove(), Throws.InvalidOperationException.With.Message.EqualTo("Array is empty!"));
        }

        [Test]
        public void TestIfFetchMethodRetursArrayCorrecly()
        {
            var database = new Database(this.array);

            var expectedResult = this.array;
            var actualResult = database.Fetch();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
