namespace RetakesPluginShared;

/// <summary>
/// Provides information about how many rounds have been played with the current teams.
/// This capability is provided by the base retakes plugin.
/// </summary>
public interface IRetakesRoundTracker
{
    /// <summary>
    /// How many rounds have the current Terrorist team won in a row? Becomes <c>0</c> after a reshuffle,
    /// or when the Counter-Terrorists win.
    /// </summary>
    int ConsecutiveRoundsWon { get; }

    /// <summary>
    /// The teams will be reshuffled when <see cref="ConsecutiveRoundsWon"/> reaches this value.
    /// </summary>
    int ConsecutiveRoundWinsToScramble { get; }
}
