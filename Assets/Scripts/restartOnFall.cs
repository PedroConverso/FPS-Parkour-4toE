using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartOnFall : MonoBehaviour
{
    public float alturaCaida = -10;

    void Update()
    {
        if(transform.position.y < alturaCaida){
            SceneManager.LoadScene("Parkur");
        }
    }
}
