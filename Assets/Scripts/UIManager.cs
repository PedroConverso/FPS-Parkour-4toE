using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    // Variables For Money Managment
    public TextMeshProUGUI txtMoney;
    public TextMeshProUGUI txtHealth;

    void Start()
    {
        txtMoney.text = $"Money: $0";
        txtHealth.text = $"Health: 5";
    }
    
    public void UpdateMoneyText(float moneyAmount)
    {
        txtMoney.text = $"Money: ${moneyAmount}";
    }

    public void UpdateHealthPointsText(int healthPoints)
    {
        txtHealth.text = $"Health: {healthPoints}";
    }
}
