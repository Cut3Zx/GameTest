using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement; // Thư viện để chuyển cảnh

public class IntroManager : MonoBehaviour
{
    public VideoPlayer myVideoPlayer;
    public GameObject endUI; // Panel hiển thị khi kết thúc

    void Start()
    {
        // Đăng ký các sự kiện
        myVideoPlayer.prepareCompleted += OnVideoPrepared;
        myVideoPlayer.loopPointReached += OnVideoFinished;
        
        // Bắt đầu nạp video
        myVideoPlayer.Prepare();
    }

    void OnVideoPrepared(VideoPlayer vp)
    {
        Debug.Log("Video đã chuẩn bị xong, bắt đầu phát!");
        vp.Play();
    }

    void OnVideoFinished(VideoPlayer vp)
    {
        Debug.Log("Video đã chạy hết!");
        
        // Lựa chọn 1: Hiển thị UI
        if(endUI != null) endUI.SetActive(true);
        
        // Lựa chọn 2: Chuyển Scene (Bỏ comment nếu dùng)
        // SceneManager.LoadScene("MainGameScene");
    }
    public void SkipVideo()
    {
        Debug.Log("Người dùng đã bấm Skip!");
        
        // 1. Dừng video ngay lập tức
        if (myVideoPlayer.isPlaying)
        {
            myVideoPlayer.Stop();
        }

        // 2. Gọi trực tiếp hàm xử lý kết thúc 
        // (Để đảm bảo các logic như hiện UI hoặc chuyển Scene được thực thi)
        OnVideoFinished(myVideoPlayer);
    }
}