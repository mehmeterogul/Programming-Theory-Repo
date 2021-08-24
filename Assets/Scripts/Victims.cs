using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victims : MonoBehaviour
{
    public static int health = 100;
    public static bool isGameActive = true;
    public GameObject gameOverText;

    // Update is called once per frame
    void Update()
    {
        if(isGameActive)
        {
            CheckHealthSituation();
        }

    }

    private void CheckHealthSituation()
    {
        if (health <= 0)
        {
            Debug.Log("Game Over");
            isGameActive = false;
            gameOverText.SetActive(true);
            GameObject.FindGameObjectWithTag("Spawner").GetComponent<ObstacleSpawner>().CancelInvoke();
        }
    }
}
