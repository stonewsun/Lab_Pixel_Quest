using UnityEngine;
using UnityEngine.UI; // For UI Text

public class CoinCollector : MonoBehaviour
{
    public int coinCount = 0; // Total coins collected
    public Text coinText; // Drag your UI Text component here

    void Start()
    {
        UpdateCoinUI();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            coinCount++;
            Destroy(other.gameObject);
            UpdateCoinUI();
        }
    }

    void UpdateCoinUI()
    {
        if (coinText != null)
        {
            coinText.text = "Coins: " + coinCount;
        }
    }
}