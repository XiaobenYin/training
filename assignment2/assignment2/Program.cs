// See https://aka.ms/new-console-template for more information
/*Test your Knowledge
1. When to use String vs. StringBuilder in C# ? - string is immutable whereas string builder is mutable
2. What is the base class for all arrays in C#? - the array class
3. How do you sort an array in C#? - we can use array.sort method
4. What property of an array object can be used to get the total number of elements in
an array? - length
5. Can you store multiple data types in System.Array? - no
6. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()? - The clone is of the same Type as the original Array. The CopyTo() method copies the elements into another existing array. It copies the elements of one array to another pre-existing array starting from a given index (usually 0).
*/

// copying an array
/*
int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int arrlength = arr1.Length;
int[] arr2 = new int[arrlength];
for (int i = 0; i < arr2.Length; i++)
{
    arr2[i] = arr1[i];
}
for (int i = 0; i < arr1.Length; i++)
{
    Console.Write($"{arr1[i]} ");
}
Console.Write("\n");
for (int i = 0; i < arr2.Length; i++)
{
    Console.Write($"{arr2[i]} ");
}
*/

// find prime numbers
/*
int i, j, p;
int[] arr = new int[5];

Console.Write("Enter array elements:");
for (i = 0; i < arr.Length; i++)
{
	arr[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("All Prime List:");
for (i = 0; i < arr.Length; i++)
{
	j = 2;
	p = 1;
	while (j < arr[i])
	{
		if (arr[i] % j == 0)
		{
			p = 0;
			break;
		}
		j++;
	}

	if (p == 1)
	{
		Console.Write(arr[i] + " ");
	}
}
*/

//