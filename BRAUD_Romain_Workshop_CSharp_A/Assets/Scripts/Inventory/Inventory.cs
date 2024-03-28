using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// <summary>
/// This script is to set the Inventory system of the seeds that the player receive after buying them in the store.
/// </summary>

public class Inventory : MonoBehaviour
{
    [SerializeField] private List<TMP_Text> _numberSeedsText;
    [SerializeField] private List<GameObject> _uiSeeds;
    [SerializeField] private List<int> _seeds = new() { 0, 0, 0, 0 };
    [SerializeField]public int NumberNormalSeed {get; set;}
    [SerializeField]public int NumberFastSeed {get; set;}
    [SerializeField]public int NumberSlowSeed {get; set;}
    [SerializeField]public int NumberMoneySeed {get; set;}

    private void Start()
    {
        _uiSeeds[0].SetActive(false);
        _uiSeeds[1].SetActive(false);
        _uiSeeds[2].SetActive(false);
        _uiSeeds[3].SetActive(false);
    }

    private void FixedUpdate()
    {
        _seeds[0] = NumberNormalSeed;
        _seeds[1] = NumberFastSeed;
        _seeds[2] = NumberSlowSeed;
        _seeds[3] = NumberMoneySeed;

        _numberSeedsText[0].text = $"{NumberNormalSeed}";
        _numberSeedsText[1].text = $"{NumberFastSeed}";
        _numberSeedsText[2].text = $"{NumberSlowSeed}";
        _numberSeedsText[3].text = $"{NumberMoneySeed}";


        if (NumberNormalSeed < 0)
        {
            NumberNormalSeed = 0;
        }
        else if (NumberFastSeed < 0)
        {
            NumberFastSeed = 0;
        }
        else if(NumberSlowSeed < 0)
        {
            NumberSlowSeed = 0;
        }
        else if(NumberMoneySeed < 0)
        {
            NumberMoneySeed = 0;
        }
        if(NumberNormalSeed > 0)
        {
            _uiSeeds[0].SetActive(true);
        }
        if (NumberFastSeed > 0)
        {
            _uiSeeds[1].SetActive(true);
        }
        if (NumberSlowSeed > 0)
        {
            _uiSeeds[2].SetActive(true);
        }
        if (NumberMoneySeed > 0)
        {
            _uiSeeds[3].SetActive(true);
        }
    }
}
