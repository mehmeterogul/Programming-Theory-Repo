using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool isGameActive = true;
    public GameObject gameOverText;
    public Text nameText;
    public Button restartButton;

    public void GameOver()
    {
        isGameActive = false;
        gameOverText.SetActive(true);
        nameText.text = PlayerNameHolder.Instance.GetPlayerName();
        nameText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        GameObject.FindGameObjectWithTag("Spawner").GetComponent<ObstacleSpawner>().CancelInvoke();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
