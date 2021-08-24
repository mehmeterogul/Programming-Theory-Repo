using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public virtual void DealDamage()
    {
        Victims.health -= 100;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Victims"))
        {
            DealDamage();
            Destroy(gameObject);
        }
    }
}
