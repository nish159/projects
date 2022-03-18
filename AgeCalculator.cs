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
    int age = calculateAge(birthYear, currentYear);
    Console.WriteLine($"Hi {name}, you will turn {age} this year!");
}

static void calculateAge(int birthYear, int currentYear)
{
    int age = currentYear - birthYear;
    return age;
}
