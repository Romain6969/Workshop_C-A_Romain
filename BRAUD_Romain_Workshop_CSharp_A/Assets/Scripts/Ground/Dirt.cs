using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Dirt : MonoBehaviour
{
    [field: SerializeField] public List<GameObject> _seeds { get;private set; }
    [SerializeField] private ChooseSeed _chooseSeed;
    [SerializeField] private Inventory _inventory;
    [SerializeField] private GameObject _dirt;
    [field: SerializeField] public bool _normalSeedPlaced { get; set;}
    [field: SerializeField] public bool _fastSeedPlaced { get; set; }
    [field: SerializeField] public bool _slowSeedPlaced { get; set; }
    [field: SerializeField] public bool _moneySeedPlaced { get; set; }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (Input.GetKey(KeyCode.R))
            {
                if(_normalSeedPlaced == false && _fastSeedPlaced == false && _slowSeedPlaced == false && _moneySeedPlaced == false)
                {
                    switch (_chooseSeed.WichSeed)
                    {
                        case 0:
                            if (_inventory.NumberNormalSeed != 0)
                            {
                                Instantiate(_seeds[0], _dirt.transform);
                                _inventory.NumberNormalSeed -= 1;
                                _normalSeedPlaced = true;
                                break;
                            }
                            break;
                        case 1:
                            if (_inventory.NumberFastSeed != 0)
                            {
                                Instantiate(_seeds[1], _dirt.transform);
                                _inventory.NumberFastSeed -= 1;
                                _fastSeedPlaced = true;
                                break;
                            }
                            break;
                        case 2:
                            if (_inventory.NumberSlowSeed != 0)
                            {
                                Instantiate(_seeds[2], _dirt.transform);
                                _inventory.NumberSlowSeed -= 1;
                                _slowSeedPlaced = true;
                                break;
                            }
                            break;
                        default:
                            if (_inventory.NumberMoneySeed != 0)
                            {
                                Instantiate(_seeds[3], _dirt.transform);
                                _inventory.NumberMoneySeed -= 1;
                                _moneySeedPlaced = true;
                                break;
                            }
                            break;
                    }
                }
            }
        }
    }
}
