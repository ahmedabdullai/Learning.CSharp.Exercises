﻿
string post = "This is supposed to be a very long post ...";

var shortenedPost = post.Shorten(5);

//IEnumerable<int> numbers = new List<int>() { 1, 5, 3 , 10, 2, 18};
//var max = numbers.Max();

Console.WriteLine(shortenedPost);