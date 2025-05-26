using UnityEngine;

public class LifeController : MonoBehaviour
{
    public int health = 10;

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Vita attuale: " + health);

        if (health <= 0)
        {
            Debug.Log("Il giocatore è stato sconfitto");
            Destroy(gameObject);
        }
    }

    public void TakeHeal(int amount)
    {
        health += amount;
        Debug.Log("Vita attuale: " + health);
    }
}
