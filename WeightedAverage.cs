int totalPointsReceived = 0;
int totalSum = 0;

Console.WriteLine("Enter the number of homework assigments: ");
int homeworkAssignments = int.Parse(Console.ReadLine());

if (homeworkAssignments <= 0)
{
    Console.WriteLine("number of assignments must be greater than 1!");
    return;
}

for (int i = 1; i <= homeworkAssignments; i++)
{
    Console.WriteLine($"Points received for homework assignment {i}: ");
    int points = int.Parse(Console.ReadLine());

    if (points <= 0)
    {
        Console.WriteLine("Received points must be a positive number!");
        return;
    }

    Console.WriteLine($"Total points available for homework assignments {i}: ");
    int totalPoints = int.Parse(Console.ReadLine());

    if (totalPoints <= 0)
    {
        Console.WriteLine("Total points must be a positive number!");
        return;
    }

    totalPointsReceived = points + totalPointsReceived;
    totalSum = totalPoints + totalSum;

    Console.WriteLine(totalPointsReceived + "/" + totalSum);
}

double average = calculateAverage(totalPointsReceived, totalSum);
Console.WriteLine($"Your weighted average is: {average}");


static double calculateAverage(int points, int totalPoints)
{
    // As long as one number is a double it will print a double number
    double average = points * 1.0 / totalPoints * 100;
    return average;
}
