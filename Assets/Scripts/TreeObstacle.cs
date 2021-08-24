using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeObstacle : Obstacle
{
    public float movementSpeed = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Victims.isGameActive)
        {
            Roll();
        }
    }

    public void Roll()
    {
        transform.LookAt(FindObjectOfType<Victims>().transform);
        transform.position = Vector3.MoveTowards(transform.position, FindObjectOfType<Victims>().transform.position, movementSpeed * Time.deltaTime);
    }
}
