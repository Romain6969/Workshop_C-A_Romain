using UnityEngine;

public class Dirt : MonoBehaviour
{
    private ChooseSeed _chooseSeed;
    private Inventory _inventory;
    [field: SerializeField] public bool _normalSeedPlaced { get; set;}
    [field: SerializeField] public bool _fastSeedPlaced { get; set; }
    [field: SerializeField] public bool _slowSeedPlaced { get; set; }
    [field: SerializeField] public bool _moneySeedPlaced { get; set; }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                switch (_chooseSeed.WichSeed)
                {
                    case 0:
                        if (_inventory.NumberNormalSeed == 0)
                        {
                            Instantiate(gameObject);
                            _normalSeedPlaced = true;
                            break;
                        }
                        break;
                    case 1:
                        if (_inventory.NumberFastSeed == 0)
                        {
                            Instantiate(gameObject);
                            _fastSeedPlaced = true;
                            break;
                        }
                        break;
                    case 2:
                        if (_inventory.NumberSlowSeed == 0)
                        {
                            Instantiate(gameObject);
                            _slowSeedPlaced = true;
                            break;
                        }
                        break;
                    default:
                        if (_inventory.NumberMoneySeed == 0)
                        {
                            Instantiate(gameObject);
                            _moneySeedPlaced = true;
                            break;
                        }
                        break;
                }
            }
        }
    }
}
