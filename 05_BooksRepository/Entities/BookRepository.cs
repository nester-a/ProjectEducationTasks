using _05_BooksRepository.Interfaces;

namespace _05_BooksRepository.Entities
{
    internal class BookRepository : IBooksRepository
    {
        List<IBook> _books = new();

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
                throw new ArgumentException("Book with this title not found");

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
                Console.WriteLine(book);
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
