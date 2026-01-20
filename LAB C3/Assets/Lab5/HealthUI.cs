using UnityEngine;
using TMPro;

public class HealthUI : MonoBehaviour
{
    public TextMeshProUGUI healthText;

    private void OnEnable() => PlayerHealth.OnHealthChanged += UpdateUI;
    private void OnDisable() => PlayerHealth.OnHealthChanged -= UpdateUI;

    private void UpdateUI(int health)
    {
        healthText.text = $"Health: {health}";
    }
}