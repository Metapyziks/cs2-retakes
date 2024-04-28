
using CounterStrikeSharp.API.Core;

namespace RetakesPluginShared;

/// <summary>
/// Allows custom assignment of teams before a round starts
/// </summary>
public interface IRetakesTeamAssigner
{
    void Assign(IList<CCSPlayerController> terrorists, IList<CCSPlayerController> counterTerrorists);
}
