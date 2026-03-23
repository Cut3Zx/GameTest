using System.IO;
using UnityEngine;

public class SaveSystem
{
    public static void Save(string json)
    {
        string path = Application.persistentDataPath + "/save.json";
        File.WriteAllText(path, json);
    }
    public static string Load()
    {
        string path = Application.persistentDataPath + "/save.json";

        if (File.Exists(path))
        {
            return File.ReadAllText(path);
        }
        return null;
    }
}