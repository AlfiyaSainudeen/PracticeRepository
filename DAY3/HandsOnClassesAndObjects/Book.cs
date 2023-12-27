using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    internal class Book
    {
        public int BookId;
        public string BookName;
        public string Language;
        public int Price;
        public string Author;
        public string Publisher;
    }
    class BookRepository
    {
        public Book[] books = new Book[10];
        public int idx = 0;
        public void AddBook(Book book) //Adding new book details
        {
            //add book details to array
            if (idx <= books.Length)
            {
                books[idx] = book;
                idx++;
            }
            else
            {
                Console.WriteLine("book is Full!!!");
            }
        }
        public Book[] GetBooks() //Get All Books
        {
            return books;
        }
        public Book[] GetBookByBookName(string bookname) //Get Books by Book Name
        {
            Book[] bookname_books = new Book[books.Length];
            int idx = 0;
            foreach (Book book in books)
            {
                if (book != null)
                {
                    if (book.BookName == bookname)
                    {
                        bookname_books[idx] = book;
                        idx++;
                    }
                }
            }
            return bookname_books;
        }
        public Book[] GetBookByAuthor(string author) //Get Books by Author
        {
            Book[] author_books = new Book[books.Length];
            int idx = 0;
            foreach (Book book in books)
            {
                if (book != null)
                {
                    if (book.Author == author)
                    {
                        author_books[idx] = book;
                        idx++;
                    }
                }
            }
            return author_books;
        }

        public Book[] GetBookByPublisher(string publisher) //Get Books by Publisher
        {
            Book[] publisher_books = new Book[books.Length];
            int idx = 0;
            foreach (Book book in books)
            {
                if (book != null)
                {
                    if (book.Publisher == publisher)
                    {
                        publisher_books[idx] = book;
                        idx++;
                    }
                }
            }
            return publisher_books;
        }
        class Book_Main
        {
            private static object convert;

            static void Main(BookRepository bookRepository)
            {
                BookRepository boo = new BookRepository();
                do
                {
                    Console.WriteLine("1.Add Book");
                    Console.WriteLine("2.Get Book By Name");
                    Console.WriteLine("3.Get Book By Author");
                    Console.WriteLine("4.Get Book By Publisher");
                    Console.WriteLine("4.Get All Books");
                    Console.WriteLine("Enter U r Choice");
                    int ch = int.Parse(Console.ReadLine());
                    switch (ch)
                    {
                        case 1: //add new Book
                            {
                                Book book = new Book();
                                
                                book.BookId = new Random().Next(); //Random class return random value
                                Console.WriteLine("Enter Book  Name");
                                book.BookName = Console.ReadLine();
                                Console.WriteLine("Enter Lanuage");
                                book.Language = Console.ReadLine();
                                Console.WriteLine("Enter Price");
                                book.Price = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter Author");
                                book.Author = Console.ReadLine();
                                Console.WriteLine("Enter Publisher");
                                book.Publisher = Console.ReadLine();
                                bookRepository.AddBook(book);

                            }
                            break;
                        case 2: //Get Book by Name
                            {
                                Console.WriteLine("Enter Book Name");
                                string bookname = Console.ReadLine();
                                Book[] books = Repository.GetTeacherBySubject(subject);
                                foreach (Teacher teacher in teachers)
                                {
                                    if (teacher != null)
                                    {
                                        Console.WriteLine($"Id:{teacher.Id} Name:{teacher.Name} Subject:{teacher.Subject}");
                                        Console.WriteLine("Classes handled");
                                        foreach (string s in teacher.stds) Console.Write(s + " ");
                                    }
                                    Console.WriteLine();
                                }
                            }
                            break;

                    }
                }
            }
        }

        
    }
}
