using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class IntroVideo : MonoBehaviour
{
    private VideoPlayer vp;
    public string nextSceneName = "GameplayScene"; // Tên Scene bạn muốn chuyển tới

    void Start()
    {
        vp = GetComponent<VideoPlayer>();

        // Tự động phát khi vào Scene
        vp.Play();

        // SỰ KIỆN CHÍNH: Khi chạy hết video tự động gọi hàm ToGameplay
        vp.loopPointReached += ToGameplay;
    }

    // Hàm chuyển sang màn chơi chính
    public void ToGameplay(VideoPlayer source)
    {
        Debug.Log("Chuyển cảnh sang: " + nextSceneName);
        
        // Lưu ý: Bạn phải thêm Scene vào Build Settings mới dùng được lệnh này
        SceneManager.LoadScene(nextSceneName);
    }

    // Hàm dành cho nút SKIP
    public void OnSkipButtonClick()
    {
        Debug.Log("Người chơi nhấn Bỏ qua.");
        vp.Stop(); 
        ToGameplay(vp); // Gọi hàm chuyển cảnh ngay lập tức
    }
}