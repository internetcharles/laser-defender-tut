using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Text playerHealth;
    private GameSession gameSession;
    // Start is called before the first frame update
    void Start()
    {
        playerHealth.GetComponent<Text>();
        gameSession = FindObjectOfType<GameSession>();
    }

    // Update is called once per frame
    void Update()
    {
        playerHealth.text = $"{gameSession.GetHealth().ToString()} HP";
    }
}
