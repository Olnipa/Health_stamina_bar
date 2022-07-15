int healthBarPosition = 0;
int manaBarPosition = 40;
int healthPercent = 0;
int manaPercent = 0;

while (true)
{
    DrawBar(healthPercent, "Здоровье", ConsoleColor.Red, healthBarPosition);
    DrawBar(manaPercent, "Мана", ConsoleColor.Blue, manaBarPosition);
    
    Console.WriteLine("\n");
    
    healthPercent = ReadNumbers("Укажите остаток жизней в %: ");
    manaPercent = ReadNumbers("Укажите остаток маны в %: ");
    Console.Clear();
}

static void DrawBar(int valuePercent, string name, ConsoleColor color, int position, int maxvalue = 20)
{
    Console.SetCursorPosition(position, 3);
    ConsoleColor defaultColor = Console.BackgroundColor;
    string bar = "";
    int value = maxvalue * valuePercent / 100;
    
    for (int i = 0; i < value; i++)
    {
        bar += ' ';
    }

    Console.Write($"{name} [");
    Console.BackgroundColor = color;
    Console.Write(bar);
    bar = "";

    for (int i = value; i < maxvalue; i++)
    {
        bar += ' ';
    }

    Console.BackgroundColor = ConsoleColor.White;
    Console.Write(bar);
    Console.BackgroundColor = defaultColor;
    Console.Write("]");
}
static int ReadNumbers(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}