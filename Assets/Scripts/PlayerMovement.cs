using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector3(-6f, 0.8f, 0f);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector3(-2f, 0.8f, 0f);
        }
        else if (Input.GetKey(KeyCode.K))
        {
            transform.position = new Vector3(2f, 0.8f, 0f);
        }
        else if (Input.GetKey(KeyCode.L))
        {
            transform.position = new Vector3(6f, 0.8f, 0f);
        }

    }

}
