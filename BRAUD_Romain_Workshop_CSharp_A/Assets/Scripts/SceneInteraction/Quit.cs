using UnityEngine;

/// <summary>
/// This Script is for any buttons that when they are pressed, the player will leave the game in the build version of the game. 
/// </summary>

public class Quit : MonoBehaviour
{
    public void JustQuit()
    {
        Application.Quit();
    }
}
