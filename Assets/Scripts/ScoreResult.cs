using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreResult : MonoBehaviour
{
    public Text scoreText_1;
    public Text scoreText_2;

    private void FixedUpdate()
    {
        scoreText_1.text = "Player 1 ....................................................." + EnvManager.Instance.score_1;
        scoreText_2.text = "Player 2 ...................................................." + EnvManager.Instance.score_2;
    }
}
