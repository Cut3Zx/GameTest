using UnityEngine;
using System.IO;

public class SaveSystems : MonoBehaviour
{
    public LevelData data = new LevelData();
    private string savePath;

    void Awake()
    {
        // Đường dẫn chuẩn để lưu game trên mọi thiết bị
        savePath = Application.persistentDataPath + "/savegame.json";
        LoadGame();
    }

    void Update()
    {
        data.totalTimePlayed += Time.deltaTime;
    }

    [ContextMenu("Save Game")]
    public void SaveGame()
    {
        try
        {
            string json = JsonUtility.ToJson(data, true);
            File.WriteAllText(savePath, json);
            Debug.Log("<color=green>Đã lưu Game thành công!</color>");
        }
        catch (System.Exception e)
        {
            Debug.LogError("Lỗi khi lưu game: " + e.Message);
        }
    }

    [ContextMenu("Load Game")]
    public void LoadGame()
    {
        if (File.Exists(savePath))
        {
            string json = File.ReadAllText(savePath);
            data = JsonUtility.FromJson<LevelData>(json);
            Debug.Log("<color=blue>Đã tải dữ liệu cũ.</color>");
        }
        else
        {
            Debug.Log("Không tìm thấy save, sử dụng dữ liệu mới.");
            data = new LevelData();
        }
    }
    private void OnDisable()
    {
        SaveGame();
    }
}