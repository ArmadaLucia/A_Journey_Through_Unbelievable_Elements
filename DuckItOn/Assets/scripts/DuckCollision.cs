using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


// Probleem 1:
// Ik heb een Collision Functie die denkt dat hij de GROUND moet zien als collision, terwijl er tag == "Rots" staat.
// Probleem 2:
// Hoe kan ik iets in het GameControllerScript toevoegen? Als ik iets toevoeg bij case 0, dan werkt de hele case 0 niet meer

// Probleem 3 (niet van hoogst belang nu)
// De Eend verliest soms twee Hearts bij collision en dat is oneerlijk. Er moet een kleine Delay zitten voor wanneer
// de eend weer opnieuw de rand kan raken


public class DuckCollision : MonoBehaviour
{
    public GameController gameController;
    public GameManager gameManager;

    public float timeStamp;
    public bool timer;

    public GameObject painUI;

    public AudioSource ducksource;
    public AudioClip painduckclip;


    public void Start()
    {
        ducksource.clip = painduckclip;
    }

    private void Update()
    {
        if (timer == true)
        {
            timeStamp -= Time.deltaTime;
        }

        if (timeStamp < 0)
        {
            timer = false;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Obstacle" && timer == false)
        {
            GameController.health -= 1;
            //painUI.gameObject.SetActive(true);
            ducksource.Play();
            timer = true;
            timeStamp = 4;
            Debug.Log("AAH, obstakel!");
        }
        else
        {
            //painUI.gameObject.SetActive(false);
        }

        //GetComponent<GameObject>().SetActive(false);
        //collisionInfo.transform.gameObject.SetActive(false);
        //GetComponent<ground>().collisionInfo.transform.gameObject.SetActive(false);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("Restarting!");
    }
}
