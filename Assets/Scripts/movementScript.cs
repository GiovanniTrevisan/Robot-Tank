using System;
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

        if (Input.GetButtonDown("Fire2") || Input.GetKeyDown("n"))
        {
            Switch();
            nightVision.SetActive(toggleBool);
            RenderSettings.fogDensity = toggleBool ? 0.005f : 0.015f;
        }
    }

    void FixedUpdate()
    {


        float moveHorizontal = Input.GetAxis("Horizontal");

        if (damageTracker.trackLeftDamaged || damageTracker.trackRightDamaged)
        {
            moveHorizontal = moveHorizontal * 0.45f;
        }

        if (!damageTracker.trackLeftDamaged && !damageTracker.trackRightDamaged)
        {
            float moveVertical = Input.GetAxis("Vertical");
            rb.AddForce(moveVertical * transform.forward * force);
        }
        else if ((!damageTracker.trackLeftDamaged && damageTracker.trackRightDamaged) || (damageTracker.trackLeftDamaged && !damageTracker.trackRightDamaged))
        {
            float moveVertical = Input.GetAxis("Vertical");
            maxSpeed = 3.5f;
            rb.AddForce(moveVertical * transform.forward * force * .85f);
        }
        else
        {
            float moveVertical = Input.GetAxis("Vertical");
            maxSpeed = 2.5f;
            rb.AddForce(moveVertical * transform.forward * force * .60f);
        }

        rb.AddTorque(new Vector3(0, 5f * moveHorizontal, 0));


        /*
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        rb.AddForce(moveVertical * transform.forward * force);
        rb.AddTorque(new Vector3(0, 5f * moveHorizontal, 0));
        */
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
