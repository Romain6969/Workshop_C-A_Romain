using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script is to set the Inventory system.
/// </summary>

public class Inventory : MonoBehaviour
{
    [SerializeField] private List<int> _seeds = new() { 0, 0, 0, 0 };
    public int NumberNormalSeed {get; set;}
    public int NumberFastSeed {get; set;}
    public int NumberSlowSeed {get; set;}
    public int NumberMoneySeed {get; set;}

    private void FixedUpdate()
    {
        _seeds[0] = NumberNormalSeed;
        _seeds[1] = NumberFastSeed;
        _seeds[2] = NumberSlowSeed;
        _seeds[3] = NumberMoneySeed;

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
    }





}
