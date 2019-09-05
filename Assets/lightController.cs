using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightController : MonoBehaviour
{

    Color color0 = Color.black;
    Color color1 = Color.white;
    public float smooth;

    Light lt;

    // Start is called before the first frame update
    void Start()
    {
        lt = GetComponent<Light>();
    } 

    // Update is called once per frame
    void Update()
    {


        lt.color = Color.Lerp(color0, color1, Time.deltaTime * smooth);

        Debug.Log("dados - " + lt.color);

    }
}
