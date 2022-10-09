namespace laboop3.2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Title title = new Title();
            Author author = new Author();
            Content content = new Content();

            Console.Write("Book:");
            book.SetBook(Console.ReadLine());
            Console.Write("Title:");
            title.SetTitle(Console.ReadLine());
            Console.Write("Author:");
            author.SetAuthor(Console.ReadLine());
            Console.Write("Content:");
            content.SetContent(Console.ReadLine());
            Console.WriteLine("");

            book.Show();
            title.Show();
            author.Show();
            content.Show();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboop3.2(1)
{
    internal class Content
    {
        private string content = "";
        public void SetContent(string content)
        {
            this.content = content;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Book:{content}");
        }
    }
}

