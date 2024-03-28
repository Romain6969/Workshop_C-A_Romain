using UnityEngine;

public class SellNormalPlant : MonoBehaviour
{
    [SerializeField] private SeedMain _seedMain;
    [SerializeField] private InventoryPlants _inventoryPlants;
    [SerializeField] private Money _money;

    public void SellNormal()
    {
        if (_inventoryPlants.NumberNormalPlants > 0)
        {
            _money.SellSomething(_seedMain.NormalSeed.Gain);
            _inventoryPlants.NumberNormalPlants -= 1;
        }  
    }
}
