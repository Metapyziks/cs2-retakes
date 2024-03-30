
using CounterStrikeSharp.API.Core;

namespace RetakesPluginShared;

/// <summary>
/// Allows custom allocation of weapons when a round starts.
/// </summary>
public interface IRetakesWeaponAllocator
{
    void Allocate(IReadOnlyList<CCSPlayerController> terrorists, IReadOnlyList<CCSPlayerController> counterTerrorists);
}
