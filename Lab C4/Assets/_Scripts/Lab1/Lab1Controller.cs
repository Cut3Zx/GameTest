using UnityEngine;

public class Lab1Controller : MonoBehaviour
{
    private AudioSource myAudio;

    void Start()
    {
        // Tự động lấy Component AudioSource gắn trên cùng đối tượng
        myAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Nhấn Space để Play
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myAudio.Play();
            Debug.Log("Đang phát âm thanh...");
        }

        // Nhấn phím S để Stop
        if (Input.GetKeyDown(KeyCode.S))
        {
            myAudio.Stop();
            Debug.Log("Đã dừng âm thanh.");
        }
    }
}