// User input of the item amount
Console.WriteLine("Enter the price of the item: ");
int itemAmount = int.Parse(Console.ReadLine());

// Confirm the item amount
Console.WriteLine($"You have entered: {itemAmount}");

// Condition if item amount is less than or equal to 0
if (itemAmount <= 0)
{
    Console.WriteLine("The price must be a positive number!");
}
else
{
    // User input of the discount amount
    Console.WriteLine("Enter the discount amount: ");
    double discountAmount = double.Parse(Console.ReadLine());

    // Confirm the discount amount
    Console.WriteLine($"You have entered: {discountAmount}");

    // Condition of discount amount
    if(discountAmount == 0 || discountAmount == 1)
    {
        Console.WriteLine("The discount factor must be greater than 0 and less than 1!");
    }

    int salesPrice = calculateDiscount(itemAmount, discountAmount);
    Console.WriteLine($"Your new total is: {salesPrice}");
}

// Method to calculate the discounted price of the item
static int calculateDiscount(int itemAmount, double discountAmount)
{

    int salesPrice = (int)(itemAmount - (itemAmount * discountAmount));
    return salesPrice;
}
