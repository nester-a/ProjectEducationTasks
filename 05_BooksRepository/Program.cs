using _05_BooksRepository.Entities;

var seeder = new BooksSeeder();
var booksRepo = new BookRepository(seeder, 20);

booksRepo.ShowBooks("Фантастика");

Console.WriteLine("Work ends");
Console.ReadLine();
