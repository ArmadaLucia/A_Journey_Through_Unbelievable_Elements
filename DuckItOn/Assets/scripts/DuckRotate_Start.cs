using UnityEngine;

public class DuckRotate_Start : MonoBehaviour
{

    public Rigidbody rb;

    public float rotation;


    void FixedUpdate()
    {
        int turn = 1;
        rb.AddTorque(transform.up * rotation * turn);

    }
}

