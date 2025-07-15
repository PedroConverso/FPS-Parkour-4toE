using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript : MonoBehaviour
{
    public int precio;
    public MoneyManager moneyManager;

    void Start()
    {
        moneyManager = FindObjectOfType<MoneyManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Collision Ocurred: {collision.gameObject.name}");
        if (collision.gameObject.name != "Player")
        {
            return;
        }
        if (moneyManager.UpdateMoney(-precio))
        {
            Destroy(gameObject);
        }

    }
}
