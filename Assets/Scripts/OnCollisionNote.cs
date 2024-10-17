
using TMPro;
using UnityEngine;

public class OnCollisionNote : MonoBehaviour
{
    NotesController notesController;
    TextMeshProUGUI textCounterPoints;

    void Start()
    {
        notesController = NotesController.Instance;

        textCounterPoints = GameObject.Find("CounterPoints").GetComponent<TextMeshProUGUI>();
        textCounterPoints.text = notesController.GetPoints().ToString();
    }

    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Player")
        {
            notesController.AddPoint();
            gameObject.SetActive(false);
        }
        else
        {
            notesController.SubtractPoint();
        }

        textCounterPoints.text = notesController.GetPoints().ToString();

        gameObject.SetActive(false);
    }


}