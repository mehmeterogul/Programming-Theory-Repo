using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNameHolder : MonoBehaviour
{
    public static PlayerNameHolder Instance;
    public string PlayerName;

    void Awake()
    {
        if(PlayerNameHolder.Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
        Instance = this;
    }

    public void SetPlayerName(string playerName)
    {
        PlayerName = playerName;
    }

    public string GetPlayerName()
    {
        return PlayerName;
    }
}
