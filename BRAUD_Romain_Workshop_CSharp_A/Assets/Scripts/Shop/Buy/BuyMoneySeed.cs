using UnityEngine;

public class BuyMoneySeed : MonoBehaviour
{
    [SerializeField] private SeedMain _seedMain;
    [SerializeField] private Inventory _inventory;
    [SerializeField] private Money _money;

    public void BuyMoney()
    {
        _money.BuySomething(_seedMain.MoneySeed.Cost);
        _inventory.NumberMoneySeed += 1;
    }
}
