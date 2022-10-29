using _05_BooksRepository.Interfaces;

namespace _05_BooksRepository.Entities
{
    internal class Book : IBook
    {
        public IAuthor Author { get; }

        public int ReleaseYear { get; }

        public string Title { get; }

        public Book(string title, int releaseYear, IAuthor author)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Author = author;
        }

        public override string ToString()
        {
            return $"\"{Title}\", Author:{Author}, Release year:{ReleaseYear}";
        }
    }
}
