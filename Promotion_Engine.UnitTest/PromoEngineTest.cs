using System;
using System.Collections.Generic;
using NUnit.Framework;
using Promotion_Engine;

namespace Promotion_Engine.UnitTest
{
    [TestFixture]
    public class PromoEngineTest
    {
        [Test]
        public void GetTotalPriceBackSingleProductTestA()
        {

            List<Product> lp = new List<Product>()
            {
                new Product(){Id = "A", Price = 50},
                new Product(){Id = "B", Price = 30},
                new Product(){Id = "C", Price = 20}
            };
            var result = Program.GetTotalPrice(lp);
            Assert.That(result, Is.EqualTo(100));
        }
        [Test]
        public void GetTotalPriceBackMultipleProductScenarioB()
        {
            List<Product> lp = new List<Product>()
            {
                new Product(){Id = "A", Price = 50},
                new Product(){Id = "A", Price = 50},
                new Product(){Id = "A", Price = 50},
                new Product(){Id = "A", Price = 50},
                new Product(){Id = "A", Price = 50},
                new Product(){Id = "B", Price = 30},
                new Product(){Id = "B", Price = 30},
                new Product(){Id = "B", Price = 30},
                new Product(){Id = "B", Price = 30},
                new Product(){Id = "B", Price = 30},
                new Product(){Id = "C", Price = 20}
            };
            var result = Program.GetTotalPrice(lp);
            Assert.That(result, Is.EqualTo(370));
        }
        [Test]
        public void GetTotalPriceBackMultipleProductScenarioC()
        {
            List<Product> lp = new List<Product>()
            {
                new Product(){Id = "A", Price = 50},
                new Product(){Id = "A", Price = 50},
                new Product(){Id = "A", Price = 50},
                new Product(){Id = "B", Price = 30},
                new Product(){Id = "B", Price = 30},
                new Product(){Id = "B", Price = 30},
                new Product(){Id = "B", Price = 30},
                new Product(){Id = "B", Price = 30},
                new Product(){Id = "C", Price = 20},
                new Product(){Id = "D", Price = 15}

            };
            var result = Program.GetTotalPrice(lp);
            Assert.That(result, Is.EqualTo(285));
        }
        [Test]
        public void GetTotalPriceBackSingleProductAB()
        {
            List<Product> lp = new List<Product>()
            {
                new Product(){Id = "A", Price = 50},
                new Product(){Id = "B", Price = 30},
            };
            var result = Program.GetTotalPrice(lp);
        }
    }
}
