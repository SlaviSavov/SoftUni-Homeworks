//using FightingArena;
using NUnit.Framework;
using System;

namespace Tests
{
    public class ArenaTests
    {
        private Arena arena;

        [SetUp]
        public void Setup()
        {
            this.arena = new Arena();
        }

        [Test]
        public void TestIfConstructorWorksCorrectly()
        {
            Assert.IsNotNull(this.arena.Warriors);
        }

        [Test]
        public void TestIfEnrollWorksCorrectly()
        {
            Warrior warrior = new Warrior("Pesho", 10, 100);

            this.arena.Enroll(warrior);

            Assert.That(arena.Warriors, Has.Member(warrior));
        }

        [Test]
        public void TestEnrollExistWarrior()
        {
            Warrior warrior = new Warrior("Pesho", 10, 100);

            this.arena.Enroll(warrior);


            Assert.Throws<InvalidOperationException>(() =>
                   {
                       this.arena.Enroll(warrior);
                   });
        }

        [Test]
        public void TestArenaCountWorksCorrectly()
        {
            int expectedCount = 2;

            Warrior warriorPesho = new Warrior("Pesho", 10, 100);
            Warrior warriorGosho = new Warrior("Gosho", 20, 50);

            this.arena.Enroll(warriorPesho);
            this.arena.Enroll(warriorGosho);

            Assert.AreEqual(expectedCount, this.arena.Count);
        }

        [Test]
        public void TestIfFightWorksCorrectly()
        {
            int expectedAttHp = 95;
            int expectedDeffHp = 90;

            Warrior attacker = new Warrior("Pesho", 10, 100);
            Warrior defender = new Warrior("Gosho", 5, 100);

            this.arena.Enroll(attacker);
            this.arena.Enroll(defender);

            this.arena.Fight(attacker.Name, defender.Name);

            Assert.AreEqual(expectedAttHp, attacker.HP);
            Assert.AreEqual(expectedDeffHp, defender.HP);
        }

        [Test]
        public void TestFightingMissingWarrior()
        {
            Warrior attacker = new Warrior("Pesho", 10, 100);
            Warrior defender = new Warrior("Gosho", 5, 50);

            this.arena.Enroll(attacker);
            //Missing enroll on defender

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.arena.Fight(attacker.Name, "Gosho");
            });
        }


    }
}
