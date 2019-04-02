using NUnit.Framework;
using Skeleton.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        private const int Health = 10;
        private const int Experience = 10;

        private Dummy dummy;

        [SetUp]
        public void SetUp()
        {
            this.dummy = new Dummy(Health, Experience);
        }

        [TestCase(5)]
        public void DummyLoosesHealthAfterAttack(int attackPoints)
        {           
            dummy.TakeAttack(5);

            int expectedResult = 5;
            int actualResult = this.dummy.Health;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(0,5)]
        public void DeadDummyThrowsInvalidOperationExceptionIfAttacked(int health, int experience)
        {
            this.dummy = new Dummy(health, experience);

            Assert.That(() => this.dummy.TakeAttack(10), Throws.InvalidOperationException.With.Message.EqualTo("Dummy is dead."));
        }

        [TestCase(0)]
        public void DeadDummyCanGiveExperience(int health)
        {
            this.dummy = new Dummy(health, Experience);

            int expectedResult = 10;
            int actualResult = dummy.GiveExperience();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void AliveDummyCantGiveExperienceAndThrowsInvalidOperationException()
        {
            Assert.That(() => this.dummy.GiveExperience(), Throws.InvalidOperationException.With.Message.EqualTo("Target is not dead."));
        }
    }
}
