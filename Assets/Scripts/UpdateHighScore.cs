using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateHighScore : MonoBehaviour
{
    public Text highScoreText;

    // Update is called once per frame
    void FixedUpdate()
    {
        highScoreText.text = "High Score ..............................................." + EnvManager.Instance.highestScore;
    }
}
