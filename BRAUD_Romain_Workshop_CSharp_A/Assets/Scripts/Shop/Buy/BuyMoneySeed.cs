using UnityEngine;

public class BuyMoneySeed : MonoBehaviour
{
    [SerializeField] private SeedMain _seedMain;
    [SerializeField] private Inventory _inventory;
    [SerializeField] private Money _money;

    public void BuyMoney()
    {
        if (_money.TotalMoney >= _seedMain.MoneySeed.Cost)
        {
            _money.BuySomething(_seedMain.MoneySeed.Cost);
            _inventory.NumberMoneySeed += 1;
        }   
    }
}
