int numLostGames = int.Parse(Console.ReadLine());
double priceHeadset = double.Parse(Console.ReadLine());
double priceMouse = double.Parse(Console.ReadLine());
double priceKeyboard = double.Parse(Console.ReadLine());
double priceDisplay = double.Parse(Console.ReadLine());

double totalPriceHeadsets = (numLostGames / 2) * priceHeadset;
double totalPriceMouse = (numLostGames / 3) * priceMouse;
double totalPriceKeyboard = (numLostGames / 6) * priceKeyboard;
double totalPriceDisplay = (numLostGames / 12) * priceDisplay;

double totalPrice = totalPriceHeadsets + totalPriceMouse + totalPriceKeyboard + totalPriceDisplay;

Console.WriteLine($"Rage expenses: {totalPrice:F2} lv.");