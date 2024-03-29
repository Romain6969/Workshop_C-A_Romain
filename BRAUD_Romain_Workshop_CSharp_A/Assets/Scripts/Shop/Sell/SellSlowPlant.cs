using UnityEngine;

/// <summary>
/// This Script is to set up the button that will sell the "Heavy Plants" if the player has at least one with him.
/// </summary>

public class SellSlowPlant : MonoBehaviour
{
    /// <summary>
    /// We call SeedMain so that we can have the gain of the "Heavy Plants".
    /// </summary>
    [SerializeField] private SeedMain _seedMain;

    /// <summary>
    /// We call the InventoryPlants so that when the player sell a "Heavy Plant", we remove him one plant in his inventory.
    /// </summary>
    [SerializeField] private InventoryPlants _inventoryPlants;

    /// <summary>
    /// We call Money so that when the player sell the plant, his money will be increased by the gain of SeedMain.
    /// </summary>
    [SerializeField] private Money _money;

    public void SellSlow()
    {
        if(_inventoryPlants.NumberSlowPlants > 0)
        {
            _money.SellSomething(_seedMain.SlowSeed.Gain);
            _inventoryPlants.NumberSlowPlants -= 1;
        }
    }
}
