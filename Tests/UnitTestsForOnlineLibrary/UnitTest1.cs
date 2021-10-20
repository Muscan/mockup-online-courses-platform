using OnlineLibrary.Model;
using Xunit;

namespace UnitTestsForOnlineLibrary
{
    public class BookUnitTest
    {
        [Fact]
        public void BookTest()
        {
            Book book = new Book(1, 1, "Venus");
            Assert.Equal(1, book.Id);
            Assert.Equal(1, book.StudentId);
            Assert.Equal("Venus", book.BookName);

            Assert.Equal("Id 1Student ID 1Book Name Venus", book.Desc());
        }
    }
}
