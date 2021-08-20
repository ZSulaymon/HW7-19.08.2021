using System;

namespace HW7._2
{
    class Book
    {
        public string Name;

        public void Show()
        {
            Console.WriteLine("Имя книги: {0} ", Name);
            //Console.WriteLine($"Имя книги: {Name} ") ;
        }
    }

    class Title
    {
        public string titleBook;

        public void Show()
        {
            Console.WriteLine("Заголовок: {0}", titleBook);
        }
    }

    class Author
    {
        public string AuthorName;

        public void Show()
        {
            Console.WriteLine("Имя автора: {0}", AuthorName);
        }
    }

    class Content
    {
        public string ContentBook;

        public void Show()
        {
            Console.WriteLine("Содержание: {0} ", ContentBook);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            Console.WriteLine("Введите имя книги:");
            book.Name = Console.ReadLine();

            var title = new Title();
            Console.WriteLine("Введите заголовок книги:");
            title.titleBook = Console.ReadLine();

            var author = new Author();
            Console.WriteLine("Введите имя автора:");
            author.AuthorName = Console.ReadLine();

            var content = new Content();
            Console.WriteLine("Введите содержание книги:");
            content.ContentBook = Console.ReadLine();

            book.Show();
            title.Show();
            author.Show();
            content.Show();
        }
    }
}
