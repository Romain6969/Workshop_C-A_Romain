using UnityEngine;
using TMPro;

/// <summary>
/// This Script is to set the Money of the player that he will gain by selling, or he will lose by buying.
/// </summary>

public class Money : MonoBehaviour
{
    /// <summary>
    /// This represent the amount of money the player have.
    /// </summary>
    [field: SerializeField] public int TotalMoney { get; set;}

    /// <summary>
    /// this represent the UI of the money.
    /// </summary>
    [SerializeField] private TMP_Text _textMoney;

    public void BuySomething(int money)
    {
        TotalMoney = TotalMoney - money;
    }

    public void SellSomething(int money)
    {
        TotalMoney = TotalMoney + money;
    }

    private void FixedUpdate()
    {
        _textMoney.text = $"{TotalMoney} $";
    }
}
