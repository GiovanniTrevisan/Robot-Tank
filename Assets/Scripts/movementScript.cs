using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementScript : MonoBehaviour
{
    public float force;
    public Rigidbody rb;
    public float maxSpeed;
    public GameObject nightVision;

    private bool toggleBool;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        toggleBool = false;
    }

    void Update()
    {
        // Trying to Limit Speed
        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
        }

        if (Input.GetButtonDown("Fire2"))
        {
            Switch();
            nightVision.SetActive(toggleBool);
        }
    }

    void FixedUpdate()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        rb.AddForce(moveVertical * transform.forward * force);
        rb.AddTorque(new Vector3(0, 5f * moveHorizontal, 0));
    }

    void Switch()
    {
        if (toggleBool == true)
        {
            toggleBool = false;
        }
        else
        { 
            toggleBool = true;
        }
    }
}
