using UnityEngine;

/// <summary>
/// This Script is to set up the button that will sell the "Small Seeds" if the player has at least one with him.
/// </summary>

public class BuyFastSeed : MonoBehaviour
{
    /// <summary>
    /// We call SeedMain so that we can have the cost of the "Small Seed".
    /// </summary>
    [SerializeField] private SeedMain _seedMain;

    /// <summary>
    /// We call the Inventory so that when the player buy a "Small Seed", we add him one seed in his inventory.
    /// </summary>
    [SerializeField] private Inventory _inventory;

    /// <summary>
    /// We call Money so that when the player buy the seed, his money will be decreased by the cost of SeedMain.
    /// </summary>
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
