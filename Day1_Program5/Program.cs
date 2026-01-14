// See https://aka.ms/new-console-template for more information
using System.Text;
// String : In C# string is a sequence of characters used to represent text. Strings are immutable,
//meaning once created, they cannot be changed. You can create strings using double quotes. ex constants

string greeting = "Hello, World!"; // String literal

// You can also create strings using the String class constructor
string name = new string(new char[] { 'J', 'o', 'h', 'n' });


//In C#, strings can be concatenated using the + operator or the String.Concat method.
//Stringbuffer : In C#, StringBuilder is a mutable sequence of characters used for creating and manipulating strings efficiently,
//especially when performing multiple modifications. It is part of the System.Text namespace.

// Example of using StringBuilder in real life scenario
//Imagine you are building a text editor application where users can type and edit large documents.
StringBuilder document = new StringBuilder();
document.Append("This is the first Line of Documents.\n");
document.Append("This is the second line of documents.\n");
document.Append("This is the third line of documents.\n");
Console.WriteLine(document.ToString());
Console.WriteLine(GC.GetTotalMemory(false));//output total memory

//If we try above scenario using string literal it will create multiple string instance in memmory which is inefficient.
string doc = "";
doc += "Hii i am Chhavi\n";
doc += "I am learning C#.\n";
doc += "I love Coding.\n";
Console.WriteLine(doc);

//Each tiome we use =+ operator a new string instance is created inn memory which can lead to high memory consumption and performance for large documents.
Console.WriteLine(GC.GetTotalMemory(false));
Console.WriteLine(document.Capacity);
Console.WriteLine(doc.Length);


