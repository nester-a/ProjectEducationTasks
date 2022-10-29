namespace _05_BooksRepository.Interfaces
{
    internal interface IBooksRepository
    {
        void AddBook(IBook book);
        IBook RemoveBook(string bookTitle);
        void ShowBooks();
        void ShowBooks(string bookTitle);
        void ShowBooks(int releaseYear);
        void ShowBooks(IAuthor author);

    }
}
