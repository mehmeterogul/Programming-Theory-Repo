using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Victims : MonoBehaviour
{
    public GameObject gameOverText;
    public Text healthText;
    public Button restartButton;
    public static bool isGameActive = true;
    private static int health = 100;
    public static int Health // ENCAPSULATION
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

    // Update is called once per frame
    void Update()
    {
        healthText.text = health.ToString();

        if (isGameActive)
        {
            CheckHealthSituation(); // ABSTRACTION
        }
    }

    private void CheckHealthSituation() // ABSTRACTION
    {
        if (health <= 0)
        {
            Debug.Log("Game Over");
            isGameActive = false;
            gameOverText.SetActive(true);
            restartButton.gameObject.SetActive(true);
            GameObject.FindGameObjectWithTag("Spawner").GetComponent<ObstacleSpawner>().CancelInvoke();
        }
    }
}
