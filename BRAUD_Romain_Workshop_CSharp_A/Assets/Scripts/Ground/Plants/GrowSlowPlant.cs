using UnityEngine;
using TMPro;

/// <summary>
/// This Script is for the "Heavy Seed", so that we can show the time that is left before the seed will grow, and that we can receive the plant.
/// </summary>

public class GrowSlowPlant : MonoBehaviour
{
    public void GrowSlow(TMP_Text timeText, float growTime, InventoryPlants inventoryPlants, SeedMain seedMain, Dirt dirt, GameObject activateTime)
    {
        activateTime.SetActive(true);

        switch (growTime)
        {
            case > 0:
                float min = Mathf.FloorToInt(growTime / 60);
                float sec = Mathf.FloorToInt(growTime % 60);
                if (sec < 10)
                {
                    timeText.text = ($"0{min} : 0{sec}");
                    return;
                }
                else
                {
                    timeText.text = ($"0{min} : {sec}");
                }
                break;
            case <= 0:
                timeText.text = "Ready !";
                inventoryPlants.NumberSlowPlants += 1;
                Destroy(GameObject.Find("SlowSeed(Clone)"));
                activateTime.SetActive(false);
                dirt.SlowSeedPlaced = false;
                break;
        }
    }
}
