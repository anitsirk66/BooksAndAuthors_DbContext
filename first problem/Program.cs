// See https://aka.ms/new-console-template for more information
using first_problem.Data.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

Author author = new Author();

using (BooksAndAuthorsDbContext context = new BooksAndAuthorsDbContext())
{
    //var authors = new List<Author>
    //{
    //    new Author { First_Name = "James", Last_Name = "Clear", Nationality = "American" },
    //    new Author { First_Name = "Thomas", Last_Name = "Erikson", Nationality = "British" },
    //    new Author { First_Name = "Georgi", Last_Name = "Gospodinov", Nationality = "Bulgarian" },
    //    new Author { First_Name = "Ivan", Last_Name = "Vazov", Nationality = "Bulgarian" },
    //    new Author { First_Name = "Helena", Last_Name = "Armas", Nationality = "Spanish" }
    //};
    //context.Authors.AddRange(authors);
    //await context.SaveChangesAsync();

    //var books = new List<Books>
    //{
    //    new Books { Title = "Surrounded by idiots", Author_ID = 2, Publisher = "Ciela", Price = 26.80},
    //    new Books { Title = "Atomic Habits", Author_ID = 1, Publisher = "Penguin House", Price = 22.00},
    //    new Books { Title = "Time Shelter", Author_ID = 3, Publisher = "Egmont", Price = 29.90},
    //    new Books { Title = "Under The Yoke", Author_ID = 4, Publisher = "Ciela", Price = 20.99},
    //    new Books { Title = "The Spanish Love Deception", Author_ID = 5, Publisher = "Simon&Shuster", Price = 19.20}
    //};
    //context.Books.AddRange(books);
    //await context.SaveChangesAsync();

    Console.WriteLine("Изведете заглавията на всички книги с цена от 20 до 25 левa");
    var booksbetween20and25lv = context.Books.Where(p => p.Price >= 20 && p.Price <= 25).Select(a => a.Title);
    foreach (var item in booksbetween20and25lv)
    {
        Console.WriteLine(item);
    }

    Console.WriteLine("Изведете заглавията на всички книги, които са с по-малко от 10 символа ");
    var bookswithshorttitles = context.Books.Where(b => b.Title.Length < 10).Select(b => b.Title);
    foreach (var item in bookswithshorttitles)
    {
        Console.WriteLine(item);
    }

    Console.WriteLine("Изведете първо име и фамилия на всички български автори");
    var bookswithbulgarianauthors = context.Authors.Where(a => a.Nationality == "Bulgarian").Select(a => a.First_Name + a.Last_Name);
    foreach (var name in bookswithbulgarianauthors)
    { Console.WriteLine(name); }

    Console.WriteLine("Enter publisher please: ");
    string publisher = Console .ReadLine();
    var query6 = context.Books.Where(b=> b.Publisher == publisher).Select(c=> c.Title);
    foreach (var title in query6)
    { Console.WriteLine(title); }

    Console.WriteLine("Enter nationality please: ");
    string nationality = Console.ReadLine();
    var query7 = context.Authors.Where(d => d.Nationality == nationality).Select(c => c.First_Name + c.Last_Name);
    foreach (var name in query7)
    { Console.WriteLine(name); }

    Console.WriteLine("Enter last name please: ");
    var lastName = Console.ReadLine();
    var query8 = context.Books.Where(b => b.Author.Last_Name == lastName).Select(b => b.Title);
    foreach (var title in query8)
    { Console.WriteLine(title); }
}