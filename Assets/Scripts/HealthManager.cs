using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{

    public int healthPoints;
    public UIManager uiManager;
    // Start is called before the first frame update
    void Start()
    {
        uiManager.UpdateHealthPointsText(healthPoints);
    }

    public bool UpdateHealth(int damageAmount)
    {
        if (healthPoints + damageAmount <= 0)
        {
            Debug.Log("Game Over");
        }

        healthPoints += damageAmount;
        uiManager.UpdateHealthPointsText(healthPoints);
        return true;
    }
}
