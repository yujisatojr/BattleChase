using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnvManager : MonoBehaviour
{
    public static EnvManager Instance;
    private int maxHealth = 1000;
    public int health_1;
    public int health_2;
    public int score_1;
    public int score_2;

    public float soundVolume;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
 

    private void Start()
    {
        health_1 = maxHealth;
        health_2 = maxHealth;
        soundVolume = 1;
    }

    private void Update()
    {

    }
    /*
    public void setHealth(int damage)
    {
        health_1 += damage;
    }

    public int getHealth()
    {
        return health;
    }

    public int getScore()
    {
        return score;
    }*/
}
