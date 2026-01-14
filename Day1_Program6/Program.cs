// See https://aka.ms/new-console-template for more information
// What are nullabel type in C#
//Nullable types in C# allow value types(like int bool,DateTime) to represent an additional null values.
//They are useful when u need to inndicate the absence of value 
//Declaring a nullable int for a databse feild that can have null values
//It can be declared using ? syntax for the cse of char value type in C# for user input which is optional
int? age = null;
char? middleInitial = null;
Console.WriteLine($"Age: {age}, Middle Initial: {middleInitial}");
//Nullable type was introduced in C# version 2.0 along with generic and partial classes
//We  can create Diferent feature list as PeriodicTimer C# version relaeases 
//C# 1.0 - Initial release 
//C# 2.0 - Introduced Generics, Nullable Types, Partial Classes: two classes are allowed to be defined in separate files with exact same name 
//C# 3.0 - Introduced LINQ, Lambda Expressions, Extension Methods
//C#  4.0 - Introduced Dynamic Binding, Named and Optional Arguments
//C# 5.0 - Introduced Async and Await for asynchronous programming widely used in API calls
//C# 6.0 - Introduced Auto-Property Initializers, Expression-bodied Members
//C# 7.0 - Introduced Tuples, Pattern Matching, Local Functions
//C# 8.0 - Introduced Nullable Reference Types, Async Streams, Ranges and Indices
//C# 9.0 - Introduced Records, Init-only Properties, Top-level Statements
//C# 10.0 - Introduced Global Using Directives, File-scoped Namespaces, Record Structs  
//C# 11.0 - Introduced Raw String Literals, Required Members, Generic Math


