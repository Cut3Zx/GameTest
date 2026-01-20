using UnityEngine;

public class GameOverHandler : MonoBehaviour
{
    public GameObject gameOverPanel;

    private void OnEnable() => PlayerHealth.OnHealthChanged += CheckGameOver;
    private void OnDisable() => PlayerHealth.OnHealthChanged -= CheckGameOver;

    private void CheckGameOver(int health)
    {
        if (health <= 0)
        {
            gameOverPanel.SetActive(true);
            UnityEngine.Debug.Log("Player Died!");
        }
    }
}