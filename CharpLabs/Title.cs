using System;
using Internal;

namespace BookLibrary
{
    public class Title
    {
        private string title;

        public Title(string title)
        {
            this.title = title;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Title: {title}");
            Console.ResetColor();
        }

        public string GetTitle()
        {
            return title;
        }
    }
}
