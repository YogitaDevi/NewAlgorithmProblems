// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using UC2_BinarySearch;

BinarySearching binarysearch = new BinarySearching();
Console.WriteLine("Enter string value to search:");
string UserInput = Console.ReadLine();
Console.WriteLine("User input is :" + UserInput);
binarysearch.BinarySearch(UserInput);