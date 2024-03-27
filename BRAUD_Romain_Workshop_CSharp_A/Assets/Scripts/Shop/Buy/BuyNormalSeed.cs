using UnityEngine;

public class BuyNormalSeed : MonoBehaviour
{
    [SerializeField] private SeedMain _seedMain;
    [SerializeField] private Inventory _inventory;
    [SerializeField] private Money _money;

    public void BuyNormal()
    {
        _money.BuySomething(_seedMain.NormalSeed.Cost);
        _inventory.NumberNormalSeed += 1;
    }
}