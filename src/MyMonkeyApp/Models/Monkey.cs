namespace MyMonkeyApp.Models;

/// <summary>
/// Represents a monkey species with basic properties.
/// </summary>
public sealed class Monkey
{
    /// <summary>
    /// The common name of the monkey species.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// The typical geographic location of the species.
    /// </summary>
    public string? Location { get; init; }

    /// <summary>
    /// Estimated population (optional).
    /// </summary>
    public int? Population { get; init; }
}
