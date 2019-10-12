using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAttack : MonoBehaviour
{

    public GameObject cannon;
    public GameObject projectile;
    public GameObject pointSpawn;
    public float time = 2f;
    public float speedRotation = 1f;

    private float timeDelta;
    GameObject player;
    void Start()
    {
        timeDelta = 0;
        player = GameObject.FindWithTag("MainCamera");
    }

    private void Update()
    {
        timeDelta += Time.deltaTime;
        if (timeDelta >= time)
        {
            Instantiate(projectile, pointSpawn.transform.position, cannon.transform.rotation);
            timeDelta = 0;
        }
    }

    void FixedUpdate()
    {
        var rotation = Quaternion.LookRotation(player.transform.position - transform.position);
        rotation.x = 0;
        rotation.z = 0;
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * speedRotation);
    }
}
