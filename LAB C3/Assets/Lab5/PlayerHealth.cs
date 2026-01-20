using UnityEngine;
using System; // Bắt buộc để dùng Action

public class PlayerHealth : MonoBehaviour
{
    // Sự kiện gửi đi giá trị int (máu hiện tại)
    public static event Action<int> OnHealthChanged;

    [SerializeField] private int maxHealth = 100;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
        // Thông báo máu khởi tạo cho UI
        OnHealthChanged?.Invoke(currentHealth);
    }
    void Update()
    {
        // Ví dụ: Nhấn phím H để trừ 10 máu
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(10);
        }
    }

    // Hàm gọi để trừ máu (có thể gắn vào phím bấm để test)
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        // "Phát loa" thông báo máu đã thay đổi
        OnHealthChanged?.Invoke(currentHealth);
    }
}