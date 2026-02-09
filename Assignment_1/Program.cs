/*
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
*/

// Switch :

Console.WriteLine("Enter Num1 :");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter Num2 :");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter The Operator :");
char @operator = Convert.ToChar(Console.ReadLine());

switch (@operator)
{ 
case '+':
        Console.WriteLine($"The REsult of Operator {@operator} for {num1} + {num2} is : {num1 + num2}");
        break;

    case '-':
        Console.WriteLine($"The REsult of Operator {@operator} for {num1} - {num2} is : {num1 - num2}");
        break;


        case '*':
        Console.WriteLine($"The REsult of Operator {@operator} for {num1} * {num2} is : {num1 * num2}");
        break;


        case '/':
        Console.WriteLine($"The REsult of Operator {@operator} for {num1} / {num2} is : {num1 / num2}");
        break;

}


