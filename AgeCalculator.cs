int currentYear = DateTime.Now.Year;    

Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();

Console.WriteLine("Enter the year you were born: ");
int birthYear = int.Parse(Console.ReadLine());

if (birthYear <= 1900 || birthYear >= currentYear)
{
    Console.WriteLine("You birth year must be between 1900 and 2022!");
}
else
{
    calculateAge(name, birthYear, currentYear);
}

static void calculateAge(string name, int birthYear, int currentYear)
{
    int age = currentYear - birthYear;
    Console.WriteLine($"Hi {name}, you will turn {age} this year!");
}