using UnityEngine;
using UnityEngine.Events; // Bắt buộc

public class PlayerHealthUnity : MonoBehaviour
{
    // Tạo một sự kiện có thể truyền đi một số nguyên (máu)
    // Serialized để nó hiện ra trong Inspector
    public UnityEvent<int> onHealthChanged;

    [SerializeField] private int health = 100;
    void Start()
    {
    // Gọi sự kiện ngay khi game bắt đầu để UI hiện số 100 thay vì "New Text"
        onHealthChanged.Invoke(health); 
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        health = Mathf.Max(health, 0);

        // Kích hoạt sự kiện
        onHealthChanged.Invoke(health);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {   
            TakeDamage(10); // Mỗi lần nhấn Space sẽ trừ 10 máu và cập nhật UI
        }
    }
}