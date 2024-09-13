


using MoshLINQ;

var books = new BookRepository().GetBooks();







//without LINQ
//var cheapBooks = new List<Book>();

//foreach (var book in books)
//{
//    if (book.Price < 10)
//        cheapBooks.Add(book);
//}






//// LINQ Query Operators
//var cheaperBooks = from b in books
//                   where b.Price < 10
//                   orderby b.Title
//                   select b;
//                    //select b.Title;

////with LINQ - LINQ Extension Methods
//var cheapBooks = books
//                    .Where(b => b.Price < 10)
//                    .OrderBy(b => b.Title); 
//                    //.Select(b => b.Title);



//foreach (var book in cheaperBooks)
//    Console.WriteLine(book.Title + " " + book.Price);

//foreach (var book in cheapBooks)
//    Console.WriteLine(book.Title + " " + book.Price);






var book = books.Last(b => b.Title == "C# Advanced Topics");
Console.WriteLine(book.Title + " " + book.Price);