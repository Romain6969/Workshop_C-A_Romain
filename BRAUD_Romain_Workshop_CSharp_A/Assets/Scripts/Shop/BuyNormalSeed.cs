using UnityEngine;

public class BuyNormalSeed : MonoBehaviour
{
    private SeedMain _seedMain;
    private Inventory _inventory;
    private Money _money;

    public void BuyNormal()
    {
        _money.BuySomething(_seedMain.NormalSeed.Cost);
        _inventory.NumberNormalSeed += 1;
    }
}
