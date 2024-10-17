
using System.Collections.Generic;
using UnityEngine;

public class NotesController : MonoBehaviour
{
    KeyCode currentNote;

    List<Dictionary<string, object>> notes = new List<Dictionary<string, object>>();

    int CounterPoints = 0;

    bool isGameInPlay = true;

    public static NotesController Instance { get; private set; }
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        notes.Add(new Dictionary<string, object> { { "note", KeyCode.D }, { "position", -6f } });
        notes.Add(new Dictionary<string, object> { { "note", KeyCode.F }, { "position", -2f } });
        notes.Add(new Dictionary<string, object> { { "note", KeyCode.J }, { "position", 2f } });
        notes.Add(new Dictionary<string, object> { { "note", KeyCode.K }, { "position", 6f } });
    }



    public Vector3 RandomPosition()
    {
        int random = Random.Range(0, notes.Count);

        currentNote = (KeyCode)notes[random]["note"];

        return new Vector3((float)notes[random]["position"], 8f, 0f);
    }

    public KeyCode GetCurrentNote()
    {
        return currentNote;
    }

    public KeyCode GetKeyCode(int index)
    {
        return (KeyCode)notes[index]["note"];
    }
    public Vector3 GetPositionPlayer(int index)
    {
        return new Vector3((float)notes[index]["position"], 0.8f, 0f);
    }


    public void AddPoint()
    {
        CounterPoints++;
    }

    public void ResetPoints()
    {
        CounterPoints = 0;
    }

    public void SubtractPoint()
    {
        CounterPoints--;
    }

    public int GetPoints()
    {
        return CounterPoints;
    }

    public void SetGameInPlay(bool value)
    {
        isGameInPlay = value;
    }

    public bool GetIsGameInPlay()
    {
        return isGameInPlay;
    }

}
