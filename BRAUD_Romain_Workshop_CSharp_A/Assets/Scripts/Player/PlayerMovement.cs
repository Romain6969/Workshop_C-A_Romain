using UnityEngine;

/// <summary>
/// This script is for the movement of the player.
/// </summary>

public class PlayerMovement : MonoBehaviour
{
    /// <summary>
    /// We create an int for the speed at wich the player will be moving.
    /// </summary>
    [SerializeField] private int _speed;

    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(x, y);
        transform.Translate(movement * _speed * Time.deltaTime);
    }
}
