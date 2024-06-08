using Internal;

namespace BookLibrary
{
    public class Book
    {
        private Title title;
        private Author author;
        private Content content;
        private bool isTitleSet = false;

        public Book(string title, string author, string content)
        {
            this.title = new Title(title);
            this.author = new Author(author);
            this.content = new Content(content);
            isTitleSet = true;
        }

        public void SetTitle(string title)
        {
            if (!isTitleSet)
            {
                this.title = new Title(title);
                isTitleSet = true;
            }
            else
            {
                Console.WriteLine("The title of the book cannot be changed once set.");
            }
        }

        public string AuthorName
        {
            get { return author.AuthorName; }
            set { author.AuthorName = value; }
        }

        public string BookContent
        {
            get { return content.BookContent; }
            set { content.BookContent = value; }
        }

        public void Show()
        {
            title?.Show();
            author?.Show();
            content?.Show();
        }
    }
}
