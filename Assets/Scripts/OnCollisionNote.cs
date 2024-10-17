using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionNote : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colisión con " + collision.gameObject.name);
        if (collision.gameObject.tag == "Player")
        {

        }
        else
        {
        }
        gameObject.SetActive(false);

    }
}
