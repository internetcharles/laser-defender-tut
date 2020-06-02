using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameSession : MonoBehaviour
{
    int score = 0;
    int health = 300;

    // Start is called before the first frame update
    void Start()
    {
    }


    private void Awake()
    {
        SetUpSingleton();
    }

    private void SetUpSingleton()
    {
        int numberGameSessions = FindObjectsOfType<GameSession>().Length;
        if (numberGameSessions > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Update is called once per frame
    public int GetScore()
    {
        return score;
    }

    public int GetHealth()
    {
        return health;
    }

    public void SubtractFromHealth(int damage)
    {
        health -= damage;
    }

    public void AddToScore(int points)
    {
        score += points;
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }

}
