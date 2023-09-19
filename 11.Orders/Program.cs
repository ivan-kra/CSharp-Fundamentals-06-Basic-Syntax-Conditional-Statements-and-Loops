int n = int.Parse(Console.ReadLine());

double totalPrice = 0;

for (int i = 0; i < n; i++)
{
    double pricePerCapsule = double.Parse(Console.ReadLine());
    int daysInMonth = int.Parse(Console.ReadLine());
    int capsulesCount = int.Parse(Console.ReadLine());
    double price = ((daysInMonth * capsulesCount) * pricePerCapsule);
    totalPrice += price;
    Console.WriteLine($"The price for the coffee is: ${price:F2}");
}

Console.WriteLine($"Total: ${totalPrice:F2}");