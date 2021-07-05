using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebAdventure.Tests
{
    [TestClass]
    public class ItemStatsTests
    {
        [TestMethod]
        public void AddNulls()
        {
            ItemStats a = null;
            ItemStats b = null;
            ItemStats c = a + b;

            Assert.IsNull(c);
        }

        [TestMethod]
        public void AddNullValue()
        {
            ItemStats a = null;
            ItemStats b = new()
            {
                Damage = 3,
                Defense = 4
            };

            ItemStats c = a + b;

            Assert.AreEqual(new()
            {
                Damage = 3,
                Defense = 4
            }, c);

            Assert.AreNotSame(b, c);
        }

        [TestMethod]
        public void AddValueNull()
        {
            ItemStats a = new()
            {
                Damage = 1,
                Defense = 2
            };

            ItemStats b = null;
            ItemStats c = a + b;

            Assert.AreEqual(new()
            {
                Damage = 1,
                Defense = 2
            }, c);

            Assert.AreNotSame(a, c);
        }

        [TestMethod]
        public void AddValues()
        {
            ItemStats a = new()
            {
                Damage = 1,
                Defense = 2
            };

            ItemStats b = new()
            {
                Damage = 3,
                Defense = 4
            };

            ItemStats c = a + b;

            Assert.AreEqual(new()
            {
                Damage = 4,
                Defense = 6
            }, c);

            Assert.AreNotSame(a, c);
            Assert.AreNotSame(b, c);
        }
    }
}
