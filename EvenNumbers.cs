// User inputs a positive number
Console.WriteLine("Please enter a positive integer: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("");

// Loop through array until target number is met
for (int i = 0; i <= n; i += 2)
{
    Console.WriteLine(i);
}
