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

    public float maxVelocity;
    public int maxParticles;
    public ParticleSystem waterSplash;

    public Animator anim;

    public int extraParticles;
    private int currentExtraParticles;
    public int extraParticleDelay;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce);

        if (currenttime <= 0)
        {
            canPressSpace = true;
        }

        else
        {
            currenttime -= 1;
        }

        // doordraaing rotatie
        // de kracht naar links is -1 en rechts is 1
        // geen links of rechts is 0 en samen indrukken is 0 
        // Torque is draaikracht (rotatie)
        int left = 0;
        if (Input.GetKey("a"))
        {
            left = 1;
        }
       
        int right = 0;
        if (Input.GetKey("d"))
        {
            right = 1;
        }

        int turn = -left + right;
        //Debug.Log(turn);
        rb.AddTorque(transform.up * rotation * turn);

        if (Input.GetKeyDown("space") && canPressSpace)
        {
            // velocity is een richting + een snelheid
            //Debug.Log("Duck it off");

            rb.velocity = Vector3.zero;
            rb.AddForce((transform.forward * DuckForce), ForceMode.VelocityChange);
            canPressSpace = false;
            currenttime = maxtime;
            anim.Play("DuckingOff");

            currentExtraParticles = extraParticles;
        }
        float percentage = rb.velocity.magnitude / maxVelocity;
        var emission = waterSplash.emission;
        emission.rateOverTimeMultiplier = (int)(percentage * maxParticles) + currentExtraParticles;
        //Debug.Log(emission.rateOverTimeMultiplier);

        
    }

    private void Update()
    {
        if (currentExtraParticles > 0)
        {
            currentExtraParticles -= extraParticleDelay;
        }
    }
}


// Eerst had ik dit als Rotatie script:

//if (Input.GetKey("d"))
//{
//    transform.Rotate(new Vector3(0, rotation, 0));
//}
//if (Input.GetKey("a"))
//{
//    transform.Rotate(new Vector3(0, -rotation, 0));
//}

// Eerst had ik dit als Duck Off script:

//transform.Translate(0, 0, DuckForce);


// Casey zn hulp:

//if (rb.velocity.sqrMagnitude <= forwardForce * forwardForce)
//{
//    
//}
//else
//{
//    canPressSpace = true;
//}
