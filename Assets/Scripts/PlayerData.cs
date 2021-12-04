using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int highScore;

    public PlayerData(Player player)
    {
        highScore = player.highScore;
    }
}
