namespace MagicVilla.VillaAPI.Logging;

public class LoggingV2 : ILogging
{
    public void Log(string message, string type)
    {
        switch (type)
        {
            case "error":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write($"ERROR");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine($" : {message}");
                break;
            case "warning":
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.Write($"WARNING");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine($" : {message}");
                break;

            case "info":
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write($"INFO");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine($" : {message}");
                break;
            default:
                Console.WriteLine(message);
                break;
        }
    }
}
