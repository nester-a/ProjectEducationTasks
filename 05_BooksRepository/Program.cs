using _05_BooksRepository.Entities;

var seeder = new BooksSeeder();
var booksRepo = new BookRepository(seeder, 20);

booksRepo.ShowBooks("Фантастика");
//Не хватает прогонки по другим сценариям - поиск по автору, по дате выхода, убрать книгу из хранилища. 

Console.WriteLine("Work ends");
Console.ReadLine();
