using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using NUnit.Framework;

namespace Domain.Tests.Entities
{
    [TestFixture]
    public class ShopTests
    {
        [Test]
        public void Test()
        {
            var name = "MyBasket";
            var shop = new Shop(name);

            Assert.AreEqual(name, shop.Name);
        }
    }
    
}
