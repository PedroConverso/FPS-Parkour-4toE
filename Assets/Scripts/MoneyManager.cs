using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public float money;
    public UIManager uiManager;

    void Start()
    {
        uiManager.UpdateMoneyText(money);
    }

    public bool UpdateMoney(float amount)
    {
        if (money + amount < 0)
        {
            Debug.Log("No tenes dinero sufiente");
            return false;
        }

        money += amount;
        uiManager.UpdateMoneyText(money);
        return true;
    }
}

