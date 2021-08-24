using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCar : Obstacle // INHERITANCE
{
    public float movementSpeed = 1f;

    // Update is called once per frame
    void Update()
    {
        if (Victims.isGameActive)
        {
            Move(); // ABSTRACTION
        }
    }

    public void Move() // ABSTRACTION
    {
        transform.LookAt(FindObjectOfType<Victims>().transform);
        transform.position = Vector3.MoveTowards(transform.position, FindObjectOfType<Victims>().transform.position, movementSpeed * Time.deltaTime);
    }
}
