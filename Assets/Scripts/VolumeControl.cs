using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeControl : MonoBehaviour
{
    public AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        sound.Play();
    }

    // Update is called once per frame
    void Update()
    {
        sound.volume = EnvManager.Instance.soundVolume;
    }
}
