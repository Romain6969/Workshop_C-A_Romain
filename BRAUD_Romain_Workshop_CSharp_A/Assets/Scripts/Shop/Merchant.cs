using UnityEngine;

/// <summary>
/// This script is to set the Merchant so that if the player is near the merchant, he can see his shop.
/// </summary>

public class Merchant : MonoBehaviour
{
    /// <summary>
    /// This is for the UI of the Shop, so that when the player goes to the shop, the UI will appear.
    /// </summary>
    [SerializeField] private GameObject _shopImage;

    /// <summary>
    /// This is for the player to know that he can access the shop when he is near it.
    /// </summary>
    [field: SerializeField] public GameObject ButtonImage { get; set; }

    private void Awake()
    {
        _shopImage.SetActive(false);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            ButtonImage.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                _shopImage.SetActive(true);
            }
        }
        else
        {
            ButtonImage.SetActive(false);
        }
    }
}
