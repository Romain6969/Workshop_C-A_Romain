using UnityEngine;

public class BuySlowSeed : MonoBehaviour
{
    [SerializeField] private SeedMain _seedMain;
    [SerializeField] private Inventory _inventory;
    [SerializeField] private Money _money;

    public void BuySlow()
    {
        _money.BuySomething(_seedMain.SlowSeed.Cost);
        _inventory.NumberSlowSeed += 1;
    }
}
