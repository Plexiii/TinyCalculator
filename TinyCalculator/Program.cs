Console.WriteLine("== Tiny calculator ==");

int dividend = ReadNumber("Dividend");
int divisor = ReadNumber("Divisor");

string op = GetOperator();

if (divisor == 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Divisor darf nicht 0 sein.");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    if (op == "/")
    {
        Console.WriteLine($"{dividend} / {divisor} = {dividend / divisor}");
    }
    if (op == "*")
    {
        Console.WriteLine($"{dividend} * {divisor} = {dividend * divisor}");
    }
    if (op == "+")
    {
        Console.WriteLine($"{dividend} + {divisor} = {dividend + divisor}");
    }
    if (op == "-")
    {
        Console.WriteLine($"{dividend} - {divisor} = {dividend - divisor}");
    }
    Console.ResetColor();
}
static int ReadNumber(string name)
{
    while (true)
    {
        Console.Write($"{name}: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int dividend))
        {
            return dividend;
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{input} is not a number.");
        Console.ResetColor();
    }
}
string GetOperator()
{
    while (true)
    {
        Console.Write("Select Operator: ");
        string op = Console.ReadLine();
        if (op == "/" || op == "*" || op == "+" || op == "-")
        {
            return op;
        }
    }
}