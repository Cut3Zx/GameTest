using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject startMenu;
    public GameObject settingMenu;
    void Start()
    {
        startMenu.SetActive(true);
        settingMenu.SetActive(false);
    }
    public void StartClick()
    {
        SceneManager.LoadScene("PlayGame");
    }
    public void SettingClick()
    {
        startMenu.SetActive(false);
        settingMenu.SetActive(true);
    }
    public void BackClick()
    {
        startMenu.SetActive(true);
        settingMenu.SetActive(false);
    }
    public void ExitClick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
