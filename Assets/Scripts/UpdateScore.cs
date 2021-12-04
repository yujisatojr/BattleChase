using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScore : MonoBehaviour
{
    public Text scoreText_1;
    public Text scoreText_2;

    private void Update()
    {
        scoreText_1.text = "Score: " + EnvManager.Instance.score_1;
        scoreText_2.text = "Score: " + EnvManager.Instance.score_2;
    }
    // Start is called before the first frame update
    public void updateScoreOne()
    {
        EnvManager.Instance.score_1 += 30;
        scoreText_1.text = "Score: " + EnvManager.Instance.score_1;
    }

    public void updateScoreTwo()
    {
        EnvManager.Instance.score_2 += 30;
        scoreText_2.text = "Score: " + EnvManager.Instance.score_2;
    }
}
