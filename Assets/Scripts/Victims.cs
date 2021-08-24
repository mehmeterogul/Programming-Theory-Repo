using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Victims : MonoBehaviour
{
    private GameManager gameManager;
    public Text healthText;
    private int health = 100;
    public int Health // ENCAPSULATION
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
        }
    }

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        healthText.text = Health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.isGameActive)
        {
            healthText.text = health.ToString();
            CheckHealthSituation(); // ABSTRACTION
        }
    }

    private void CheckHealthSituation() // ABSTRACTION
    {
        if (health <= 0)
        {
            gameManager.GameOver();
        }
    }
}
