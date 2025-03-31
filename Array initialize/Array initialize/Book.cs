namespace Array_initialize
{
    internal class Book
    {
        private string _name;
        private string _author;
        private bool _isAviable = true;


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }


        public bool IsAviable
        {
            get { return _isAviable; }
            set { _isAviable = value; }
        }



        public Book(string name, string author)
        {
            _name = name;
            _author = author;
        }


        public void GetInfo()
        {
            Console.WriteLine($"Name: {_name} Author: {_author} IsAviable: {_isAviable}");
        }



    }
}
