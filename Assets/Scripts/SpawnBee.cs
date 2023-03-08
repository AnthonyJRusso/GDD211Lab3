using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBee : MonoBehaviour
{
    [SerializeField] private float cooldown;
    public GameObject Bee;
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

            Instantiate(Bee, new Vector3(Random.Range(-2.3f, 2.3f), transform.position.y, 0f), Quaternion.identity);
            cooldown = 1f;
        }
    }
}
