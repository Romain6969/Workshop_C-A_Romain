using UnityEngine;

public class SellMoneyPlant : MonoBehaviour
{
    [SerializeField] private SeedMain _seedMain;
    [SerializeField] private InventoryPlants _inventoryPlants;
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
