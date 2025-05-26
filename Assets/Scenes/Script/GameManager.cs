using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int totalCoins = 0;

    void Awake()
    {
        // Singleton pattern
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Mantieni tra scene
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddCoin()
    {
        totalCoins++;
        Debug.Log("Totale monete raccolte: " + totalCoins);
    }
}
