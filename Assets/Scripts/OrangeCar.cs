using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeCar : Obstacle // INHERITANCE
{
    public float movementSpeed = 1.5f;
    GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.isGameActive)
        {
            Drive(); // ABSTRACTION
        }
    }

    public void Drive() // ABSTRACTION
    {
        transform.LookAt(FindObjectOfType<Victims>().transform);
        transform.position = Vector3.MoveTowards(transform.position, FindObjectOfType<Victims>().transform.position, movementSpeed * Time.deltaTime);
    }
}
