namespace Array_initialize
{
    internal class BookLibrary
    {
        private string _name;
        private Book[] _book;



        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Book[] Books
        {
            get { return _book; }
            set { _book = value; }
        }

        public BookLibrary()
        {
            _name = Name;
            _book = new Book[0];
        }
        public void Add(Book book)
        {
            Array.Resize(ref _book, Books.Length + 1);
            Books[Books.Length - 1] = book;
        }


        public void ShowAll()
        {
            for (int i = 0; i < Books.Length; i++)
            {
                Books[i].GetInfo();
            }
        }
        public void Remove(string book)
        {


            bool found = false;
            Book[] arr = new Book[Books.Length - 1];
            int j = 0;

            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Name.ToLower() != book.ToLower())
                {
                    if (j < arr.Length)
                    {
                        arr[j] = Books[i];
                        j++;
                    }
                }
                else
                {
                    found = true;
                }
            }

            if (found)
            {
                Books = arr;
                Console.WriteLine($"{book} kitabi silindi.");
            }
            else
            {
                Console.WriteLine($"{book}kitabi kitabxanada tapılmadı.");
            }
        }

        public void BorrowBook(string name)
        {
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Name == name)
                {
                    if (Books[i].IsAviable)
                    {
                        Books[i].IsAviable = false;
                        Console.WriteLine($"{name} kitabi basqa oxuyucu terefinden goturulmusdur.");
                    }
                    else
                    {
                        Console.WriteLine($"{name} kitabini goturdunuz.");
                    }
                    return;
                }
            }
            Console.WriteLine($" {name} kitabxanada yoxdur");

        }

        public void ReturnBook(string name)
        {
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Name == name)
                {
                    if (!Books[i].IsAviable)
                    {
                        Books[i].IsAviable = true;
                        Console.WriteLine($"{name} kitabi qaytarildi.");
                    }
                    else
                    {
                        Console.WriteLine($"{name} kitabi artiq movcuddur.");
                    }
                    return;
                }
            }
            Console.WriteLine($"{name} kitabi kitabxanada yoxdur.");
        }

        public void SearchByAuthor(string authorName)
        {
            bool found = false;
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Author == authorName)
                {
                    Books[i].GetInfo();
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine($"Bu kisi bele bir kitab yazmaybb");
            }


        }
    }
}