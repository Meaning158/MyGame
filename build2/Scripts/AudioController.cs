using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSource;
    void Start()
    {
        
        if (PlayerPrefs.HasKey("volume")) audioSource.volume = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        audioSource.volume = PlayerPrefs.GetFloat("volume");
    }
}
