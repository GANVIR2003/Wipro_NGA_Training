// See https://aka.ms/new-console-template for more information
// Boxing is the process of converting a value type to an object type.
//Unboxing is the process of converting an object type back to a value type.

//Value type: Store value directly in memory (e.g., int, float, char). 
//reference type: Store a reference (address) to the value in memory (e.g., string, arrays, class objects).

//Ex Storing money in wallet compared to storing money in bank account.
//in terms of access speed Value types are faster than reference types.
//IN terms of space efficiency Value types are more space-efficient than reference types.
//Value types are based on Stack memory( fixed size) while reference types are based on Heap memory( unlimited).
//Boxing and unboxing can introduce performance overhead due to additional memory allocation and type conversion.
//ideally we should use less of boxing and unboxing in performance-critical applications.
//In C# Object type is the base type from which all other types derive. ex all types are devied from object type.
//types  in C# :
//1. Value types: int, float, double, char, bool, struct, enum
//2. Reference types: string, arrays, class, interface, delegate(function pointer)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 10;
            float b = 10.5f;
            double c = 20.99;
            char grade = 'A';
            bool isActive = true;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(grade);
            Console.WriteLine(isActive);

        }
    }
}

