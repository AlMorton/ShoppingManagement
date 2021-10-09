using NUnit.Framework;
using System;

namespace Application.Tests
{
    public class LoadShoppingReportTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var loadShoppingReportUseCase = new LoadShoppingReportUseCase();

            var report = loadShoppingReportUseCase.GetReportForPerson(personId: 1);

            Assert.IsNotNull(report);
        }
    }

    internal class LoadShoppingReportUseCase
    {
        public LoadShoppingReportUseCase()
        {}

        internal IShoppingReport GetReportForPerson(int personId)
        {
            return new ShoppingReport();
        }
    }

    internal interface IShoppingReport
    {
    }

    public class ShoppingReport : IShoppingReport { }
}