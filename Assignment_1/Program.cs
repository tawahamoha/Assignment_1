Console.WriteLine("Enter the invoice amount:");
double amount = Convert.ToDouble(Console.ReadLine());


if (amount <= 0)
{
    Console.WriteLine($"Invalid Amount: {amount}");
}
else if (amount >= 500)
{
    double discountAmount = (amount * 0.2);
    double finalAmount = amount - discountAmount;
    Console.WriteLine($"The Final Amount after the Discount (20%) is : {finalAmount}");
}
else if (amount < 500 && amount >= 300)
{
    double discountAmount = (amount * 0.1);
    double finalAmount = amount - discountAmount;
    Console.WriteLine($"The Final Amount after the Discount (10%) is : {finalAmount}");
}
else
{
    Console.WriteLine($"The Final Amount is: {amount}");
}