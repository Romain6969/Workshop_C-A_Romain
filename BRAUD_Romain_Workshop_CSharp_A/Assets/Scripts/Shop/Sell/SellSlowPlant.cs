using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellSlowPlant : MonoBehaviour
{
    [SerializeField] private SeedMain _seedMain;
    [SerializeField] private InventoryPlants _inventoryPlants;
    [SerializeField] private Money _money;

    public void SellSlow()
    {
        _money.SellSomething(_seedMain.SlowSeed.Gain);
        _inventoryPlants.NumberSlowPlants -= 1;
    }
}
