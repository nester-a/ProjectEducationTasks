using _05_BooksRepository.Interfaces;

namespace _05_BooksRepository.Entities
{
    internal class BooksSeeder // Странное название, а еще не отражает сути того, что делает класс.
                               // Я бы назвал BookCreator, и создал бы метод public IBook CreateBook (твой GetRandomBook()),
                               // чтобы другие объекты могли им пользоваться.
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
            //не нужно экономить буквы в имени переменных - исправить на random
            var rnd = new Random();
            //Неправильная работа с Random.
            //В более ранних версиях языка объекты, созданные в один и тот же момент времени (миллисекунду),
            //будут давать одно и тоже число при первом вызове метода Next.
            //По итогу у всех книг будет один и тот же год выпуска.
            //Лучше прописать Random как поле класса, инициализоровать его один раз (в поле или конструкторе)
            //и после дергать у этого поля метод Next - это гарантированно избавит от одинаковых значений.

            return rnd.Next(1700, 2023);
        }

        private IAuthor GetRandomAuthor()
        {
            var rnd = new Random();//см. выше
            var rndFirstName = _firstNames[rnd.Next(0, _firstNames.Length)];
            var rndLastName = _lastNames[rnd.Next(0, _lastNames.Length)];

            return new Author(rndFirstName, rndLastName);
        }

        private string GetRandomTitle()
        {
            var rnd = new Random();//см. выше
            return _titles[rnd.Next(0, _titles.Length)];
        }
    }
}
