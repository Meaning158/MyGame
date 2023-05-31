using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioBoss : MonoBehaviour
{
    public AudioClip blood;
    public AudioClip scream;
    public AudioClip die;
    public void AudioScream()
    {
        GetComponent<AudioSource>().PlayOneShot(scream);
    }
    public void AudioDie()
    {
        GetComponent<AudioSource>().PlayOneShot(die);
    }
    public void AudioBlood()
    {
        GetComponent<AudioSource>().PlayOneShot(blood);
    }
}
