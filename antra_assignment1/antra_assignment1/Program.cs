// See https://aka.ms/new-console-template for more information
/* 
Assignment #1 
*/

/* 
01 Introduction to C# and Data Types
Understanding Data Types
Test your Knowledge
1. What type would you choose for the following “numbers”?
A person’s telephone number - int
A person’s height - byte
A person’s age - byte
A person’s gender (Male, Female, Prefer Not To Answer) - enum
A person’s salary - decimal
A book’s ISBN - long
A book’s price - int
A book’s shipping weight - byte
A country’s population - int
The number of stars in the universe - ulong
The number of employees in each of the small or medium businesses in the
United Kingdom (up to about 50,000 employees per business) - ushort

2. What are the difference between value type and reference type variables? What is
boxing and unboxing? 
- Difference between value type and reference type
1. Value type will directly hold the value, while reference type will hold the memory address or reference for its value
2. Value types will be stored in stack memory while reference type will be stored in heap memory
3. Value type will not be collected by garbage collector, while reference type will be collected by garbage collector
4. Value type can be created by Struct or Enum, while reference type can be created by classes, interfaces, delegates, array
5. value type cannot accept null values but reference types can accept null values

- Boxing and unboxing
1. boxing: convert a value type into a reference type
2. unboxing: convert a reference type back to value type

3. What is meant by the terms managed resource and unmanaged resource in .NET


4. Whats the purpose of Garbage Collector in .NET?
The garbage collector works as the automatic memory manager which helps to dynamically manage the allocation and to release the memory. The garbage collector only works on heap memory. 
*/

/*
 Playing with Console App
Modify your console application to display a different message. Go ahead and
intentionally add some mistakes to your program, so you can see what kinds of error
messages you get from the compiler. The more familiar you are with these messages, and
what causes them, the better you'll be at diagnosing problems in your programs that you /
didn't/ intend to add!
Using just the ReadLine and WriteLine methods and your current knowledge of variables,
you can have the user pass in quite a few bits of information. Using this approach, create a
console application that asks the user a few questions and then generates some custom
output for them. For instance, your program could generate their "hacker name" by asking
them their favorite color, their astrology sign, and their street address number. The result
might be something like "Your hacker name is RedGemini480."
*/
string hackerName;
Console.WriteLine("Enter your name: ");
hackerName = Console.ReadLine();
Console.WriteLine($"Your hacker name is {hackerName}.");

/*
 
 
 */