using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public SaveSystems saveSystem;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            saveSystem.data.currentScore += 100;
            if(saveSystem.data.currentScore > 500)
            {
                saveSystem.data.currentLevel++;
                saveSystem.SaveGame();
            }
        }
    }
}
