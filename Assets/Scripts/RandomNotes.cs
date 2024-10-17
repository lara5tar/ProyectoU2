using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNotes : MonoBehaviour
{
    [SerializeField] GameObject note;
    [SerializeField] Transform initial_position;

    [SerializeField] List<GameObject> notes;


    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            GameObject newNote = Instantiate(note, initial_position.position, initial_position.rotation);
            newNote.name = "Proyectil" + i;
            newNote.tag = "Note";
            newNote.SetActive(false);
            notes.Add(newNote);
        }

        StartCoroutine(UpdateNotes());
    }

    void Update()
    {
    }

    IEnumerator UpdateNotes()

    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            foreach (GameObject note in notes)
            {
                if (!note.activeInHierarchy)
                {
                    note.transform.position = Vector3RandomPosition();
                    note.SetActive(true);
                }
            }


        }


    }


    Vector3 Vector3RandomPosition()
    {
        List<float> notesPosition = new List<float> { -6f, -2f, 2f, 6f };
        return new Vector3(notesPosition[Random.Range(0, 4)], 6, 0);
    }
}
