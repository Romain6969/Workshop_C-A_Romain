using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This Script is for the player to be able to plant the seed that he/she want to plant.
/// </summary>

public class Dirt : MonoBehaviour
{
    /// <summary>
    /// We create a list of GameObjects so that we can instantiate the prefab of the seeds on the dirt.
    /// </summary>
    [field: SerializeField] public List<GameObject> Seeds { get;private set; }

    /// <summary>
    /// We call ChooseSeed so that we know wich seed we have to plant on the dirt.
    /// </summary>
    [SerializeField] private ChooseSeed _chooseSeed;

    /// <summary>
    /// We call Inventory, because when we plant the seed, we have to show to the player that he lost one seed.
    /// </summary>
    [SerializeField] private Inventory _inventory;

    /// <summary>
    /// We need the GameObject "Dirt" because we have to say where the seed has to be instantiated.
    /// </summary>
    [SerializeField] private GameObject _dirt;

    /// <summary>
    /// We call the merchant so that when the player is neer the dirt, a little UI will appear on top of the player to show him wich button he has to press.
    /// </summary>
    [SerializeField] private Merchant _merchant;

    /// <summary>
    /// We create a bool, because we need the player to not be able to plant another seed on the same dirt after he planted one.
    /// </summary>
    [field: SerializeField] public bool NormalSeedPlaced { get; set;}

    /// <summary>
    /// We create a bool, because we need the player to not be able to plant another seed on the same dirt after he planted one.
    /// </summary>
    [field: SerializeField] public bool FastSeedPlaced { get; set; }

    /// <summary>
    /// We create a bool, because we need the player to not be able to plant another seed on the same dirt after he planted one.
    /// </summary>
    [field: SerializeField] public bool SlowSeedPlaced { get; set; }

    /// <summary>
    /// We create a bool, because we need the player to not be able to plant another seed on the same dirt after he planted one.
    /// </summary>
    [field: SerializeField] public bool MoneySeedPlaced { get; set; }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag != "Player")
        {
            _merchant.ButtonImage.SetActive(false);
            return;
        }

        _merchant.ButtonImage.SetActive(true);

        if (!Input.GetKey(KeyCode.E)) return;

        if (NormalSeedPlaced != false || FastSeedPlaced != false || SlowSeedPlaced != false || MoneySeedPlaced != false) return;

        switch (_chooseSeed.WichSeed)
        {
            case 0:
                if (_inventory.NumberNormalSeed != 0)
                {
                    Instantiate(Seeds[0], _dirt.transform);
                    _inventory.NumberNormalSeed -= 1;
                    NormalSeedPlaced = true;
                    break;
                }
                break;
            case 1:
                if (_inventory.NumberFastSeed != 0)
                {
                    Instantiate(Seeds[1], _dirt.transform);
                    _inventory.NumberFastSeed -= 1;
                    FastSeedPlaced = true;
                    break;
                }
                break;
            case 2:
                if (_inventory.NumberSlowSeed != 0)
                {
                    Instantiate(Seeds[2], _dirt.transform);
                    _inventory.NumberSlowSeed -= 1;
                    SlowSeedPlaced = true;
                    break;
                }
                break;
            default:
                if (_inventory.NumberMoneySeed != 0)
                {
                    Instantiate(Seeds[3], _dirt.transform);
                    _inventory.NumberMoneySeed -= 1;
                    MoneySeedPlaced = true;
                    break;
                }
                break;
        }
    }
}
