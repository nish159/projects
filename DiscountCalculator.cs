/*
Write a program that calculates the sales price of a product. The program should ask the user to enter the full price of a product 
and the discount for that product. The full price of a product should be an integer. The discount factor should be a decimal number.
The sales price of the product should be an integer. The program should calculate and print out the sales product. If the full price 
of the product is $100 and the discount factor is 0.4 (40%) then the sales price should be calculated as follows:
                                    sales price = full price * (1 - discount) = 100 * (1 - 0.4) = $60
Requirements
The products full price is a positive integer
If the price does not meet those conditions, the program should print out the following text and terminate:
"The price must be a positive number!"

The discount factor should be on the interval [0:1] i.e greater than 0 and less than 1
If the discount factor does not meet those conditions, the program should print out the following text and terminate:
"The discount factor must be greater than 0 and less than 1!"

Example 1
Program output:
Enter the price of an item:

User input:
100

Program output:
Enter the discount factor:

User input:
0.4

Program output:
The sales price of an item is: 60

Example 2
Program output:
Enter the price of an item:

User input:
0

Program output:
Enter the discount factor:

Program output:
The program must be a positive number!

Example 3
Program output:
Enter the price of an item:

User input:
100

Program output:
Enter the discount factor:

User input:
1

Program output:
The discount factor must be greater than 0 and less than 1!
*/

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
