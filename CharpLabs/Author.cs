using System;
using Internal;

namespace BookLibrary
{
    public class Author
    {
        private string author;

        public Author(string author)
        {
            this.author = author;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Author: {author}");
            Console.ResetColor();
        }

        public string AuthorName
        {
            get { return author; }
            set { author = value; }
        }
    }
}
