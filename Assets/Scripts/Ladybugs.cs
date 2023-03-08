using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladybugs : Bugs
{
    [SerializeField] private float lspeed;
 

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0f, -1f, 0f) * Time.deltaTime * lspeed;
    }
}
