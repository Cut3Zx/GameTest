using UnityEngine;

public class Lab3Manager : MonoBehaviour
{
    private bool isMuted = false;
    private bool isPaused = false;

    void Update()
    {
        // 1. Phím M: Mute/Unmute (Tắt/Mở tiếng)
        if (Input.GetKeyDown(KeyCode.M))
        {
            isMuted = !isMuted;
            // Chỉnh âm lượng tổng về 0 hoặc 1
            AudioListener.volume = isMuted ? 0f : 1f;
            Debug.Log(isMuted ? "Đã tắt tiếng (Mute ON)" : "Đã bật tiếng (Mute OFF)");
        }

        // 2. Phím P: Pause/Resume (Tạm dừng toàn bộ audio)
        if (Input.GetKeyDown(KeyCode.P))
        {
            isPaused = !isPaused;
            // Tạm dừng/Phát tiếp toàn bộ nguồn âm trong game
            AudioListener.pause = isPaused;
            Debug.Log(isPaused ? "Đã tạm dừng âm thanh" : "Đã tiếp tục âm thanh");
        }
    }
}