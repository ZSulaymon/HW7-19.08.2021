using System;

namespace HW7._2
{
    class Book
    {
        public string Name;

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Имя книги: {0} ", Name);
            //Console.WriteLine($"Имя книги: {Name} ") ;
            Console.ResetColor();
        }
    }

    class Title
    {
        public string titleBook;

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Заголовок: {0}", titleBook);
            Console.ResetColor();
        }
    }

    class Author
    {
        public string AuthorName;

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Имя автора: {0}", AuthorName);
            Console.ResetColor();
        }
    }

    class Content
    {
        public string ContentBook;

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Содержание: {0} ", ContentBook);
            Console.ResetColor();
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
