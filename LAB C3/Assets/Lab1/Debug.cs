using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
public class Debug : MonoBehaviour
{
    void Awake() => UnityEngine.Debug.Log($"{name}: Awake - Khởi tạo ");
    void OnEnable() => UnityEngine.Debug.Log($"{name}: OnEnable - Chạy khi object/script được bật");
    void Start() => UnityEngine.Debug.Log($"{name}: Start - Chạy trước frame đầu tiên");

    void Update() => UnityEngine.Debug.Log("Update - Chạy mỗi frame ");
    void FixedUpdate() => UnityEngine.Debug.Log("FixedUpdate - Chạy theo nhịp vật lý cố định");
    void LateUpdate() => UnityEngine.Debug.Log("LateUpdate - Chạy sau Update ");

    void OnDisable() => UnityEngine.Debug.Log($"{name}: OnDisable - Chạy khi tắt object/script");
    void OnDestroy() => UnityEngine.Debug.Log($"{name}: OnDestroy - Chạy khi object bị xóa");
}
