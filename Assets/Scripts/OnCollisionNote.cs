
using TMPro;
using UnityEngine;

public class OnCollisionNote : MonoBehaviour
{
    NotesController notesController;
    TextMeshProUGUI textCounterPoints;

    AudioSource punto;

    AudioSource fail;

    void Start()
    {
        notesController = NotesController.Instance;
        punto = GameObject.Find("Point").GetComponent<AudioSource>();
        fail = GameObject.Find("Fail").GetComponent<AudioSource>();
        
        //textCounterPoints = GameObject.Find("CounterPoints").GetComponent<TextMeshProUGUI>();
        // textCounterPoints.text = notesController.GetPoints().ToString();
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("colision detectada");
        if (other.gameObject.CompareTag("Jugador")) //no detecta el punto
        {
            Debug.Log("Puntote");
            //punto.Play();
            punto.PlayOneShot(punto.clip);
            notesController.AddPoint();
            gameObject.SetActive(false);
        }
        else
        { 
            Debug.Log("No Punto");
            fail.PlayOneShot(fail.clip);
            notesController.SubtractPoint();
        }

        //textCounterPoints.text = notesController.GetPoints().ToString();

        gameObject.SetActive(false);
    }

    // void Reproduce(AudioClip clip)
    // {
    //     audioSource.clip = clip;
    //     audioSource.Play();
    // }


}