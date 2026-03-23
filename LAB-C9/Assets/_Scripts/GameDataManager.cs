using UnityEngine;
using System.IO;

[System.Serializable]
public class PlayerData
{
    public string playerName;
    public int level;
    public int highScore;
}

public class GameDataManager : MonoBehaviour
{
    private string filePath;
    public PlayerData data;

    void Awake()
    {
        filePath = Application.persistentDataPath + "/playerData.json";

        LoadGame();
    }

    [ContextMenu("Save Game")]
    public void SaveGame()
    {
        string json = JsonUtility.ToJson(data, true);

        File.WriteAllText(filePath, json);

        Debug.Log("Đã lưu tại: " + filePath);
    }

    [ContextMenu("Load Game")]
    public void LoadGame()
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);

            data = JsonUtility.FromJson<PlayerData>(json);

            Debug.Log("Đã tải dữ liệu thành công!");
        }
        else
        {
            Debug.LogWarning("Không tìm thấy file lưu, tạo mới dữ liệu mặc định.");
            data = new PlayerData { playerName = "New Player", level = 1, highScore = 0};
            SaveGame();
        }
    }
    private void OnDisable()
    {
        SaveGame();
    }
}