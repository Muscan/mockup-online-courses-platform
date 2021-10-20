using OnlineLibrary.Controller;
using OnlineLibrary.Model;
using Xunit;

namespace UnitTestsForOnlineLibrary
{
    public class BookControllerTests
    {
        [Fact]
        public void BookControllerAdd()
        {
            BookController books = new BookController();

            Book book = new Book(1, 1, "Venus");
            Book book2 = new Book(2, 2, "Moronetii");
            Book book3 = new Book(10, 10, "Shakez");
            books.Add(book);
            books.Add(book2);
            books.Add(book3);
            Assert.Equal(0,books.bookIndex(1));
        }
        
    }
}
