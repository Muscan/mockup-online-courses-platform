using OnlineLibrary.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLibrary.Controller
{
    public class BookController
    {
        private List<Book> books;
        public BookController()
        {
            books = new List<Book>();

        }
        //Index of the book

        public int bookIndex(int id)
        {
            for (int i = 0; i < books.Count(); i++)
            {
                if (books[i].Id == id)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Add(Book book)
        {
            int indexOfBook = bookIndex(book.Id);
            if (indexOfBook == -1)
            {
                this.books.Add(book);
                this.SaveToFile();
                Console.WriteLine("Book added");
                return true;
            }
            Console.WriteLine("Book exists");
            return false;
        }



        public void SaveToFile()
        {
            StreamWriter write = new StreamWriter(@"D:\C# Basics\OnlineLibrary\OnlineLibrary\Files\Books.txt");
            write.WriteLine(this.toStringObjectBookFile());
            write.Close();
        }


        public void readBookTxt()
        {
            StreamReader reader = new StreamReader(@"D:\C# Basics\OnlineLibrary\OnlineLibrary\Files\Books.txt");
            String line = "";
            line = reader.ReadLine();
            while (line != "" && line != null)
            {
                String[] bookForFile = line.Split(',');
                int id = int.Parse(bookForFile[0]);
                int studentId = int.Parse(bookForFile[1]);
                string bookName = bookForFile[2];

                Book book = new Book(id, studentId, bookName);
                books.Add(book);
                line = reader.ReadLine();

            }
            reader.Close();
        }

        public string toStringObjectBookFile()
        {
            string bookData = "";
            for (int i = 0; i < books.Count; i++)
            {
                bookData += books[i].toSaveBook() + "\n";
            }
            return bookData;
        }


    }
}
