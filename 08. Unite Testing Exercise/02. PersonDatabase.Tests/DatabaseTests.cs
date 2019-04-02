namespace P01_Database.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;

    [TestFixture]
    public class DatabaseTests
    {
        private Person firstPerson;
        private Person secondPerson;

        [SetUp]
        public void SetUp()
        {
            this.firstPerson = new Person("Ivan", 12345);
            this.secondPerson = new Person("Pesho", 54321);
        }

        [Test]
        public void ConstructorShouldInitializeData()
        {
            var expectedResult = new Person[] { firstPerson, secondPerson };

            var database = new Database(expectedResult);

            var actualResult = database.Fetch();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void AddMethodShouldNotAddExistingUsernames()
        {
            var people = new Person[] { this.firstPerson, this.secondPerson };
            var database = new Database(people);

            var newPerson = new Person("Ivan", 23);

            Assert.That(() => database.Add(newPerson), Throws.InvalidOperationException.With.Message.EqualTo("This username is already taken!"));
        }

        [Test]
        public void AddMethodShouldNotAddExistingId()
        {
            var people = new Person[] { this.firstPerson, this.secondPerson };
            var database = new Database(people);

            var newPerson = new Person("Gosho", 12345);

            Assert.That(() => database.Add(newPerson), Throws.InvalidOperationException.With.Message.EqualTo("This id is already taken!"));
        }

        [Test]
        public void RemoveMethodShouldRemoveLastPerson()
        {
            var people = new Person[] { this.firstPerson, this.secondPerson };
            var database = new Database(people);
            database.Remove();

            var expectedResult = new Person[] { this.firstPerson };
            var actualResult = database.Fetch();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void RemoveMethodShouldThrowInvalidOperationExceptionIfEmpty()
        {
            var database = new Database();

            Assert.That(() => database.Remove(), Throws.InvalidOperationException.With.Message.EqualTo("Array is empty!"));
        }

        [Test]
        public void FindPersonByExistingAndNotNullUserName()
        {
            var people = new Person[] { this.firstPerson, this.secondPerson };
            var database = new Database(people);

            var expectedResult = this.firstPerson;
            var actualResult = database.FindByUsername("Ivan");

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void FindPersonByNonExistingUsernameShouldThrowInvalidOperationException()
        {
            var people = new Person[] { this.firstPerson, this.secondPerson };
            var database = new Database(people);

            Assert.That(() => database.FindByUsername("Gosho"), Throws.InvalidOperationException.With.Message.EqualTo("Person with this username doesn't exist!"));
        }

        [Test]
        public void FindPersonThrowsArgumentNullException()
        {
            var people = new Person[] { this.firstPerson, this.secondPerson };
            var database = new Database(people);

            Assert.That(() => database.FindByUsername(null), Throws.ArgumentNullException,"Username cannot be null or empty!");
        }

        [Test]
        public void FindPersonByUsernameWithCaseSensitive()
        {
            var people = new Person[] { this.firstPerson, this.secondPerson };
            var database = new Database(people);

            Assert.That(() => database.FindByUsername("ivan"), Throws.InvalidOperationException.With.Message.EqualTo("Person with this username doesn't exist!"));
        }

        [Test]
        public void FindPersonById()
        {
            var people = new Person[] { this.firstPerson, this.secondPerson };
            var database = new Database(people);

            var expectedResult = this.firstPerson;
            var actualResult = database.FindById(12345);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void FindPersonByNonExistingIdShouldThrowInvalidOperationException()
        {
            var people = new Person[] { this.firstPerson, this.secondPerson };
            var database = new Database(people);

            Assert.That(() => database.FindById(1324), Throws.InvalidOperationException, "Person with this id doesn't exist!");
        }

        [Test]
        public void FindPersonByIdNegativeArgumentShouldThrowArgumentOutOfRangeException()
        {
            var people = new Person[] { this.firstPerson, this.secondPerson };
            var database = new Database(people);

            Assert.That(() => database.FindById(-1)
            , Throws.ArgumentException, "Id cannot be negative!");
        }

        [Test]
        public void FetchMethodShouldReturPersonArrayCorrectly()
        {
            var people = new Person[] { this.firstPerson, this.secondPerson };
            var database = new Database(people);

            var expectedResult = new Person[] { this.firstPerson, this.secondPerson };
            var actualResult = database.Fetch();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
