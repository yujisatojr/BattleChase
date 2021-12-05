using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControl : MonoBehaviour
{
    private int maxHealth = 1000;
    public void LoadScene(int level)
    {
        EnvManager.Instance.health_1 = maxHealth;
        EnvManager.Instance.health_2 = maxHealth;
        SceneManager.LoadScene(level);
    }
}
