using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebAdventure.Tests
{
    [TestClass]
    public class CharacterStatsTests
    {
        [TestMethod]
        public void AddNulls()
        {
            CharacterStats a = null;
            CharacterStats b = null;
            CharacterStats c = a + b;

            Assert.IsNull(c);
        }

        [TestMethod]
        public void AddNullValue()
        {
            CharacterStats a = null;
            CharacterStats b = new()
            {
                Charisma = 1,
                Constitution = 2,
                Dexterity =3,
                Intelligence = 4,
                Strength = 5,
                Wisdom = 6
            };

            CharacterStats c = a + b;

            Assert.AreEqual(new()
            {
                Charisma = 1,
                Constitution = 2,
                Dexterity = 3,
                Intelligence = 4,
                Strength = 5,
                Wisdom = 6
            }, c);

            Assert.AreNotSame(b, c);
        }

        [TestMethod]
        public void AddValueNull()
        {
            CharacterStats a = new()
            {
                Charisma = 1,
                Constitution = 2,
                Dexterity = 3,
                Intelligence = 4,
                Strength = 5,
                Wisdom = 6
            };

            CharacterStats b = null;
            CharacterStats c = a + b;

            Assert.AreEqual(new()
            {
                Charisma = 1,
                Constitution = 2,
                Dexterity = 3,
                Intelligence = 4,
                Strength = 5,
                Wisdom = 6
            }, c);

            Assert.AreNotSame(a, c);
        }

        [TestMethod]
        public void AddValues()
        {
            CharacterStats a = new()
            {
                Charisma = 1,
                Constitution = 2,
                Dexterity = 3,
                Intelligence = 4,
                Strength = 5,
                Wisdom = 6
            };

            CharacterStats b = new()
            {
                Charisma = 1,
                Constitution = 2,
                Dexterity = 3,
                Intelligence = 4,
                Strength = 5,
                Wisdom = 6
            };

            CharacterStats c = a + b;

            Assert.AreEqual(new()
            {
                Charisma = 2,
                Constitution = 4,
                Dexterity = 6,
                Intelligence = 8,
                Strength = 10,
                Wisdom = 12
            }, c);

            Assert.AreNotSame(a, c);
            Assert.AreNotSame(b, c);
        }
    }
}
