/*
Write a program that calculates the weighted average for homework assignments. The programs asks the user to enter the total number 
of homework assignments. For every assignment the program prompts the user to enter the points received for the assignment along with 
the total number of points possible to receive for that assignment. The program should calculate total points received and total points 
available. The program should also calculate the weighted average for the assignments and print the number with two decimal places.

Calculation for weighted average:
                                        weighted average = points received/available points · 100

Requirements
The number of assignments must be positive, if the user enters a number less than
one the program should exit and print the following text:
Number of assignments must be greater than 1!

Points received for an assignment must be a positive number. If the user enters a negative number the 
program should exit and print the following text:
Received points must be a positive number!

Total available points for an assignment must be a positive number. If the user enters a negative number 
the program should exit and print the following text:
Total points available must be a positive number!

Received points for an assignment cannot exceed the total points for that assignment. If that occurs the 
program should exit and print the following text: 
Received score can not exceed total available points!

Example 1
Program output:
Enter the number of homework assignments:
User input:
0

Program output:
Number of assignments must be greater than 1!

Example 2
Program output:
Enter the number of homework assignments:

User input:
1
Program output:
Points received for homework assignments 1:

User input:
-1

Program output:
Received points must be a positive number!

Example 3
Program output:
Enter the number of homework assignments:

User input:
1

Program output:
Points received for homework assignments 1:

User input:
5

Program output:
Total points available for homework assignment 1:

User input:
-1

Program output:
Total points possible must be positive number!

Example 4
Program output:
Enter the number of homework assignments:

User input:
1

Program output:
Points received for homework assignments 1:

User input:
5

Program output:
Total points available for homework assignment 1:

User input:
0

Program output:
Received score can not exceed total available points!

Example 5
Program output:
Enter the number of homework assignments:

User input:
3

Program output:
Points received for homework assignments 1:

User input:
8

Program output:
Total points available for homework assignment 1:

User input:
10

Program output:
Points received for homework assignments 2:

User input:
7

Program output:
Total points available for homework assignment 2:

User input:
9

Program output:
Points received for homework assignments 3:

User input:
6

Program output:
Total points available for homework assignment 3:

User input:
10

Program output:
Your total is 21.00 out of 29.00, or 72.41%.

Complete output:
Enter the number of homework assignments: 3

Points received for homework assignments 1: 8
Total points available for homework assignment 1: 10

Points received for homework assignments 2: 7
Total points available for homework assignment 2: 9

Points received for homework assignments 3: 6
Total points available for homework assignment 3: 10

Your total is 21.00 out of 29.00, or 72.41%.
*/

int homeworkAssignments = 0;

Console.WriteLine("Enter the number of homework assignments: ");
int numberOfAssignments = int.Parse(Console.ReadLine());
Console.WriteLine("");

if (numberOfAssignments <= 0)
{
    Console.WriteLine("Number of assignments must be greater than 1!");
    return;
}

for (int i = 0; i < numberOfAssignments; i++)
{
    homeworkAssignments++;

    Console.WriteLine($"Points received for homework assignment {homeworkAssignments}: ");
    int pointsReceived = int.Parse(Console.ReadLine());

    Console.WriteLine($"Total points available for homework assignment {homeworkAssignments}: ");
    int totalPoints = int.Parse(Console.ReadLine());
    Console.WriteLine("");

    if (pointsReceived < 0)
    {
        Console.WriteLine("Received points must be a positive number!");
        return;
    }
    else if (totalPoints < 0)
    {
        Console.WriteLine("Total points possible must be a positive number!");
        return;
    }
    else if (pointsReceived > totalPoints)
    {
        Console.WriteLine("Received score cannot exceed total available points!");
        return;
    }
}
