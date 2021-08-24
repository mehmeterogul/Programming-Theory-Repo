using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Obstacle
{
    public float movementSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Victims.isGameActive)
        {
            Move();
        }
    }

    public void Move()
    {
        transform.LookAt(FindObjectOfType<Victims>().transform);
        transform.position = Vector3.MoveTowards(transform.position, FindObjectOfType<Victims>().transform.position, movementSpeed * Time.deltaTime);
    }
}
