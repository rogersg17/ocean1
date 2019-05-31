using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using BlueOceanLibrary;

namespace BlueOceanTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetAllBooks_VerfiyCount()
        {
           var mockLibrary = new Library();
           var numberOfBooks = mockLibrary.GetAllBooks().Count;

            numberOfBooks.Should().Be(3);

        }
        [TestMethod]
        public void VerifyTitle()
        {
            var mockLibrary = new Library();
            var numberOfBooks = mockLibrary.GetAllBooks();

            numberOfBooks[0].id = 1;
            numberOfBooks[1].id = 2;
            numberOfBooks[2].id = 3;

        }
    }
}
