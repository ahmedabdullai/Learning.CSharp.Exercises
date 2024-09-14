using ExceptionHandling;



//StreamReader streamReader = null;

try
{
    //streamReader = new StreamReader(@"c:\file.zip");
    //var content = streamReader.ReadToEnd();




    //using (var streamReader = new StreamReader(@"c:\file.zip"))
    //{
    //    var content = streamReader.ReadToEnd();
    //}

    //var calculator = new Calculator();
    //var result = calculator.Divide(5, 0);




    var api = new YouTubeApi();
    var videos = api.GetVideos("Ahmed");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("You cannot devide by zero.");
}
catch (ArithmeticException ex)
{
    Console.WriteLine("Other message");
}
catch (Exception ex)
{
    //Console.WriteLine("An error occurred.");
    
    Console.WriteLine(ex.Message);
}
//finally
//{
//    if (streamReader != null)
//        streamReader.Dispose();
//}