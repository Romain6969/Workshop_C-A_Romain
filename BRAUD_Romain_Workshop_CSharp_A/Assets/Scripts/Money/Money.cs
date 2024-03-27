using UnityEngine;
using TMPro;

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
        _textMoney.text = $"{TotalMoney}";
    }
}
