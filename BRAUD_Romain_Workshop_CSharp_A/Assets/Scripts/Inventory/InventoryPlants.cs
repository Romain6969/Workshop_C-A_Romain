using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryPlants : MonoBehaviour
{
    [SerializeField] private List<int> _plants = new() { 0, 0, 0, 0 };
    public int NumberNormalPlants { get; set; }
    public int NumberFastPlants { get; set; }
    public int NumberSlowPlants { get; set; }
    public int NumberMoneyPlants { get; set; }

    private void FixedUpdate()
    {
        _plants[0] = NumberNormalPlants;
        _plants[1] = NumberFastPlants;
        _plants[2] = NumberSlowPlants;
        _plants[3] = NumberMoneyPlants;
    }
}
