using MyMonkeyApp.Models;

namespace MyMonkeyApp.Helpers;

/// <summary>
/// Helper methods to manage an in-memory list of monkeys.
/// </summary>
public static class MonkeyHelper
{
    private static readonly List<Monkey> _monkeys = new()
    {
        new Monkey { Name = "Capuchin", Location = "Central & South America", Population = 100000 },
        new Monkey { Name = "Howler", Location = "Central & South America", Population = 50000 },
        new Monkey { Name = "Macaque", Location = "Asia", Population = 200000 },
        new Monkey { Name = "Spider Monkey", Location = "Central & South America", Population = 30000 },
        new Monkey { Name = "Squirrel Monkey", Location = "Central & South America", Population = 120000 }
    };

    /// <summary>
    /// Returns all known monkeys.
    /// </summary>
    public static IReadOnlyList<Monkey> GetMonkeys() => _monkeys;

    /// <summary>
    /// Finds a monkey by case-insensitive name match.
    /// </summary>
    public static Monkey? GetMonkeyByName(string name)
    {
        if (string.IsNullOrWhiteSpace(name)) return null;
        return _monkeys.FirstOrDefault(m => string.Equals(m.Name, name, StringComparison.OrdinalIgnoreCase));
    }

    /// <summary>
    /// Returns a random monkey from the list.
    /// </summary>
    public static Monkey GetRandomMonkey()
    {
        var rand = new Random();
        return _monkeys[rand.Next(_monkeys.Count)];
    }
}
