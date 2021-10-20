using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineLibrary.Model;
using System;

namespace UnitTestsForOnlineLibrary
{
    [TestClass]
    public class BookUnitTest
    {
        [TestMethod]
        public void BookTest()
        {
            Book book = new Book(1, 1, "Venus");
            Assert.AreEqual(1, book.Id);
            Assert.AreEqual(1, book.StudentId);
            Assert.AreEqual("Venus", book.BookName);

            Assert.AreEqual("Id 1Student ID 1Book Name Venus", book.Desc());
        }

      
        
    }
}
