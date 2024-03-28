using UnityEngine;

/// <summary>
/// This script is to set the Merchant so that if the player is near the merchant, he can see his shop.
/// </summary>

public class Merchant : MonoBehaviour
{
    [SerializeField] private GameObject _shopImage;
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
                ButtonImage.SetActive(false);
                _shopImage.SetActive(true);
            }
        }
        else
        {
            ButtonImage.SetActive(false);
        }
    }
}
