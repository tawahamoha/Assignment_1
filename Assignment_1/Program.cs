Console.WriteLine("Enter The Amount of your Reciet :");
double Amount  = Convert.ToDouble (Console.ReadLine());
double discount_1 = 0.2;
double discount_2 = 0.1;


if (Amount < 0 )
{
    Console.WriteLine("Check your reciet again");
}
else if (Amount >= 500)
{
    Console.WriteLine($"Your Reciet After the Discount is :{Amount - (Amount * discount_1)}");
}
else if(Amount > 300 &&  Amount<500)
{
    Console.WriteLine($"Your Reciet After the Discount is :{Amount - (Amount * discount_2)}");

}
else if (Amount <=300)
{
    Console.WriteLine($"There is NO Discount on Your Reciet :{ Amount}");

}