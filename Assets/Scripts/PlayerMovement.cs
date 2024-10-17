using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    NotesController notesController;

    void Start()
    {
        notesController = NotesController.Instance;
    }

    void Update()
    {

        if (Input.GetKey(notesController.GetKeyCode(0)))
        {
            transform.position = notesController.GetPositionPlayer(0);
        }
        else if (Input.GetKey(notesController.GetKeyCode(1)))
        {
            transform.position = notesController.GetPositionPlayer(1);
        }
        else if (Input.GetKey(notesController.GetKeyCode(2)))
        {
            transform.position = notesController.GetPositionPlayer(2);
        }
        else if (Input.GetKey(notesController.GetKeyCode(3)))
        {
            transform.position = notesController.GetPositionPlayer(3);
        }

    }

}
