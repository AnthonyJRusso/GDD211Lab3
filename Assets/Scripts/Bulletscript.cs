using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletscript : MonoBehaviour
{
    [SerializeField] private float shotspeed;
    [SerializeField] private float despawntime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Upward movement
        transform.position += new Vector3(0, 1, 0) * Time.deltaTime * shotspeed;

        //Despawn
        despawntime -= Time.deltaTime;

        if(despawntime <= 0)
        {
            Destroy(gameObject);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Bugs b = collision.gameObject.GetComponent<Bugs>();

        if (b)
        {
            b.TakeDamage(1);
            Destroy(gameObject);
        }
    }


}
