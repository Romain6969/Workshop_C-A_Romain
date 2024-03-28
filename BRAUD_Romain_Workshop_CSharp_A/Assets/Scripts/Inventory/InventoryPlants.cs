using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// <summary>
/// This Script is to set the inventory systeme for the plants that the player receive after planting the seeds. 
/// </summary>

public class InventoryPlants : MonoBehaviour
{
    [SerializeField] private List<TMP_Text> _numberPlantsText;
    [SerializeField] private List<GameObject> _uiPlants;
    [SerializeField] private List<int> _plants = new() { 0, 0, 0, 0 };
    public int NumberNormalPlants { get; set; }
    public int NumberFastPlants { get; set; }
    public int NumberSlowPlants { get; set; }
    public int NumberMoneyPlants { get; set; }

    private void Start()
    {
        _uiPlants[0].SetActive(false);
        _uiPlants[1].SetActive(false);
        _uiPlants[2].SetActive(false);
        _uiPlants[3].SetActive(false);
    }

    private void FixedUpdate()
    {
        _plants[0] = NumberNormalPlants;
        _plants[1] = NumberFastPlants;
        _plants[2] = NumberSlowPlants;
        _plants[3] = NumberMoneyPlants;

        _numberPlantsText[0].text = $"{NumberNormalPlants}";
        _numberPlantsText[1].text = $"{NumberFastPlants}";
        _numberPlantsText[2].text = $"{NumberSlowPlants}";
        _numberPlantsText[3].text = $"{NumberMoneyPlants}";

        if (NumberNormalPlants > 0)
        {
            _uiPlants[0].SetActive(true);
        }
        if (NumberFastPlants > 0)
        {
            _uiPlants[1].SetActive(true);
        }
        if (NumberSlowPlants > 0)
        {
            _uiPlants[2].SetActive(true);
        }
        if (NumberMoneyPlants > 0)
        {
            _uiPlants[3].SetActive(true);
        }
    }
}
