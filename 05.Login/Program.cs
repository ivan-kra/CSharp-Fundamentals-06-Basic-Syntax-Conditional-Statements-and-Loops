string name = Console.ReadLine();
string password = string.Empty;

foreach (char c in name)
{
    password = c + password;
}

int attempts = 0;

while (attempts < 4)
{
    string inputPasword = Console.ReadLine();
    attempts++;

    if (inputPasword == password)
    {
        Console.WriteLine($"User {name} logged in.");
        break;
    }
    else if (attempts == 4)
    {
        Console.WriteLine($"User {name} blocked!");
    }
    else if (inputPasword != password)
    {
        Console.WriteLine("Incorrect password. Try again.");
    }
}