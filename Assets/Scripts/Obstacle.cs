using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour // INHERITANCE
{
    public virtual void DealDamage() // POLYMORPHISM
    {
        FindObjectOfType<Victims>().Health -= 25;
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
