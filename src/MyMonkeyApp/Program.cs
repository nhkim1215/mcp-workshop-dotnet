using MyMonkeyApp.Helpers;
using MyMonkeyApp.Models;

namespace MyMonkeyApp;

internal static class Program
{
    private static void ShowHeader()
    {
        Console.Clear();
        Console.WriteLine(@"  __  __             _                _   _      ");
        Console.WriteLine(@" |  \/  | ___  _ __ | | ___  ___  ___ | |_| |_ ___");
        Console.WriteLine(@" | |\/| |/ _ \| '_ \| |/ _ \/ __|/ _ \| __| __/ _ \");
        Console.WriteLine(@" | |  | | (_) | | | | |  __/\__ \ (_) | |_| ||  __/");
        Console.WriteLine(@" |_|  |_|\___/|_| |_|_|\___||___/\___/ \__|\__\___|");
        Console.WriteLine();
    }

    private static void ShowMonkeyDetail(Monkey monkey)
    {
        Console.WriteLine();
        Console.WriteLine($"-- {monkey.Name} --");
    Console.WriteLine("  (o)  (o)");
    Console.WriteLine(@"   \ \_/ /");
    Console.WriteLine(@"    \   /");
    Console.WriteLine("     ---");
        Console.WriteLine($"Location : {monkey.Location}");
        Console.WriteLine($"Population: {(monkey.Population.HasValue ? monkey.Population.Value.ToString() : "Unknown")}");
        Console.WriteLine();
    }

    private static void Main()
    {
        while (true)
        {
            ShowHeader();
            Console.WriteLine("1) List monkeys");
            Console.WriteLine("2) Get monkey details by name");
            Console.WriteLine("3) Pick a random monkey");
            Console.WriteLine("4) Exit");
            Console.WriteLine();
            Console.Write("Select an option: ");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input)) continue;

            switch (input.Trim())
            {
                case "1":
                    var monkeys = MonkeyHelper.GetMonkeys();
                    Console.WriteLine();
                    for (var i = 0; i < monkeys.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {monkeys[i].Name}");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.Write("Enter monkey name: ");
                    var name = Console.ReadLine();
                    var found = MonkeyHelper.GetMonkeyByName(name ?? string.Empty);
                    if (found is null)
                    {
                        Console.WriteLine("Monkey not found.");
                    }
                    else
                    {
                        ShowMonkeyDetail(found);
                    }
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    break;
                case "3":
                    var randomMonkey = MonkeyHelper.GetRandomMonkey();
                    ShowMonkeyDetail(randomMonkey);
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Unknown option. Press Enter to continue...");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
