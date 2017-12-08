using BooksGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksGame
{
    class BooksListManager
    {
        int totalTrips = 0;
        List<Book> bookList = new List<Book>();

        public BooksListManager()
        {
            using (StreamReader file = new StreamReader(@"D:\dataList.txt"))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    char[] delimiters = new char[] { ',' };
                    string[] parts = line.Split(delimiters);
                    Book objBook = new Book();
                    objBook.BookCode = Convert.ToInt32(parts[0]);
                    objBook.BookTitle = Convert.ToString(parts[1]);
                    objBook.BookPrice = Convert.ToDecimal(parts[2]);
                    objBook.Quantity = Convert.ToInt32(parts[3]);
                    bookList.Add(objBook);
                }
                file.Close();
            }

        }

        //return all 
        public List<Book> GetBookList()
        {
            return bookList;

        }

        //retunn book with title
        public Book GetBookBytitle(string bookTitle)
        {
            //The Where returns an IEnumerable<Book>, 

            //or null if no one has been found.

            var book = bookList.Find(x => x.BookTitle == bookTitle);
            return book;

        }
        public int Count
        {
            get
            {
                totalTrips = bookList.Count();
                return totalTrips;
            }
        }


    }
}
