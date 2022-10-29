using _05_BooksRepository.Interfaces;

namespace _05_BooksRepository.Entities
{
    internal class Author : IAuthor
    {
        public string FirstName { get; } = string.Empty;

        public string LastName { get; } = string.Empty;


        public Author(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is null || obj is not IAuthor)
                return false;

            var author = obj as IAuthor;

            return author!.FirstName.Equals(FirstName) && author.LastName.Equals(LastName);
        }
    }
}
