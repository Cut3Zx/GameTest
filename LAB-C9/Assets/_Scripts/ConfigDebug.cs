using UnityEngine;

public class ConfigDebug : MonoBehaviour
{
    public GameConfig config;

    void Start()
    {
        Debug.Log("Config: " + config.playerSpeed);
    }
}