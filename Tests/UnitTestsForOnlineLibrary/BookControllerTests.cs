using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineLibrary.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineLibrary.Model;

namespace UnitTestsForOnlineLibrary
{
    [TestClass]
    public class BookControllerTests
    {
        [TestMethod]
        public void BookControllerAdd()
        {
            BookController books = new BookController();



            Book book = new Book(1, 1, "Venus");
            Book book2 = new Book(2, 2, "Moronetii");
            Book book3 = new Book(10, 10, "Shakez");
            books.Add(book);
            books.Add(book2);
            books.Add(book3);
            Assert.AreEqual(0,books.bookIndex(1));




        }
        
    }
}
