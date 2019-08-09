using FightingArena;
using NUnit.Framework;
using System;

namespace Tests
{
    public class WarriorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestIfConstructorWorksCorrectly()
        {
            string expectedName = "Pesho";
            int expectedDamage = 15;
            int expectedHp = 100;

            Warrior warrior = new Warrior("Pesho", 15, 100);

            Assert.AreEqual(expectedName, warrior.Name);
            Assert.AreEqual(expectedDamage, warrior.Damage);
            Assert.AreEqual(expectedHp, warrior.HP);
        }

        [Test]
        public void TestWithLikeEmptyName()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warrior = new Warrior("", 25, 100);
            });
        }

        [Test]
        public void TestWithLikeWhiteSpaceName()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warrior = new Warrior("   ", 25, 100);
            });
        }

        [Test]
        public void TestWihtLikeZeroDamage()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warrior = new Warrior("Pesho", 0, 100);
            });
        }

        [Test]
        public void TestWihtLikeNegativeDamage()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warrior = new Warrior("Pesho", -15, 100);
            });
        }

        [Test]
        public void TestWithLikeNegativeHp()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warrior = new Warrior("Pesho", 15, -10);
            });
        }

        [Test]
        public void TestAttackingCurrently()
        {
            int expectedAttHp = 95;
            int expecteddeffHp = 90;

            Warrior attacker = new Warrior("Pesho", 10, 100);
            Warrior defender = new Warrior("Gosho", 5, 100);

            attacker.Attack(defender);

            Assert.AreEqual(expectedAttHp, attacker.HP);
            Assert.AreEqual(expecteddeffHp, defender.HP);
        }

        [Test]
        public void TestAttackingWithLowHp()
        {
            Warrior attacker = new Warrior("Pesho", 10, 25);
            Warrior defender = new Warrior("Gosho", 5, 45);

            Assert.Throws<InvalidOperationException>(() =>
            {
                attacker.Attack(defender);
            });
        }

        [Test]
        public void TestAttackingEnemyWithLowHp()
        {
            Warrior attacker = new Warrior("Pesho", 10, 45);
            Warrior defender = new Warrior("Gosho", 5, 25);

            Assert.Throws<InvalidOperationException>(() =>
            {
                attacker.Attack(defender);
            });
        }

        [Test]
        public void TestIfAttackingStrongerEnemy()
        {
            Warrior attacker = new Warrior("Pesho", 10, 45);
            Warrior defender = new Warrior("Gosho", 55, 60);

            Assert.Throws<InvalidOperationException>(() =>
            {
                attacker.Attack(defender);
            });
        }

        [Test]
        public void TestKillingEnemy()
        {
            int expectedAttHp = 40;
            int expectedDeffHp = 0;

            Warrior attacker = new Warrior("Pesho", 55, 50);
            Warrior defender = new Warrior("Gosho", 10, 50);

            attacker.Attack(defender);

            Assert.AreEqual(expectedDeffHp, defender.HP);
            Assert.AreEqual(expectedAttHp, attacker.HP);

        }


    }
}