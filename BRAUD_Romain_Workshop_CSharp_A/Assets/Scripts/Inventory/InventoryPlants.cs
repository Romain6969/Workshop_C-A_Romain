using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// <summary>
/// This Script is to set the inventory systeme for the plants that the player receive after planting the seeds. 
/// </summary>

public class InventoryPlants : MonoBehaviour
{
    /// <summary>
    /// We create a list of texts so that we can modify more easily the text that will show how many plants the player have.
    /// </summary>
    [SerializeField] private List<TMP_Text> _numberPlantsText;

    /// <summary>
    /// We create a list of GameObjects so that we can activate them (show them to the player) when he at least obtain one plant.
    /// </summary>
    [SerializeField] private List<GameObject> _uiPlants;

    /// <summary>
    /// We create a list of ints so that we can modify more easily the number of plants the player have.
    /// </summary>
    [SerializeField] private List<int> _plants = new() { 0, 0, 0, 0 };

    /// <summary>
    /// We create an int that will represent the number of plants of "Typical Plants".
    /// </summary>
    public int NumberNormalPlants { get; set; }

    /// <summary>
    /// We create an int that will represent the number of plants of "Small Plants".
    /// </summary>
    public int NumberFastPlants { get; set; }

    /// <summary>
    /// We create an int that will represent the number of plants of "Heavy Plants".
    /// </summary>
    public int NumberSlowPlants { get; set; }

    /// <summary>
    /// We create an int that will represent the number of plants of "Golden Plants".
    /// </summary>
    public int NumberMoneyPlants { get; set; }

    /// <summary>
    /// We make sure that every UI are deactivated (not shown to the player).
    /// </summary>
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
