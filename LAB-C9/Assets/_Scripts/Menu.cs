using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        DataHolder.score = 100;
        SceneManager.LoadScene("Game");
    }
}