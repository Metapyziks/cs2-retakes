
using CounterStrikeSharp.API.Core;

namespace RetakesPluginShared;

/// <summary>
/// Allows custom assignment of teams before a round starts
/// </summary>
public interface IRetakesTeamAssigner
{
    HookResult Assign(IReadOnlyList<CCSPlayerController> terrorists, IReadOnlyList<CCSPlayerController> counterTerrorists);
}
