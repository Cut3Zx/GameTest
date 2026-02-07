using UnityEngine;

public class PushObject : MonoBehaviour
{
    private Rigidbody rb;
    public float forceAmount = 10f; // Nếu dùng Impulse thì 10 là đủ mạnh

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Nhấn Space để bắn quả cầu về phía khối Cube (trục Z)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Vector3.forward tương ứng với trục Z (mũi tên xanh dương)
            rb.AddForce(Vector3.forward * forceAmount, ForceMode.Impulse);
            Debug.Log("Đã tác động lực Impulse!");
        }
    }
}