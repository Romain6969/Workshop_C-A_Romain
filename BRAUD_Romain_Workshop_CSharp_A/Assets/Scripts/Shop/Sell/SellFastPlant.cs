using UnityEngine;

public class SellFastPlant : MonoBehaviour
{
    [SerializeField] private SeedMain _seedMain;
    [SerializeField] private InventoryPlants _inventoryPlants;
    [SerializeField] private Money _money;

    public void SellFast()
    {
        if (_inventoryPlants.NumberFastPlants > 0)
        {
            _money.SellSomething(_seedMain.FastSeed.Gain);
            _inventoryPlants.NumberFastPlants -= 1;
        }
    }
}
