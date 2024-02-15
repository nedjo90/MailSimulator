namespace MailSimulator;

public static class ConsoleColorManager
{
    public static void BackBlackForeRed()
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Red;
    }

    public static void BackBlackForeBlue()
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Blue;
    }
    
    public static void BackBlackForeGreen()
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Green;
    }
}