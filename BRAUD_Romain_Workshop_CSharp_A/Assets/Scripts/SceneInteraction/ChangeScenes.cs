using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// This Script is for any buttons that leads to another scene.
/// </summary>

public class ChangeScenes : MonoBehaviour
{
    [SerializeField] private string _scene;
    
    public void SceneChanger()
    {
        SceneManager.LoadScene(_scene);
    }
}
