using UnityEngine;

/// <summary>
/// This Script is to regroupe every seeds (SriptableObjects) so that it is more easy to call multiple seeds.
/// </summary>

public class SeedMain : MonoBehaviour
{
    [field :SerializeField] public SeedData NormalSeed { get; private set;}
    [field: SerializeField] public SeedData FastSeed { get; private set; }
    [field: SerializeField] public SeedData SlowSeed { get; private set; }
    [field: SerializeField] public SeedData MoneySeed { get; private set; }
}
