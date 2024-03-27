using UnityEngine;
using TMPro;

public class GrowPlants : MonoBehaviour
{
    [SerializeField] private SeedMain _seedMain;
    [SerializeField] private Dirt _dirt;
    [SerializeField] private InventoryPlants _inventoryPlants;
    [SerializeField] private TMP_Text _timeText;
    [SerializeField] private GameObject _activatetime;
    private float _normalGrowTime;
    private float _fastGrowTime;
    private float _slowGrowTime;
    private float _moneyGrowTime;

    private void Start()
    {
        _normalGrowTime = _seedMain.NormalSeed.GrowTime;
        _fastGrowTime = _seedMain.FastSeed.GrowTime;
        _slowGrowTime = _seedMain.SlowSeed.GrowTime;
        _moneyGrowTime = _seedMain.MoneySeed.GrowTime;
        _activatetime.SetActive(false);
    }

    private void FixedUpdate()
    {
        if (_dirt._normalSeedPlaced == true)
        {
            _activatetime.SetActive(true);
            _normalGrowTime -= Time.deltaTime;

            switch (_normalGrowTime)
            {
                case > 0:
                    float min = Mathf.FloorToInt(_normalGrowTime / 60);
                    float sec = Mathf.FloorToInt(_normalGrowTime % 60);
                    if (sec < 10)
                    {
                        _timeText.text = ($"0{min} : 0{sec}");
                        return;
                    }
                    else
                    {
                        _timeText.text = ($"0{min} : {sec}");
                    }
                    break;
                case <= 0:
                    _timeText.text = "Ready !";
                    _inventoryPlants.NumberNormalPlants += 1;
                    _normalGrowTime = _seedMain.NormalSeed.GrowTime;
                    Destroy(GameObject.Find("NormalSeed(Clone)"));
                    _activatetime.SetActive(false);
                    _dirt._normalSeedPlaced = false;
                    break;
            }
        }
        else if (_dirt._fastSeedPlaced == true)
        {
            _activatetime.SetActive(true);
            _fastGrowTime -= Time.deltaTime;

            switch (_fastGrowTime)
            {
                case > 0:
                    float min = Mathf.FloorToInt(_fastGrowTime / 60);
                    float sec = Mathf.FloorToInt(_fastGrowTime % 60);
                    if (sec < 10)
                    {
                        _timeText.text = ($"0{min} : 0{sec}");
                        return;
                    }
                    else
                    {
                        _timeText.text = ($"0{min} : {sec}");
                    }
                    break;
                case <= 0:
                    _timeText.text = "Ready !";
                    _inventoryPlants.NumberFastPlants += 1;
                    _fastGrowTime = _seedMain.FastSeed.GrowTime;
                    Destroy(GameObject.Find("FastSeed(Clone)"));
                    _activatetime.SetActive(false);
                    _dirt._fastSeedPlaced = false;
                    break;
            }
        }
        else if (_dirt._slowSeedPlaced == true)
        {
            _activatetime.SetActive(true);
            _slowGrowTime -= Time.deltaTime;

            switch (_slowGrowTime)
            {
                case > 0:
                    float min = Mathf.FloorToInt(_slowGrowTime / 60);
                    float sec = Mathf.FloorToInt(_slowGrowTime % 60);
                    if (sec < 10)
                    {
                        _timeText.text = ($"0{min} : 0{sec}");
                        return;
                    }
                    else
                    {
                        _timeText.text = ($"0{min} : {sec}");
                    }
                    break;
                case <= 0:
                    _timeText.text = "Ready !";
                    _inventoryPlants.NumberSlowPlants += 1;
                    _slowGrowTime = _seedMain.SlowSeed.GrowTime;
                    Destroy(GameObject.Find("SlowSeed(Clone)"));
                    _activatetime.SetActive(false);
                    _dirt._slowSeedPlaced = false;
                    break;
            }
        }
        else if (_dirt._moneySeedPlaced == true)
        {
            _activatetime.SetActive(true);
            _moneyGrowTime -= Time.deltaTime;

            switch (_moneyGrowTime)
            {
                case > 0:
                    float min = Mathf.FloorToInt(_moneyGrowTime / 60);
                    float sec = Mathf.FloorToInt(_moneyGrowTime % 60);
                    if (sec < 10)
                    {
                        _timeText.text = ($"0{min} : 0{sec}");
                        return;
                    }
                    else
                    {
                        _timeText.text = ($"0{min} : {sec}");
                    }
                    break;
                case <= 0:
                    _timeText.text = "Ready !";
                    _inventoryPlants.NumberMoneyPlants += 1;
                    _moneyGrowTime = _seedMain.MoneySeed.GrowTime;
                    Destroy(GameObject.Find("MoneySeed(Clone)"));
                    _activatetime.SetActive(false);
                    _dirt._moneySeedPlaced = false;
                    break;
            }
        }
    }
}
