using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNotes : MonoBehaviour
{
    [SerializeField] GameObject note;
    [SerializeField] Transform initial_position;

    [SerializeField] List<GameObject> notes;

    int countNotes = 0;

    void Start()
    {
        // Crear 5 notas y agregarlas a la lista
        for (int i = 0; i < 10; i++)
        {
            GameObject newNote = Instantiate(note, Vector3.zero, Quaternion.identity);
            newNote.name = "Proyectil" + i;
            newNote.tag = "Note";
            newNote.SetActive(false); // Inicialmente desactivadas
            notes.Add(newNote);
        }

        StartCoroutine(SpawnNotes());
    }

    IEnumerator SpawnNotes()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            notes[countNotes].transform.position = Vector3RandomPosition();
            notes[countNotes].SetActive(true);
            notes[countNotes].GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            notes[countNotes].GetComponent<Rigidbody>().AddForce(Vector3.down * 10, ForceMode.Impulse);

            // Avanzar al siguiente proyectil
            countNotes++;
            countNotes %= notes.Count; // Reiniciar el índice si llega al final
        }
    }

    Vector3 Vector3RandomPosition()
    {
        List<float> notesPosition = new List<float> { -6f, -2f, 2f, 6f };
        return new Vector3(notesPosition[Random.Range(0, notesPosition.Count)], 8, 0);
    }
}
