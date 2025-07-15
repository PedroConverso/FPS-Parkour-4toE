using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    // Referencias UI
    public TextMeshProUGUI txtMoney;
    public TextMeshProUGUI txtHealth;

    // Variables internas
    private float currentMoney = 0f;
    private int maxHealth = 5;

    void Start()
    {
        currentMoney = 0f;
        txtMoney.text = "Money: $0";
        txtHealth.text = $"Vida: {maxHealth}/{maxHealth}";
    }

    // Suma dinero y actualiza el texto
    public void AddMoney(float amount)
    {
        currentMoney += amount;
        UpdateMoneyText();
    }

    // Método para actualizar solo el texto del dinero
    private void UpdateMoneyText()
    {
        txtMoney.text = $"Money: ${currentMoney}";
    }

    // Método para setear directamente el dinero sin sumar (opcional)
    public void SetMoney(float amount)
    {
        currentMoney = amount;
        UpdateMoneyText();
    }

    // Actualiza texto de vida
    public void UpdateHealthPointsText(int healthPoints)
    {
        txtHealth.text = $"Vida: {healthPoints}/{maxHealth}";
    }
}
