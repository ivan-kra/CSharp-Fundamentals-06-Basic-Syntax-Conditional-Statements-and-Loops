using System.ComponentModel.Design;

int peopleCount = int.Parse(Console.ReadLine());
string type = Console.ReadLine();
string day = Console.ReadLine();

double price = 0;
int businessPeople = 0;

if (type == "Students")
{
    if (day == "Friday")
    {
        price = peopleCount * 8.45;
    }
    else if (day == "Saturday")
    {
        price = peopleCount * 9.8;
    }
    else if (day == "Sunday")
    {
        price = peopleCount * 10.46;
    }

    if (peopleCount >= 30)
    {
        price = price * 0.85;
    }
}
else if (type == "Regular")
{
    if (day == "Friday")
    {
        price = peopleCount * 15.0;
    }
    else if (day == "Saturday")
    {
        price = peopleCount * 20.0;
    }
    else if (day == "Sunday")
    {
        price = peopleCount * 22.5;
    }

    if (peopleCount >= 10 && peopleCount <= 20)
    {
        price = price * 0.95;
    }
}
else if (type == "Business")
{

    if (peopleCount < 100) 
    {
        businessPeople = peopleCount;
    }
    else 
    {
        businessPeople = peopleCount - 10;
    }
    
    if (day == "Friday")
    {
        price = businessPeople * 10.90;
    }
    else if (day == "Saturday")
    {
        price = businessPeople * 15.60;
    }
    else if (day == "Sunday")
    {
        price = businessPeople * 16.0;
    }
}

Console.WriteLine($"Total price: {price:F2}");