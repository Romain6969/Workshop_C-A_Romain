using UnityEngine;

public class BuyFastSeed : MonoBehaviour
{
    private SeedMain _seedMain;
    private Inventory _inventory;
    private Money _money;

    public void BuyFast()
    {
        _money.BuySomething(_seedMain.FastSeed.Cost);
        _inventory.NumberFastSeed += 1;
    }
}
