using UnityEngine;

public class Money : MonoBehaviour
{
    [field: SerializeField] public int TotalMoney { get; private set;}

    public void BuySomething(int money)
    {
        TotalMoney = TotalMoney - money;
    }
}
