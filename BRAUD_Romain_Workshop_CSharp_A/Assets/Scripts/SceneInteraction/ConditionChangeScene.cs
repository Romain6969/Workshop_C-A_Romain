using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// This Script is for the game, when the player reaches the total amount of money of 2500 $, the game will automatically change scene.
/// </summary>

public class ConditionChangeScene : MonoBehaviour
{
    /// <summary>
    /// We call Money to get the Total amount of money the player have.
    /// </summary>
    [SerializeField] private Money _money;

    /// <summary>
    /// We create a string that is used to call wich scene the player have to go to.
    /// </summary>
    [SerializeField] private string _scene;

    private void FixedUpdate()
    {
        if (_money.TotalMoney >= 2500)
        {
            SceneManager.LoadScene(_scene);
        }
    }
}
