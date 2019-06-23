using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public Rigidbody duck;
    public GameObject mama;
    public GameObject UiEndgame;

    void OnTriggerEnter(Collider trig)
    {
        if (trig.CompareTag("Player"))
        {
            Debug.Log("MAMA");
            mama.gameObject.SetActive(true);
            UiEndgame.gameObject.SetActive(true);
        }
    }
}
