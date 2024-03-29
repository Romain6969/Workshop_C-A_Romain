using UnityEngine;

/// <summary>
/// This Script is to regroupe every functions that can grow the seeds, so that it's more easy to call the functions.
/// </summary>

public class GrowPlantMain : MonoBehaviour
{
    /// <summary>
    /// We are calling GrowNormalPlant to have the function GrowNormal for "Typical Plant".
    /// </summary>
    [field :SerializeField] public GrowNormalPlant GrowNormalPlant { get; private set; }

    /// <summary>
    /// We are calling GrowFastPlant to have the function GrowFast for "Small Plant".
    /// </summary>
    [field :SerializeField] public GrowFastPlant GrowFastPlant { get; private set; }

    /// <summary>
    /// We are calling GrowSlowPlant to have the function GrowSlow for "Heavy Plant".
    /// </summary>
    [field: SerializeField] public GrowSlowPlant GrowSlowPlant { get; private set; }

    /// <summary>
    /// We are calling GrowMoneyPlant to have the function GrowMoney for "Golden Plant".
    /// </summary>
    [field :SerializeField] public GrowMoneyPlant GrowMoneyPlant { get; private set; }
}
