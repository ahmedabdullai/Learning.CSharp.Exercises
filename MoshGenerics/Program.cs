//using MoshGenerics;


//var numbers = new List();
//numbers.Add(10);





//var book = new Book { Isbn = "1111", Title="C# Advanced"};

//var books = new BookList();
//books.Add(book);






//var numbersG = new GenericList<int>();
//numbersG.Add(10);

//var booksG = new GenericList<Book>();
//booksG.Add(book);



////System.Collections.Generic.Comparer



//var dictionary = new GenericDictionary<string, Book>();
//dictionary.Add("1234", new Book());



var number = new Nullable<int>();

Console.WriteLine("Has Value? " + number.HasValue);
Console.WriteLine("Value: " + number.GetValueOrDefault());