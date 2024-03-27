using UnityEngine;

public class BuyFastSeed : MonoBehaviour
{
    [SerializeField] private SeedMain _seedMain;
    [SerializeField] private Inventory _inventory;
    [SerializeField] private Money _money;

    public void BuyFast()
    {
        _money.BuySomething(_seedMain.FastSeed.Cost);
        _inventory.NumberFastSeed += 1;
    }
}
