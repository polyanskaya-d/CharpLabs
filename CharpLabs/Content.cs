using System;
using Internal;

namespace BookLibrary
{
    public class Content
    {
        private string content;

        public Content(string content)
        {
            this.content = content;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Content: {content}");
            Console.ResetColor();
        }

        public string BookContent
        {
            get { return content; }
            set { content = value; }
        }
    }
}
