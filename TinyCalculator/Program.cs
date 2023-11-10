Console.WriteLine("== Tiny calculator ==");

    int dividend = ReadNumber("Dividend");
bool con = true;
while (con)
{
    con = false;
    string op = GetOperator();
    int divisor = ReadNumber("Divisor");
    int sol = 0;

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
            sol = dividend / divisor;
        }
        if (op == "*")
        {
            sol = dividend * divisor;

        }
        if (op == "+")
        {
            sol = dividend + divisor;
        }
        if (op == "-")
        {
            sol = dividend - divisor;
        }
        Console.WriteLine($"{dividend} {op} {divisor} = {sol}");
        Console.ResetColor();
        dividend = sol;
        Console.WriteLine("Wollen sie weiterrechnen?");
        string x = Console.ReadLine();
        if(x == "y")
        {
            con = true;
        }
    }
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
    Console.Write("Select Operator: ");
    return Console.ReadLine();
}