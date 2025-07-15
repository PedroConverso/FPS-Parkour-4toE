using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtingObjManager : MonoBehaviour
{
    public int damagePoints;
    public HealthManager healthManager;

    // Start is called before the first frame update
    void Start()
    {
        healthManager = FindObjectOfType<HealthManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Collision Ocurred: {collision.gameObject.name}");
        if (collision.gameObject.name != "Player")
        {
            return;
        }
        if (healthManager.UpdateHealth(-damagePoints))
        {
            Destroy(gameObject);
        }

    }
}
