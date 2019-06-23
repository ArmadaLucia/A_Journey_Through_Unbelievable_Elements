using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{
    public Rigidbody duck;
    public float forceAmount;

    public AudioSource watertriggersource;
    public AudioClip watertriggerclip;

    void OnTriggerEnter(Collider trig)
    {
        if (trig.CompareTag("Player"))
        {
            Debug.Log("SpeedUp");
            AudioSource audio = GetComponent<AudioSource>();
            audio.PlayOneShot(watertriggerclip);
            duck.AddForce(duck.velocity.normalized * forceAmount, ForceMode.Impulse);
        }
    }
}
