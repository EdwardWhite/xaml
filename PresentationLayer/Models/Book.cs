using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
    }

    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();
            books.Add(new Book { BookId = 1, Title = "Vulpate", Author = "Futurum" });
            books.Add(new Book { BookId = 2, Title = "Mazim", Author = "Sequiter Que" });
            books.Add(new Book { BookId = 3, Title = "Elit", Author = "Tempor"});
            books.Add(new Book { BookId = 4, Title = "Etiam", Author = "Option" });
            books.Add(new Book { BookId = 5, Title = "Feugait Eros Libex", Author = "Accumsan" });
            books.Add(new Book { BookId = 6, Title = "Nonummy Erat", Author = "Legunt Xaepius" });
            books.Add(new Book { BookId = 7, Title = "Nostrud", Author = "Eleifend" });
            books.Add(new Book { BookId = 8, Title = "Per Modo", Author = "Vero Tation" });
            books.Add(new Book { BookId = 9, Title = "Suscipit Ad", Author = "Jack Tibbles"});
            books.Add(new Book { BookId = 10, Title = "Decima", Author = "Tuffy Tibbles" });
            books.Add(new Book { BookId = 11, Title = "Erat", Author = "Volupat"});
            books.Add(new Book { BookId = 12, Title = "Consequat", Author = "Est Possim" });
            books.Add(new Book { BookId = 13, Title = "Aliquip", Author = "Magna" });

            return books;
        }
    }
}
