using UnityEngine;

public class DuckMoveTwo : MonoBehaviour
{

    public Rigidbody rb;

    public float rotation;
    public float forwardForce;
    public float DuckForce;



    void Update()
    {
        rb.AddForce(0, 0, 0);

        if (Input.GetKey("d"))
        {
            rb.transform.Rotate(new Vector3(0, 1, 0));
            rb.AddForce(-3, 0, 2);

        }
        if (Input.GetKey("a"))
        {
            rb.transform.Rotate(new Vector3(0, -1, 0));
            rb.AddForce(3, 0, 2);

        }
        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(0, 0, -DuckForce);
        }
    }
}

