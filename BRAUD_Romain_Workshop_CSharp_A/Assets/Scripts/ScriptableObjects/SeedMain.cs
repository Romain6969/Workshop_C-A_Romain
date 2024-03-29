using UnityEngine;

/// <summary>
/// This Script is to regroupe every seeds (SriptableObjects) so that it is more easy to call multiple seeds.
/// </summary>

public class SeedMain : MonoBehaviour
{
    /// <summary>
    /// We are calling SeedData to have the ScriptableObject of "Typical Seed"
    /// </summary>
    [field :SerializeField] public SeedData NormalSeed { get; private set;}

    /// <summary>
    /// We are calling SeedData to have the ScriptableObject of "Small Seed"
    /// </summary>
    [field: SerializeField] public SeedData FastSeed { get; private set; }

    /// <summary>
    /// We are calling SeedData to have the ScriptableObject of "Heavy Seed"
    /// </summary>
    [field: SerializeField] public SeedData SlowSeed { get; private set; }

    /// <summary>
    /// We are calling SeedData to have the ScriptableObject of "Golden Seed"
    /// </summary>
    [field: SerializeField] public SeedData MoneySeed { get; private set; }
}
