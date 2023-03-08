using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bugs : MonoBehaviour
{
    //protected allows child classes to reference it
    [SerializeField] protected float Health;

    //virtual allows it to be overridden
    public virtual void TakeDamage(float dmg)
    {
        Health -= dmg;
        if(Health <= 0)
        {
            Destroy(gameObject);
        }
       

    }

    
}
