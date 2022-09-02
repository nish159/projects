/*
Write a program that calculates how old a person will turn this year. The program should ask the user to input 
their name and birth year. 
If the user's birth year is 1990, the age is calculated as follows:
                                          age = 2022 - birth year = 2018 -1990
Requirements
Birth year needs to be between 1900 and 2022
If the birth year does not meet those conditions, the program should print out the following text:
"Your birth year must be between 1900 and 2022!"

Example 1
Program output:
Enter your name:

User input:
John

Program output:
Enter your birth year:

User input:
1990

Program output:
Hi John, you will turn 32 this year!

Example 2
Program output:
Enter your name:

User input:
John

Program output:
Enter your birth year:

User input:
2023

Program output:
Your birth year must be between 1900 and 2022!

Example 3
Program output:
Enter your name:

User input:
John

Program output:
Enter your birth year:

User input:
1900

Program output:
Your birth year must be between 1900 and 2022!
*/

// Initialize variable to get current year
int currentYear = DateTime.Now.Year;    

// User inputs name
Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();

// User inputs the year they were born
Console.WriteLine("Enter the year you were born: ");
int birthYear = int.Parse(Console.ReadLine());

// Birth year must be in between the given time frame
if (birthYear <= 1900 || birthYear >= currentYear)
{
    Console.WriteLine("You birth year must be between 1900 and 2022!");
}
else
{
    int age = calculateAge(birthYear, currentYear);
    Console.WriteLine($"Hi {name}, you will turn {age} this year!");
}

// Method to calculate how old the user will be 
static int calculateAge(int birthYear, int currentYear)
{
    int age = currentYear - birthYear;
    return age;
}
