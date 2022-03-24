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
