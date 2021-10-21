using OnlineLibrary.Controller;
using OnlineLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            BookController booksController = new BookController();
            Book book = new Book(1,1,"Found letter");
            booksController.Add(book);

            Console.WriteLine(book.Desc());
            Console.ReadLine();
        }
    }
}
