using UnityEngine;

/// <summary>
/// This Script is to set up the button that will sell the "Heavy Seeds" if the player has at least one with him.
/// </summary>

public class BuySlowSeed : MonoBehaviour
{
    /// <summary>
    /// We call SeedMain so that we can have the cost of the "Heavy Seed".
    /// </summary>
    [SerializeField] private SeedMain _seedMain;

    /// <summary>
    /// We call the Inventory so that when the player buy a "Heavy Seed", we add him one seed in his inventory.
    /// </summary>
    [SerializeField] private Inventory _inventory;

    /// <summary>
    /// We call Money so that when the player buy the seed, his money will be decreased by the cost of SeedMain.
    /// </summary>
    [SerializeField] private Money _money;

    public void BuySlow()
    {
        if(_money.TotalMoney >= _seedMain.SlowSeed.Cost)
        {
            _money.BuySomething(_seedMain.SlowSeed.Cost);
            _inventory.NumberSlowSeed += 1;
        }
    }
}
