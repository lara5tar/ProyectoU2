using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNotes : MonoBehaviour
{
    GameObject note;

    [SerializeField] List<GameObject> notes;

    int countNotes = 0;

    NotesController notesController;


    void Start()
    {
        notesController = NotesController.Instance;

        note = Resources.Load<GameObject>("Prefabs/NotePrefab");

        for (int i = 0; i < 10; i++)
        {
            GameObject newNote = Instantiate(note, new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));
            newNote.name = "Note" + i;
            newNote.tag = "Note";
            newNote.SetActive(false);
            notes.Add(newNote);
        }

        StartCoroutine(SpawnNotes());
    }

    IEnumerator SpawnNotes()
    {
        while (notesController.GetIsGameInPlay())
        {

            yield return new WaitForSeconds(0.5f);

            notes[countNotes].transform.position = notesController.RandomPosition();
            notes[countNotes].SetActive(true);
            notes[countNotes].GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            notes[countNotes].GetComponent<Rigidbody>().AddForce(Vector3.down * 10, ForceMode.Impulse);

            countNotes++;
            countNotes %= notes.Count;
        }
    }


}
