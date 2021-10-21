using OnlineLibrary.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace OnlineLibrary.Controller
{
    public class BookController
    {
        private List<Book> books;
        public BookController()
        {
            books = new List<Book>();
            readBookTxt();
        }
        //Index of the book
        public List<Book> getAllBooks()
        {
            return books;
        }
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
                Console.WriteLine("Book added:" + book.Id + "," + book.StudentId + "," + book.BookName);
                return true;
            }
            Console.WriteLine("Book exists");
            return false;
        }

        public bool updateBook(Book book, int newId, int newStudentId, string newBookName)
        {
            int index = bookIndex(book.Id);

            if (index != -1) //check if the book does not exists in the list 
            {
                books[index].Id = newId;
                books[index].StudentId = newStudentId;
                books[index].BookName = newBookName;
                SaveToFile();
                Console.WriteLine("Book updated:" + book.Id + "," + book.StudentId + "," + book.BookName);
                return true;
            }
            Console.WriteLine("Book not found.");
            return false;
        }

        public bool UpdateId(Book book, int newId)
        {
            int index = bookIndex(book.Id);
            if (index != -1)
            {
                books[index].Id = newId;
                SaveToFile();
                Console.WriteLine("Book updated:" + book.Id);
                return true;
            }
            Console.WriteLine("Book not found.");
            return false;
        }

        public void Delete(int id)
        {
            int index = bookIndex(id);
            if (index != -1)
            {
                books.RemoveAt(index);
                Console.WriteLine("Book deleted" );

            }
            else
            {
                Console.WriteLine("Not deleted ");
            }
            SaveToFile();
        }

        public void DeleteAll()
        {
            books.Clear();
            SaveToFile();
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
