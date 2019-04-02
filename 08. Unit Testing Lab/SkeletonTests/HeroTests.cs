using Moq;
using NUnit.Framework;
using Skeleton.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skeleton.Tests
{
    [TestFixture]
    public class HeroTests
    {
        [Test]
        public void HeroGainExperience()
        {
            Mock<IWeapon> fakeWeapon = new Mock<IWeapon>();
            Mock<ITarget> fakeTarget = new Mock<ITarget>();

            fakeWeapon.Setup(w => w.AttackPoints).Returns(10);
            fakeWeapon.Setup(w => w.DurabilityPoints).Returns(15);

            fakeTarget.Setup(t => t.Health).Returns(0);
            fakeTarget.Setup(t => t.GiveExperience()).Returns(10);
            fakeTarget.Setup(t => t.IsDead()).Returns(true);

            Hero hero = new Hero("Ivan", fakeWeapon.Object);
            hero.Attack(fakeTarget.Object);

            var expectedResult = 10;
            var actualResult = hero.Experience;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
