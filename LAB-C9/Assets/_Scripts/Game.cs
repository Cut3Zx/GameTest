using UnityEngine;

public class Game : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Score: " + DataHolder.score);
    }
}