using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowPlants : MonoBehaviour
{
    private SeedMain _seedMain;
    private Dirt _dirt;
    private InventoryPlants _inventoryPlants;
    private float _growTime;

    private void FixedUpdate()
    {
        if (_dirt._normalSeedPlaced == true)
        {
            _growTime += Time.deltaTime;

            if (_growTime >= _seedMain.NormalSeed.GrowTime)
            {
                _inventoryPlants.NumberNormalPlants += 1;
                _growTime = 0;
                Destroy(gameObject);
                _dirt._normalSeedPlaced = false;
            }
        }
        else if (_dirt._fastSeedPlaced == true)
        {
            _growTime += Time.deltaTime;

            if (_growTime >= _seedMain.FastSeed.GrowTime)
            {
                _inventoryPlants.NumberFastPlants += 1;
                _growTime = 0;
                Destroy(gameObject);
                _dirt._fastSeedPlaced = false;
            }
        }
        else if (_dirt._slowSeedPlaced == true)
        {
            _growTime += Time.deltaTime;

            if (_growTime >= _seedMain.SlowSeed.GrowTime)
            {
                _inventoryPlants.NumberSlowPlants += 1;
                _growTime = 0;
                Destroy(gameObject);
                _dirt._slowSeedPlaced = false;
            }
        }
        else if (_dirt._moneySeedPlaced == true)
        {
            _growTime += Time.deltaTime;

            if (_growTime >= _seedMain.MoneySeed.GrowTime)
            {
                _inventoryPlants.NumberMoneyPlants += 1;
                _growTime = 0;
                Destroy(gameObject);
                _dirt._moneySeedPlaced = false;
            }
        }
    }
}
