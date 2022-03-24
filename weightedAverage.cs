Console.WriteLine("Enter the number of homework assigments: ");
int homeworkAssignments = int.Parse(Console.ReadLine());

Console.WriteLine("Points received for homework assignments: ");
int points = int.Parse(Console.ReadLine());

Console.WriteLine("Total points available for homework assignments: ");
int totalPoints = int.Parse(Console.ReadLine());

if (homeworkAssignments <= 0)
{
    Console.WriteLine("number of assignments must be greater than 1!");
}
else if (points <= 0)
{
    Console.WriteLine("Received points must be a positive number!");
}
else
{
    if (totalPoints <= 0)
    {
        Console.WriteLine("Total points must be a positive number!");
    }

    double average = calculateAverage(points, totalPoints);
    Console.WriteLine($"Your weighted average is: {average}");
}

static double calculateAverage(int points, int totalPoints)
{
    double average = points / totalPoints * 100;
    return average;
}
