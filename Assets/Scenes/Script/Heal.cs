using UnityEngine;

public class Heal : MonoBehaviour
{
    public int healAmount = 4;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            LifeController life = other.GetComponent<LifeController>();
            if (life != null)
            {
                life.TakeHeal(healAmount);
            }
            Destroy(gameObject);
        }
    }
}
