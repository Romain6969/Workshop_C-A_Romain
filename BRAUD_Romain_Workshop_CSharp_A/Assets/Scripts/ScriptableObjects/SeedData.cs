using UnityEngine;

/// <summary>
/// This script is to set the ScriptableObjects of the seeds.
/// </summary>

[CreateAssetMenu(fileName = "Seed", menuName = "newSeed")]

public class SeedData : ScriptableObject
{   
    [field: SerializeField] public float GrowTime { get; private set; }
    [field: SerializeField] public int Cost { get; private set; }
    [field: SerializeField] public int Gain { get; private set; }
    [field: SerializeField] public string Name { get; private set; }
}
