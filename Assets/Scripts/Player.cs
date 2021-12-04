using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int highScore;

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        //highScore = data.highScore;
        EnvManager.Instance.highestScore = data.highScore;
        EnvManager.Instance.soundVolume = data.volume;
    }
}
