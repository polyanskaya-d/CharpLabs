using System;

namespace BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створюємо книгу
            Book myBook = new Book("C# Programming", "John Doe", "This is a book about C# programming.");

            // Виводимо інформацію про книгу
            myBook.Show();

            // Змінюємо автора та зміст
            myBook.AuthorName = "Jane Smith";
            myBook.BookContent = "Updated content for the C# programming book.";

            // Виводимо оновлену інформацію про книгу
            myBook.Show();

            // Спроба змінити назву книги - має не дати змінити назву
            myBook.SetTitle("New Title");

            // Виводимо інформацію про книгу після спроби змінити назву
            myBook.Show();
        }
    }
}
