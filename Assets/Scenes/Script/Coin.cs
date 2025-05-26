using UnityEngine;

public class Coin : MonoBehaviour
{
    public static int coins = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            coins++;
            Debug.Log("Coins: " + coins);
            Destroy(gameObject);
        }
    }
}
