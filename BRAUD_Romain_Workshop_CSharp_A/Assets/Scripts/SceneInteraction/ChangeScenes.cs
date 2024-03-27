using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    [SerializeField] private string Scene;
    
    public void SceneChanger()
    {
        SceneManager.LoadScene(Scene);
    }
}
