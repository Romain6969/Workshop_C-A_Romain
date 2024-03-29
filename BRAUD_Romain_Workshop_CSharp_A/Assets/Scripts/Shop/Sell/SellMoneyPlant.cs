using UnityEngine;

/// <summary>
/// This Script is to set up the button that will sell the "Golden Plants" if the player has at least one with him.
/// </summary>

public class SellMoneyPlant : MonoBehaviour
{
    /// <summary>
    /// We call SeedMain so that we can have the gain of the "Golden Plant".
    /// </summary>
    [SerializeField] private SeedMain _seedMain;

    /// <summary>
    /// We call the InventoryPlants so that when the player sell a "Golden Plant", we remove him one plant in his inventory.
    /// </summary>
    [SerializeField] private InventoryPlants _inventoryPlants;

    /// <summary>
    /// We call Money so that when the player sell the plant, his money will be increased by the gain of SeedMain.
    /// </summary>
    [SerializeField] private Money _money;

    public void SellMoney()
    {
        if (_inventoryPlants.NumberMoneyPlants > 0)
        {
            _money.SellSomething(_seedMain.MoneySeed.Gain);
            _inventoryPlants.NumberMoneyPlants -= 1;
        }  
    }
}
