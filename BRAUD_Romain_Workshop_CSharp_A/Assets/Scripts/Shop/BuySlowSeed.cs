using UnityEngine;

public class BuySlowSeed : MonoBehaviour
{
    private SeedMain _seedMain;
    private Inventory _inventory;
    private Money _money;

    public void BuySlow()
    {
        _money.BuySomething(_seedMain.SlowSeed.Cost);
        _inventory.NumberSlowSeed += 1;
    }
}
