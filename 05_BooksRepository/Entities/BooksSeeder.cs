using _05_BooksRepository.Interfaces;

namespace _05_BooksRepository.Entities
{
    internal class BooksSeeder
    {
        string[] _firstNames = new string[]
        {
            "Пётр",
            "Иван",
            "Александр",
            "Алексей",
            "Павел",
            "Антон"
        };

        string[] _lastNames = new string[]
        {
            "Петров",
            "Иванов",
            "Александров",
            "Алексеев",
            "Павлов",
            "Антонов"
        };

        string[] _titles = new string[]
        {
            "Книга обо всём",
            "Поваренная книга",
            "Любовный роман",
            "Эпос",
            "Фантастика",
            "Научная книга"
        };

        public void SeedBooks(List<IBook> repository, int booksCount)
        {
            if (booksCount <= 0)
                throw new ArgumentOutOfRangeException(nameof(booksCount));

            for (int i = 0; i < booksCount; i++)
            {
                repository.Add(GetRandomBook());
            }
        }

        private IBook GetRandomBook()
        {
            var title = GetRandomTitle();
            var releaseYear = GetRandomYear();
            var author = GetRandomAuthor();

            return new Book(title, releaseYear, author);
        }

        private int GetRandomYear()
        {
            var rnd = new Random();

            return rnd.Next(1700, 2023);
        }

        private IAuthor GetRandomAuthor()
        {
            var rnd = new Random();
            var rndFirstName = _firstNames[rnd.Next(0, _firstNames.Length)];
            var rndLastName = _lastNames[rnd.Next(0, _lastNames.Length)];

            return new Author(rndFirstName, rndLastName);
        }

        private string GetRandomTitle()
        {
            var rnd = new Random();
            return _titles[rnd.Next(0, _titles.Length)];
        }
    }
}
