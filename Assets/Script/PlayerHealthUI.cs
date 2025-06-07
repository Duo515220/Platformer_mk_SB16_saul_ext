using UnityEngine;
using UnityEngine.UI; // або TMPro якщо використовуєш TextMeshPro

public class PlayerHealthUI : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public Text healthText; // Якщо TextMeshPro, то замість Text — TMP_Text

    void Update()
    {
        if (playerHealth != null)
        {
            healthText.text = "HP: " + playerHealth.currentHealth;
        }
    }
}

