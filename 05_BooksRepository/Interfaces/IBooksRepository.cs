namespace _05_BooksRepository.Interfaces
{
    internal interface IBooksRepository
    {
        void AddBook(IBook book);
        IBook RemoveBook(string bookTitle);
        void ShowBooks();
        void ShowBooks(string bookTitle);//ShowBooksByTitle - лучше указывать явно имена параметров.
                                         //Например, в дальнейшем, добавится у книги поле Издательство и оно тоже сроковое.
                                         //Поиск по этим параметроам же придется разделять, а как?
        void ShowBooks(int releaseYear);//ShowBooksByReleaseYear
        void ShowBooks(IAuthor author);//ShowBooksByAuthor

    }
}
