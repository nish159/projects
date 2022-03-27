// Declare variables
int totalPointsReceived = 0;
int receivedScore = 0;

// User input for the number of homework assignments
Console.WriteLine("Enter the number of homework assigments: ");
int homeworkAssignments = int.Parse(Console.ReadLine());

// Conditional statement 
if (homeworkAssignments <= 0)
{
Console.WriteLine("Number of assignments must be greater than 1!");
return;
}

// Loop the amount of homework assignments via user input
for (int i = 1; i <= homeworkAssignments; i++)
{
    Console.WriteLine($"Points received for homework assignment {i}: ");
    int pointsReceived = int.Parse(Console.ReadLine());

    if (pointsReceived <= 0)
    {
        Console.WriteLine("Received points must be a positive number!");
        return;
    }

    Console.WriteLine($"Total points available for homework assignments {i}: ");
    int totalPointsAvailable = int.Parse(Console.ReadLine());

    if (totalPointsAvailable <= 0)
    {
        Console.WriteLine("Total points possible must be a positive number!");
        return;
    }

    // Adding points received
    // Sum of the total points 
    totalPointsReceived = pointsReceived + totalPointsReceived;
    receivedScore = totalPointsAvailable + receivedScore;

    if (pointsReceived > receivedScore)
    {
        Console.WriteLine("Received score can not exceed total available points!");
        return;
    }
}

double average = calculateAverage(totalPointsReceived, receivedScore);
Console.WriteLine($"Your weighted average is: {totalPointsReceived} out of {receivedScore} or {average}");

// Method to calculate the weighted average of homework assignments
static double calculateAverage(int points, int totalPoints)
{
    // As long as one number is a double it will print a double number
    double average = points * 1.0 / totalPoints * 100;
    return average;
}
