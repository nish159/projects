/*
Write a program that prints out all even numbers from 0 to n. The program should not prompt the user to enter an integer n, 
and print all even numbers on the interval 0 to n with a comma seperator. If n is an odd number then the last number that is 
printed should be n-1.
A number is even if it is divisible by 2.
If the user enters a negative number then the program should not do anything.

Example 1
Program output:
Input n:

User input:
0

Program output:
0

Example 2
Program output:
Input n:

User input:
10

Program output:
0, 2, 4, 6, 8, 10

Example 3
Program output:
Input n:

User input:
9

Program output:
0, 2, 4, 6, 8
*/

// User inputs a positive number
Console.WriteLine("Please enter a positive integer: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("");

// If user inputs a negative number
if (n <= 0)
{
    Console.WriteLine($"{n} is an invalid number.");
}
else
{
    // Loop through array until target number is met
    for (int i = 0; i <= n; i += 2)
    {
        // Don't print a comma if we are printing the last integer
        // If n = 6, the last even number to print is 6
        // If n = 7, the last even number to print is 6
        if(i == n /*n is even */|| i == n - 1/* n is odd */)
        {
            Console.Write(i);
        }
        else
        {
            Console.Write(i + ", ");
        }
    }
    Console.WriteLine();
}

/*
Console.WriteLine("=====================");

    // 0, 2, 4, 6
    for( int i = 0; i <=n; i += 2)
    {
        // Don't print a comma before the first number
        if(i == 0)
        {
            Console.Write(i);
        }
        else
        {
            Console.Write(", " + i);
        }
    }
*/
