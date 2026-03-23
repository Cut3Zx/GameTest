[System.Serializable]
public class LevelData
{
    public int currentLevel;
    public int currentScore;
    public float totalTimePlayed;

    // Constructor để khởi tạo giá trị mặc định
    public LevelData()
    {
        currentLevel = 1;
        currentScore = 0;
        totalTimePlayed = 0f;
    }
}