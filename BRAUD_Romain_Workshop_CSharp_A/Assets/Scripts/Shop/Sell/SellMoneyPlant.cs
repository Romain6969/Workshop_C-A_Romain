using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellMoneyPlant : MonoBehaviour
{
    [SerializeField] private SeedMain _seedMain;
    [SerializeField] private InventoryPlants _inventoryPlants;
    [SerializeField] private Money _money;

    public void SellMoney()
    {
        _money.SellSomething(_seedMain.MoneySeed.Gain);
        _inventoryPlants.NumberMoneyPlants -= 1;
    }
}
