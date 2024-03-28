using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This Script is for the player to be able to plant the seed that he/she want to plant.
/// </summary>

public class Dirt : MonoBehaviour
{
    [field: SerializeField] public List<GameObject> Seeds { get;private set; }
    [SerializeField] private ChooseSeed _chooseSeed;
    [SerializeField] private Inventory _inventory;
    [SerializeField] private GameObject _dirt;
    [SerializeField] private Merchant _merchant;
    [field: SerializeField] public bool NormalSeedPlaced { get; set;}
    [field: SerializeField] public bool FastSeedPlaced { get; set; }
    [field: SerializeField] public bool SlowSeedPlaced { get; set; }
    [field: SerializeField] public bool MoneySeedPlaced { get; set; }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            _merchant.ButtonImage.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                _merchant.ButtonImage.SetActive(false);

                if (NormalSeedPlaced == false && FastSeedPlaced == false && SlowSeedPlaced == false && MoneySeedPlaced == false)
                {
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
        }
        else
        {
            _merchant.ButtonImage.SetActive(false);
        }
    }
}
