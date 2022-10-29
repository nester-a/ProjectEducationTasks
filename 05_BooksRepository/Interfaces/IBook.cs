namespace _05_BooksRepository.Interfaces
{
    internal interface IBook
    {
        IAuthor Author { get; }
        int ReleaseYear { get; }
        string Title { get; }
    }
}
