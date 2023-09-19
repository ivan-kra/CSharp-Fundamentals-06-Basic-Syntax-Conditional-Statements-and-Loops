double amountOfMoney = double.Parse(Console.ReadLine());
int countOfStudents = int.Parse(Console.ReadLine());
double priceOfLightsaber = double.Parse(Console.ReadLine());
double priceOfRobes = double.Parse(Console.ReadLine());
double priceOfBelt = double.Parse(Console.ReadLine());

double priceForAllLightsabers = Math.Ceiling(countOfStudents * 1.1) * priceOfLightsaber;
double priceForAllRobes = countOfStudents * priceOfRobes;

int freeBelts = countOfStudents / 6; //целочислено делене
double priceForAllBelts = (countOfStudents - freeBelts) * priceOfBelt;

double finalPrice = priceForAllBelts + priceForAllLightsabers + priceForAllRobes;

if (finalPrice <= amountOfMoney)
{
    Console.WriteLine($"The money is enough - it would cost {finalPrice:F2}lv.");
}
else 
{
    double diff = finalPrice - amountOfMoney;
    Console.WriteLine($"John will need {diff:F2}lv more.");
}
