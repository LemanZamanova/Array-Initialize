namespace Array_initialize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookLibrary bookLibrary = new BookLibrary();
            bookLibrary.ShowAll();


            Book book1 = new Book("Kavgam", "Adolf Hitler");
            Book book2 = new Book("Sefiller", "Viktor Huqo");
            Book book3 = new Book("Danisiginla Heyati qazan", "Celale Nezeroglu");

            bookLibrary.Add(book1);
            bookLibrary.Add(book2);
            bookLibrary.Add(book3);

            bookLibrary.ShowAll();

            bookLibrary.BorrowBook("Kavgam");
            bookLibrary.BorrowBook("Kavgam");

            bookLibrary.ReturnBook("Kavgam");
            bookLibrary.ReturnBook("Kavgam");

            bookLibrary.SearchByAuthor("Viktor Huqo");

            bookLibrary.Remove("Sefiller");
            bookLibrary.ShowAll();
        }
    }
}
