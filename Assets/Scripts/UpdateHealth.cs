using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateHealth : MonoBehaviour
{
    public Text healthText_1;
    public Text healthText_2;

    private void Update()
    {
        healthText_1.text = "Health: " + EnvManager.Instance.health_1;
        healthText_2.text = "Health: " + EnvManager.Instance.health_2;
    }
    // Start is called before the first frame update
    public void updateHealthOne()
    {
        EnvManager.Instance.health_1 += 30;
        healthText_1.text = "Health: " + EnvManager.Instance.health_1;
    }

    public void updateHealthTwo()
    {
        EnvManager.Instance.health_2 += 30;
        healthText_2.text = "Health: " + EnvManager.Instance.health_2;
    }
}
