using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateHighScore : MonoBehaviour
{
    // Update is called once per frame
    public void calculateHighScore()
    {
        if (EnvManager.Instance.score_1 > EnvManager.Instance.score_2)
        {
            if (EnvManager.Instance.score_1 > EnvManager.Instance.highestScore)
            {
                EnvManager.Instance.highestScore = EnvManager.Instance.score_1;
            }
        }
        if (EnvManager.Instance.score_2 > EnvManager.Instance.score_1)
        {
            if (EnvManager.Instance.score_2 > EnvManager.Instance.highestScore)
            {
                EnvManager.Instance.highestScore = EnvManager.Instance.score_2;
            }
        }
    }
}
