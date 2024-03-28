using UnityEngine;
using UnityEngine.SceneManagement;

public class ConditionChangeScene : MonoBehaviour
{
    [SerializeField] private Money _money;
    [SerializeField] private string _scene;

    private void FixedUpdate()
    {
        if (_money.TotalMoney >= 2500)
        {
            SceneManager.LoadScene(_scene);
        }
    }
}
