using UnityEngine;

/// <summary>
/// This Script is to set up the button that will sell the "Golden Seeds" if the player has at least one with him.
/// </summary>

public class BuyMoneySeed : MonoBehaviour
{
    /// <summary>
    /// We call SeedMain so that we can have the cost of the "Golden Seed".
    /// </summary>
    [SerializeField] private SeedMain _seedMain;

    /// <summary>
    /// We call the Inventory so that when the player buy a "Golden Seed", we add him one seed in his inventory.
    /// </summary>
    [SerializeField] private Inventory _inventory;

    /// <summary>
    /// We call Money so that when the player buy the seed, his money will be decreased by the cost of SeedMain.
    /// </summary>
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
