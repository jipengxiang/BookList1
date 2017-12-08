using BooksGame;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchTitle = "Book Two";
            BooksListManager booksManager = new BooksListManager();

            List<Book> books = booksManager.GetBookList();

            foreach (var item in books)
            {
                Console.WriteLine("Book Code: {0}", item.BookCode);
                Console.WriteLine("Book Price: ${0}", item.BookPrice);
                Console.WriteLine("Book title: {0}", item.BookTitle);
                Console.WriteLine("**************");

            }//end foreach


            Console.WriteLine("Total number of trips {0}", books.Count);

            var book = booksManager.GetBookBytitle(searchTitle);
            if (book != null)
            {

                Console.WriteLine("Book Code: {0}", book.BookCode);
                Console.WriteLine("Book Price: ${0}", book.BookPrice);
                Console.WriteLine("Book title: ${0}", book.BookTitle);
                Console.WriteLine("**************");

            }
            else
            { Console.WriteLine("Book title: {0} not found", searchTitle); }

            Console.ReadKey();
            OpenBrowser("https://www.youtube.com/watch?v=3Wv-JIpAjks");
        }

        protected static void OpenBrowser(string url)
        {
            var prs = new ProcessStartInfo("iexplore.exe");

            prs.Arguments = url;

            Process.Start(prs);

        }
    }
}
