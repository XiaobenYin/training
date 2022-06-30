// See https://aka.ms/new-console-template for more information
/* 
 * 1. Create a console application project named /02UnderstandingTypes/ that outputs the
number of bytes in memory that each of the following number types uses, and the
minimum and maximum values they can have: sbyte, byte, short, ushort, int, uint, long,
ulong, float, double, and decimal.
*/

Console.WriteLine("---------------------------------------------------");
Console.WriteLine(" Type      |       Minimum        |   Maximum      ");
Console.WriteLine("---------------------------------------------------");
Console.WriteLine(String.Format("{0,-10} | {1,-20} | {2,-10}", "sbyte", -128, 127));
Console.WriteLine(String.Format("{0,-10} | {1,-20} | {2,-10}", "byte", 0, 255));
Console.WriteLine(String.Format("{0,-10} | {1,-20} | {2,-10}", "short", -32768, 32767));
Console.WriteLine(String.Format("{0,-10} | {1,-20} | {2,-10}", "ushort", 0, 65535));
Console.WriteLine(String.Format("{0,-10} | {1,-20} | {2,-10}", "int", -2147483648, 2147483647));
Console.WriteLine(String.Format("{0,-10} | {1,-20} | {2,-10}", "uint", 0, 4294967295));
Console.WriteLine(String.Format("{0,-10} | {1,-20} | {2,-10}", "long", -9223372036854775808, 9223372036854775807));
Console.WriteLine(String.Format("{0,-10} | {1,-20} | {2,-10}", "ulong", 0, 18446744073709551615));
Console.WriteLine(String.Format("{0,-10} | {1,-20} | {2,-10}", "float", -1.0e-45, 3.4e38));
Console.WriteLine(String.Format("{0,-10} | {1,-20} | {2,-10}", "double", "-5e324", 1.7e308));
Console.WriteLine(String.Format("{0,-10} | {1,-20} | {2,-10}", "decimal", "-1.0*10e-28", 7.9e28));
Console.WriteLine("----------------------------------------------------");

/*
Write program to enter an integer number of centuries and convert it to years, days, hours,
minutes, seconds, milliseconds, microseconds, nanoseconds. Use an appropriate data
type for every data conversion. Beware of overflows!
*/

Console.WriteLine("Enter a century: ");

uint century = (uint)Convert.ToInt32(Console.ReadLine());
uint years = century * 100;
uint days = years * 365;
uint hours = days * 24;
uint minutes = hours * 60;
ulong seconds = minutes * 60;
ulong milliseconds = seconds * 1000;
ulong microseconds = milliseconds * 1000;
ulong nanoseconds = microseconds * 1000;
Console.WriteLine($"{century} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");

/*

Controlling Flow and Converting Types
Test your Knowledge
1. What happens when you divide an int variable by 0? - CS0020 Division by zero, there will be a compile error
2. What happens when you divide a double variable by 0? - the project can compile, but there's nothing show up
3. What happens when you overflow an int variable, that is, set it to a value beyond its
range? - it shows the constant value cannot be converted to this type
4. What is the difference between x = y++; and x = ++y;? - y++ executes the statement and then increments the value. ++y increments the value and then executes the statement.
5. What is the difference between break, continue, and return when used inside a loop
statement? - continue causes the next iteration of the loop to run immediately, whereas break terminates the loop and causes execution to resume after the loop, return will end the loop and return a value
6. What are the three parts of a for statement and which of them are required? - the keyword For that starts the loop, the condition being tested, and the EndFor keyword that terminates the loop
7. What is the difference between the = and == operators? - = is used for assignment, while == is used as logical condition whether the two elements on the different hand sides are equal or not
8. Does the following statement compile? for ( ; true; ) ; - yes
9. What does the underscore _ represent in a switch expression? - it means default condition
10. What interface must an object implement to be enumerated over by using the foreach
statement? - The IEnumerable interface
 */

//fizzbuzz

for(int i = 1; i < 100; i++)
{
    if(i % 15 == 0)
    {
        Console.WriteLine("FizzBuzz");
    } else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    } else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    } else
    {
        Console.WriteLine(i);
    }
}


//print a pyramid

Console.Write("Input number of rows for this pattern :");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    for (int j = 1; j <= n - i; j++)
    { 
        Console.Write(" "); 
    }
    for (int j = 1; j <= 2 * i - 1; j++)
    { 
        Console.Write("*"); 
    }
    Console.Write("\n");
}


//guess number

Random rnd = new Random();
int randomNum = (int)rnd.Next(1, 3);

Console.Write("Guess a number: ");
int guessedNumber = int.Parse(Console.ReadLine());
if (guessedNumber == randomNum)
{
    Console.WriteLine("You got it!");
}
if (guessedNumber < 1 || guessedNumber > 3)
{
    Console.WriteLine("Enter a valid number!");
}
if (guessedNumber < randomNum)
{
    Console.Write("Enter a larger number: ");
    guessedNumber = int.Parse(Console.ReadLine());
    if (guessedNumber < randomNum)
    {
        Console.Write("Enter a larger number: ");
        guessedNumber = int.Parse(Console.ReadLine());

    } else
    {
        Console.WriteLine("You got it!");
    }
}
if (guessedNumber > randomNum)
{
    Console.Write("Enter a smaller number: ");
    guessedNumber = int.Parse(Console.ReadLine());
    if (guessedNumber > randomNum)
    {
        Console.Write("Enter a larger number: ");
        guessedNumber = int.Parse(Console.ReadLine());

    }
    else
    {
        Console.WriteLine("You got it!");
    }
}


//calculate age and anniversary

Console.Write("Enter days: ");
int days = int.Parse(Console.ReadLine());
int age = Convert.ToInt32(Math.Floor(days/365.0));
int daysToNextAnniversary = 10000 - (days % 10000);
Console.WriteLine($"Your current age is: {age}, your next anniversary is: {daysToNextAnniversary}");


//greeting program

if (DateTime.Now.Hour <= 12)
{
    Console.WriteLine("Good Morning!");
}
else if (DateTime.Now.Hour <= 16)
{
    Console.WriteLine("Good Afternoon!");
}
else if (DateTime.Now.Hour <= 20)
{
    Console.WriteLine("Good Evening!");
}
else
{
    Console.WriteLine("Good Night!");
}


//counting up to 24
for(int i = 0; i <= 24; i++)
{
    if (i != 24)
    {
        Console.Write($"{i}, ");
    } else
    {
        Console.Write($"{i}");
    }
}
Console.Write("\n");
for (int i = 0; i <= 24; i+=2)
{
    if (i != 24)
    {
        Console.Write($"{i}, ");
    }
    else
    {
        Console.Write($"{i}");
    }
}
Console.Write("\n");
for (int i = 0; i <= 24; i += 3)
{
    if (i != 24)
    {
        Console.Write($"{i}, ");
    }
    else
    {
        Console.Write($"{i}");
    }
}
Console.Write("\n");
for (int i = 0; i <= 24; i += 4)
{
    if (i != 24)
    {
        Console.Write($"{i}, ");
    }
    else
    {
        Console.Write($"{i}");
    }
}
