using System;

namespace OnlineLibrary.Model
{
    public class Book
    {
        private int id;
        private int studentId;
        private string bookName;

        public Book()
        {
        }
        public Book(int id, int studentId, string bookName)
        {
            this.id = id;
            this.studentId = studentId;
            this.bookName = bookName;
        }

        //proprietati
        public int Id
        {
            get { return id; }
            set { this.id = value; }
        }
        public int StudentId
        {
            get { return studentId; }
            set { this.studentId = value; }
        }
        public String BookName
        {
            get { return bookName; }
            set { this.bookName = value; }
        }
        public String Desc()
        {
            string bookPropDesc = "";
            bookPropDesc += "Id " + this.id + "Student ID " + this.studentId + "Book Name " + this.bookName;
            return bookPropDesc;
        }

        public String toSaveBook()
        {
            return id + "," + studentId + "," + bookName;
        }
    }
        
}
