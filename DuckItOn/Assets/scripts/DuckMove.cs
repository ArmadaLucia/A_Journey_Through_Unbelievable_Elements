using UnityEngine;

public class DuckMove : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce;
    public float rotation;
    public float DuckForce;

    private bool canPressSpace = true;

    public int maxtime;
    private int currenttime;

    //half 3 karin volgende week donderdag
    // velocity is een richting + een snelheid

    void FixedUpdate()
    {
        //if (rb.velocity.sqrMagnitude <= forwardForce * forwardForce)
        //{
        //    
        //}
        //else
        //{
        //    canPressSpace = true;
        //}

        rb.AddForce(0, 0, forwardForce);

        if (currenttime <= 0)
        {
            canPressSpace = true;
        }

        else
        {
            currenttime -= 1;
        }

        //Debug.Log(rb.velocity.magnitude);

        int left = Input.GetKey("a") ? 1 : 0;
        int right = Input.GetKey("d") ? 1 : 0;
        int turn = -left + right;
        Debug.Log(turn);
        rb.AddTorque(transform.up * rotation * turn);


        //if (Input.GetKey("d"))
        //{
        //    transform.Rotate(new Vector3(0, rotation, 0));
        //}
        //if (Input.GetKey("a"))
        //{
        //    transform.Rotate(new Vector3(0, -rotation, 0));
        //}
        if (Input.GetKeyDown("space") && canPressSpace)
        {
            //transform.Translate(0, 0, DuckForce);
            Debug.Log("hi");
            rb.velocity = Vector3.zero;
            rb.AddForce(transform.forward * DuckForce); //ForceMode.VelocityChange);
            canPressSpace = false;
            currenttime = maxtime;
        }
    }
}
