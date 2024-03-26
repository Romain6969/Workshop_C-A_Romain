using UnityEngine;

public class BuyMoneySeed : MonoBehaviour
{
    private SeedMain _seedMain;
    private Inventory _inventory;
    private Money _money;

    public void BuyMoney()
    {
        _money.BuySomething(_seedMain.MoneySeed.Cost);
        _inventory.NumberMoneySeed += 1;
    }
}
