using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private float cooldown;
    public GameObject Ladybug;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //Spawns random element of the array on a cooldown
        cooldown -= Time.deltaTime;
        if (cooldown <= 0)
        {

            Instantiate(Ladybug, new Vector3(Random.Range(-3.8f, 3.8f), transform.position.y, 0f), Quaternion.identity);
            cooldown = 1f;
        }

       
    }
}
