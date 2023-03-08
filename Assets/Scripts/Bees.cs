using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bees : Bugs
{
    [SerializeField] private float bspeed;
    [SerializeField] private float sinespeed;
    [SerializeField] private float distance;

   

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Mathf.Sin(Time.time * sinespeed) * distance, -1f, 0f) * Time.deltaTime * bspeed;
    }
}
