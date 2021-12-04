using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    public AudioSource sound;
    public float soundVolume = 1;

    // Start is called before the first frame update
    void Start()
    {
        sound.Play();
    }

    // Update is called once per frame
    void Update()
    {
        sound.volume = soundVolume;
    }

    public void updateVolume(float volume)
    {
        soundVolume = volume;
        EnvManager.Instance.soundVolume = volume;
    }
}
