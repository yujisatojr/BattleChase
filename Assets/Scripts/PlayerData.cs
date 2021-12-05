using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int highScore;
    public float volume;

    public PlayerData(Player player)
    {
        highScore = EnvManager.Instance.highestScore;
        volume = EnvManager.Instance.soundVolume;
    }
}
