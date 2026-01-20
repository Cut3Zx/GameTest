using UnityEngine;
using TMPro; // Nếu dùng TextMeshPro, nếu dùng Text thường thì dùng UnityEngine.UI

public class RotationWithUI : MonoBehaviour
{
    public Camera mainCamera;
    public TextMeshProUGUI angleText; // Kéo Text UI vào đây
    public float rotationSpeed = 10f;

    void Update()
    {
        // 1. Lấy vị trí chuột trong thế giới 2D
        Vector3 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0; // Đảm bảo cùng mặt phẳng Z

        // 2. Tính hướng từ nhân vật đến chuột
        Vector3 targetDir = mousePos - transform.position;

        // 3. Tính góc "Signed Angle" giữa hướng Up hiện tại và hướng mục tiêu
        // Trục xoay trong 2D là trục Z (Vector3.forward)
        float angleDiff = Vector3.SignedAngle(transform.up, targetDir, Vector3.forward);

        // 4. Xoay nhân vật (Xoay dần dần để thấy hiệu ứng)
        float rotationStep = angleDiff * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, 0, rotationStep);

        // 5. Hiển thị góc hiện tại lên UI (Góc Z của transform)
        float currentAngle = transform.eulerAngles.z;
        angleText.text = $"Rotation Angle: {currentAngle:F2}°";
    }
}