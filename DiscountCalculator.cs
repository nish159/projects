Console.WriteLine("Enter the price of the item: ");
int itemAmount = int.Parse(Console.ReadLine());

Console.WriteLine($"You have entered: {itemAmount}");

if (itemAmount <= 0)
{
    Console.WriteLine("The price must be a positive number!");
}
else
{
    Console.WriteLine("Enter the discount amount: ");
    double discountAmount = double.Parse(Console.ReadLine());

    Console.WriteLine($"You have entered: {discountAmount}");

    if(discountAmount == 0 || discountAmount == 1)
    {
        Console.WriteLine("The discount factor must be greater than 0 and less than 1!");
    }

    int salesPrice = calculateDiscount(itemAmount, discountAmount);
    Console.WriteLine($"Your new total is: {salesPrice}");
}


static int calculateDiscount(int itemAmount, double discountAmount)
{

    int salesPrice = (int)(itemAmount - (itemAmount * discountAmount));
    return salesPrice;
}
