using UnityEngine;

public class BuyFastSeed : MonoBehaviour
{
    [SerializeField] private SeedMain _seedMain;
    [SerializeField] private Inventory _inventory;
    [SerializeField] private Money _money;

    public void BuyFast()
    {
        if (_money.TotalMoney >= _seedMain.FastSeed.Cost)
        {
            _money.BuySomething(_seedMain.FastSeed.Cost);
            _inventory.NumberFastSeed += 1;
        }
    }
        
}
