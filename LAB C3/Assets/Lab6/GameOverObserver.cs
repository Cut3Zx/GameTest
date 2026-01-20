using UnityEngine;

public class GameOverObserver : MonoBehaviour
{
    public GameObject gameOverPanel; // Kéo Panel Game Over vào đây

    // Hàm này sẽ nhận giá trị máu từ UnityEvent
    public void CheckHealth(int currentHealth)
    {
        if (currentHealth <= 0)
        {
            gameOverPanel.SetActive(true); // Hiện màn hình Game Over khi máu <= 0
        }
    }
}