using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCar : Obstacle // INHERITANCE
{
    public float movementSpeed = 2f;

    // Update is called once per frame
    void Update()
    {
        if(Victims.isGameActive)
        {
            Drive(); // ABSTRACTION
        }
    }

    public override void DealDamage() // POLYMORPHISM
    {
        Victims.Health -= 25;
    }

    public void Drive() // ABSTRACTION
    {
        transform.LookAt(FindObjectOfType<Victims>().transform);
        transform.position = Vector3.MoveTowards(transform.position, FindObjectOfType<Victims>().transform.position, movementSpeed * Time.deltaTime);
    }
}
