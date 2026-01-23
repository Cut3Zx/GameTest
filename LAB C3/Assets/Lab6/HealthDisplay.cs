using UnityEngine;
using TMPro;

public class HealthDisplay : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    
    

    // Hàm này sẽ được gọi bởi UnityEvent
    public void UpdateHealthText(int currentHealth)
    {
        textMesh.text = "HP: " + currentHealth.ToString();
    }
}