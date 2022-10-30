using _05_BooksRepository.Interfaces;

namespace _05_BooksRepository.Entities
{
    internal class BookRepository : IBooksRepository
        //Это же хранилище для книг - почему оно выводит информацию в консоль?
        //Оно должно только работать с данными или передавать информацию о записях наружу.
    {
        List<IBook> _books = new();//где private?

        public BookRepository(BooksSeeder seeder, int booksCount)
        {
            seeder.SeedBooks(_books, booksCount);
        }

        public void AddBook(IBook book)
        {
            _books.Add(book);
        }

        public IBook RemoveBook(string bookTitle)
        {
            var book = _books.FirstOrDefault(x => x.Title == bookTitle);
            if (book is null)
                throw new ArgumentException("Book with this title not found");//was not found - а вообще зачем тут, да и в других местах, вывод в консоль на английском?
            
            //И да книга не найдена, это нормально. Зачем же выбрасывать исключение?
            //Выбран неверный тип для исключения - тут подойдет InvalidOperationException            
                     
            _books.Remove(book);
            return book;
        }

        public void ShowBooks()
        {
            if(_books.Count <= 0)
            {
                Console.WriteLine("Repository has no any books");
                return;
            }

            Console.WriteLine("Repository has next books:");
            foreach (var book in _books)
            //{ Мое пожелание - оборачивать такие конструкции в фигурные скобки.
                Console.WriteLine(book);
            //}
        }

        public void ShowBooks(string bookTitle)
        {
            if (_books.Count <= 0)
            {
                Console.WriteLine("Repository has no any books");
                return;
            }

            var books = _books.FindAll(x => x.Title == bookTitle);
            if (!books.Any())
            {
                Console.WriteLine("Repository has no any books with this title");
                return;
            }

            Console.WriteLine("Repository has next books with this title:");
            foreach (var book in books)
                Console.WriteLine(book);
        }

        public void ShowBooks(int releaseYear)
        {
            if (_books.Count <= 0)
            {
                Console.WriteLine("Repository has no any books");
                return;
            }

            var books = _books.FindAll(x => x.ReleaseYear == releaseYear);
            if (!books.Any())
            {
                Console.WriteLine("Repository has no any books with this release year");
                return;
            }

            Console.WriteLine("Repository has next books with this release year:");
            foreach (var book in books)
                Console.WriteLine(book);
        }

        public void ShowBooks(IAuthor author)
        {
            if (_books.Count <= 0)
            {
                Console.WriteLine("Repository has no any books");
                return;
            }

            var books = _books.FindAll(x => x.Author.Equals(author));
            if (!books.Any())
            {
                Console.WriteLine("Repository has no any books with this author");
                return;
            }

            Console.WriteLine("Repository has next books with this author:");
            foreach (var book in books)
                Console.WriteLine(book);
        }
    }
}
