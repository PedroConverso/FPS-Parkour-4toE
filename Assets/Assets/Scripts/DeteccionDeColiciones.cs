using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionDeColiciones : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colision con " + collision.gameObject.name);
        Destroy(collision.gameObject);
    }
}
