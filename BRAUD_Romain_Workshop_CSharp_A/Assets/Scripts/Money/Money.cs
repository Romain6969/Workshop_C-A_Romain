using UnityEngine;
using TMPro;

/// <summary>
/// This Script is to set the Money of the player that he will gain by selling, or he will lose by buying.
/// </summary>

public class Money : MonoBehaviour
{
    [field: SerializeField] public int TotalMoney { get; set;}
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
