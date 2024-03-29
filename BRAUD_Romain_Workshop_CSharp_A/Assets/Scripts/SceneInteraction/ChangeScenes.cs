using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// This Script is for any buttons that leads to another scene.
/// </summary>

public class ChangeScenes : MonoBehaviour
{
    /// <summary>
    /// We create a string that is used to call wich scene the player have to go to.
    /// </summary>
    [SerializeField] private string _scene;
    
    public void SceneChanger()
    {
        SceneManager.LoadScene(_scene);
    }
}
