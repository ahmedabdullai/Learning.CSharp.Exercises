



//DateTime? date = null;

//Console.WriteLine(date.GetValueOrDefault());
//Console.WriteLine(date.HasValue);
//Console.WriteLine(date.Value);







//DateTime? date2 = new DateTime(2024,1,1);
//DateTime date3 = date2.GetValueOrDefault();
//Console.WriteLine(date3);

//DateTime? date4 = date3;
//Console.WriteLine(date4.GetValueOrDefault());






//// long way
//DateTime? date = null;
//DateTime date2;

//if (date != null)
//    date2 = date.GetValueOrDefault();
//else 
//    date2 = DateTime.Today;

//Console.WriteLine(date2);


// short way - null coalescing operator
DateTime? date = null;
DateTime date2 = date ?? DateTime.Today;

Console.WriteLine(date2);





