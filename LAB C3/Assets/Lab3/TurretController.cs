using UnityEngine;

public class TurretController2D : MonoBehaviour
{
    public Transform target;
    public float rotationSpeed = 90f;
    public bool isSmoothRotation = true;

    void Update()
    {
        if (target == null) return;

        if (isSmoothRotation)
        {
            RotateSmoothly2D();
        }
        else
        {
            RotateInstantly2D();
        }
    }

    void RotateInstantly2D()
    {
        // 1. Tính hướng từ mình đến mục tiêu
        Vector2 direction = target.position - transform.position;
        
        // 2. Tính góc (Angle) bằng hàm Atan2
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        
        // 3. Áp dụng xoay vào trục Z (trừ đi 90 độ nếu nòng súng của bạn hướng lên trên mặc định)
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    void RotateSmoothly2D()
    {
        Vector2 direction = target.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        
        // Tạo Quaternion mục tiêu chỉ xoay quanh trục Z
        Quaternion targetRotation = Quaternion.Euler(0, 0, angle);
        
        // Xoay mượt mà
        transform.rotation = Quaternion.RotateTowards(
            transform.rotation, 
            targetRotation, 
            rotationSpeed * Time.deltaTime
        );
    }
}