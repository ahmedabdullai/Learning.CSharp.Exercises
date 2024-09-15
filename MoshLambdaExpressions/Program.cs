//static int Square(int number)
//{
//    return number * number;
//}


////args => expression

//// () => ...
//// x => ...
//// (x,y,z) => ...



//Func<int, int> square = number => number * number;

//Console.WriteLine(square(5));






//const int factor = 5;

//Func<int, int> multiplier = n => factor * n;

//var result = multiplier(10);

//Console.WriteLine(result);






using MoshLambdaExpressions;

var books = new BookRepository().GetBooks();

var cheapBooks = books.FindAll(b => b.Price < 10);

foreach (var book in cheapBooks)
{
    Console.WriteLine(book.Title);
}