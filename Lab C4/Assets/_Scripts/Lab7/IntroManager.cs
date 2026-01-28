using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement; // Thư viện để chuyển cảnh

public class IntroManager : MonoBehaviour
{
    private VideoPlayer vp;
    public GameObject statusText; // Kéo cái Text vào đây

    void Start()
    {
        vp = GetComponent<VideoPlayer>();

        // ĐĂNG KÝ SỰ KIỆN: Khi hết video thì gọi hàm EndIntro
        vp.loopPointReached += EndIntro;
    }

    // Hàm xử lý khi kết thúc Video
    void EndIntro(VideoPlayer source)
    {
        Debug.Log("Video kết thúc!");
        if (statusText != null) statusText.SetActive(false);
        
        // Chuyển sang màn chơi chính (Bạn cần tạo thêm Scene tên là Gameplay)
        // SceneManager.LoadScene("Gameplay"); 
        
        // Hiện thông báo giả lập nếu chưa có Scene Gameplay
        Debug.Log("Đã chuyển sang Gameplay Scene!");
    }

    // Hàm xử lý cho nút Skip
    public void SkipIntro()
    {
        vp.Stop(); // Dừng video
        EndIntro(vp); // Gọi hàm kết thúc
    }
}