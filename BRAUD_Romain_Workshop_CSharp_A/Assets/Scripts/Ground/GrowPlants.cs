using UnityEngine;
using TMPro;

/// <summary>
/// This Script is for the seeds, when the seeds are planted int the dirt, they will start growing and then the player can receive the plant.
/// </summary>

public class GrowPlants : MonoBehaviour
{
    /// <summary>
    /// We call SeedMain so that we can have the time that each seeds needs to wait to grow.
    /// </summary>
    [SerializeField] private SeedMain _seedMain;

    /// <summary>
    /// We call Dirt to check wich seeds the player planted in the dirt.
    /// </summary>
    [SerializeField] private Dirt _dirt;

    /// <summary>
    /// We call InventoryPlants so that when a seed grew, we can put his plant in the inventory of plants.
    /// </summary>
    [SerializeField] private InventoryPlants _inventoryPlants;

    /// <summary>
    /// We call GrowPlantMain so that each seeds can grow.
    /// </summary>
    [SerializeField] private GrowPlantMain _growPlantMain;

    /// <summary>
    /// We need a text to show time.
    /// </summary>
    [SerializeField] private TMP_Text _timeText;

    /// <summary>
    /// We call parent of the text so that we can hide the time whene we don't use it.
    /// </summary>
    [SerializeField] private GameObject _activateTime;

    /// <summary>
    /// We create a float, he will represent the time the seed need to grow for the "Typical Seed".
    /// </summary>
    private float _normalGrowTime;

    /// <summary>
    /// We create a float, he will represent the time the seed need to grow for the "Small Seed".
    /// </summary>
    private float _fastGrowTime;

    /// <summary>
    /// We create a float, he will represent the time the seed need to grow for the "Heavy Seed".
    /// </summary>
    private float _slowGrowTime;

    /// <summary>
    /// We create a float, he will represent the time the seed need to grow for the "Golden Seed".
    /// </summary>
    private float _moneyGrowTime;

    private void Start()
    {
        _normalGrowTime = _seedMain.NormalSeed.GrowTime;
        _fastGrowTime = _seedMain.FastSeed.GrowTime;
        _slowGrowTime = _seedMain.SlowSeed.GrowTime;
        _moneyGrowTime = _seedMain.MoneySeed.GrowTime;
        _activateTime.SetActive(false);
    }

    private void FixedUpdate()
    {
        if (_dirt.NormalSeedPlaced == true)
        {
            _normalGrowTime -= Time.deltaTime;
            _growPlantMain.GrowNormalPlant.GrowNormal(_timeText, _normalGrowTime, _inventoryPlants, _seedMain, _dirt, _activateTime);

            if (_normalGrowTime <= 0)
            {
                _normalGrowTime = _seedMain.NormalSeed.GrowTime;
            }
        }
        else if (_dirt.FastSeedPlaced == true)
        {
            _fastGrowTime -= Time.deltaTime;
            _growPlantMain.GrowFastPlant.GrowFast(_timeText, _fastGrowTime, _inventoryPlants, _seedMain, _dirt, _activateTime);

            if(_fastGrowTime <= 0)
            {
                _fastGrowTime = _seedMain.FastSeed.GrowTime;
            }
        }
        else if (_dirt.SlowSeedPlaced == true)
        {
            _slowGrowTime -= Time.deltaTime;
            _growPlantMain.GrowSlowPlant.GrowSlow(_timeText, _slowGrowTime, _inventoryPlants, _seedMain, _dirt, _activateTime);

            if (_slowGrowTime <= 0)
            {
                _slowGrowTime = _seedMain.SlowSeed.GrowTime;
            }
        }
        else if (_dirt.MoneySeedPlaced == true)
        {
            _moneyGrowTime -= Time.deltaTime;
            _growPlantMain.GrowMoneyPlant.GrowMoney(_timeText, _moneyGrowTime, _inventoryPlants, _seedMain, _dirt, _activateTime);

            if (_moneyGrowTime <= 0)
            {
                _moneyGrowTime = _seedMain.MoneySeed.GrowTime;
            }
        }
    }
}
