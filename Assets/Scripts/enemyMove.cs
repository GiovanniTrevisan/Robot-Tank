﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
    public GameObject[] followObjects;
    public float speedRotation = 1f;
    public float thrust = 20f;
    public float maxSpeed = 10f;

    public int IndexObject;
    int indexPrev;
    Rigidbody Rigidbody;

    void Start()
    {

        followObjects[0] = GameObject.Find("FollowPoint (1)");
        followObjects[1] = GameObject.Find("FollowPoint (2)");
        followObjects[2] = GameObject.Find("FollowPoint (3)");
        followObjects[3] = GameObject.Find("FollowPoint (4)");

        Rigidbody = GetComponent<Rigidbody>();

        IndexObject = Random.Range(0, (followObjects.Length));
        StartCoroutine(mudarDirecao(3f));

<<<<<<< HEAD
        followObjects[0] = GameObject.Find("FollowPoint (1)");
        followObjects[1] = GameObject.Find("FollowPoint (2)");
        followObjects[2] = GameObject.Find("FollowPoint (3)");
        followObjects[3] = GameObject.Find("FollowPoint (4)");

=======
>>>>>>> 7da8066eeb197e196173b88e80a18fcbffaa69dc
    }

    private void Update()
    {
        Rigidbody.velocity = Vector3.ClampMagnitude(Rigidbody.velocity, maxSpeed);
    }

    void FixedUpdate()
    {

        //transform.rotation(0f, transform.rotation.y, 0f);

        var rotation = Quaternion.LookRotation(followObjects[IndexObject].transform.position - transform.position);
        rotation.x = 0;
        rotation.z = 0;
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * speedRotation);
        //transform.LookAt(followObjects[IndexObject].transform);
        Rigidbody.AddForce(transform.forward * thrust);
    }

    public void SwitchIndex() 
    {
        IndexObject = Random.Range(0, (followObjects.Length));
        if (followObjects.Length > 1)
        {
            do
            {
                IndexObject = Random.Range(0, followObjects.Length);
            } while (IndexObject == indexPrev);
        }
        indexPrev = IndexObject;
    }

    IEnumerator mudarDirecao(float time)
    {
        SwitchIndex();
        yield return new WaitForSeconds(time);

        StartCoroutine(mudarDirecao(Random.Range(1f, 4f)));
    }

}
