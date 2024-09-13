// See https://aka.ms/new-console-template for more information
using System.Collections;


// Get all environment variables
IDictionary environmentVariables = Environment.GetEnvironmentVariables();

// Loop through each variable and print its name and value
foreach (DictionaryEntry variable in environmentVariables)
{
    Console.WriteLine($"{variable.Key} = {variable.Value}");
}