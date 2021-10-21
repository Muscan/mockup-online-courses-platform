using OnlineLibrary.Controller;
using OnlineLibrary.Model;
using System;
using System.Collections.Generic;
using Xunit;

namespace UnitTestsForOnlineLibrary
{
    public class BookControllerTests
    {
        [Fact]
        public void BookControllerAddAreAdded()
        {
            BookController books = new BookController();

            Book book = new Book(1, 1, "Venus");
            Book book2 = new Book(2, 2, "Moronetii");
            Book book3 = new Book(10, 10, "Shakez");
            books.Add(book);
            books.Add(book2);
            books.Add(book3);
            Assert.Equal(0, books.bookIndex(1));
        }
        [Fact]
        public void AddDelete10BooksPassed()
        {
            BookController books = new BookController();
            for (int i = 0; i < 10; i++)
            {
                Book b = new Book();
                b.Id = i;
                b.StudentId = i;
                b.BookName = "Wiederk " + i;
                //books.Add(new Book(i, i, "Vanderken"));
                books.Add(b);
            }
            //Console.WriteLine(books.toStringObjectBookFile());
            List<Book> allBooks = books.getAllBooks();
            for (int i = 0; i < 10; i++)
            {
                books.Delete(allBooks[0].Id);
            }
            if (allBooks.Count == 0)
            {
                Console.WriteLine("Books deleted ");
            }
            else
            {
                Console.WriteLine("All books not deleted ");
            }
        }

        [Fact]
        public void Update10BooksUpdated()
        {
            BookController books = new BookController();
            for (int i = 0; i < 10; i++)
            {
                Book b = new Book();
                b.Id = i;
                b.StudentId = i;
                b.BookName = "Wiederk " + i;
                //books.Add(new Book(i, i, "Vanderken"));
                books.Add(b);
            }

            List<Book> allBooks = books.getAllBooks();
            for (int i = 0; i < 10; i++)
            {
                bool updated = books.updateBook(allBooks[i], i + 100, i + 100, "Harbe" + i);
                Assert.True(updated);
            }
            Console.WriteLine(books.toStringObjectBookFile());
            books.DeleteAll();
        }

        [Fact]
        public void UpdateIdIsUpdated()
        {
            BookController books = new BookController();
            for (int i = 0; i < 10; i++)
            {
                Book b = new Book();
                b.Id = i;
                b.StudentId = i;
                b.BookName = "Books for update " + i;
                books.Add(b);
            }
            List<Book> allBooks = books.getAllBooks();
            for (int i = 0; i < 10; i++)
            {
                bool updated = books.UpdateId(allBooks[i], i + 100);
                Console.WriteLine(updated);
                Assert.True(updated);
            }
            Console.WriteLine(books.toStringObjectBookFile());
            books.DeleteAll();
        }
    }
}
