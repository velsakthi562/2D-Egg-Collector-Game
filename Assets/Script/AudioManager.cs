using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager Instance;

    public AudioSource audioSource;

    public AudioClip eggCraking;
    public AudioClip collectingEgg;
    public AudioClip dropEgg;
    public AudioClip buttonClick;
    

    private void Awake()
    {
        Instance = this;
    }

    public void PlayAudio(AudioClip clip)
    {

        audioSource.clip = clip;
        audioSource.Play();

    }

}
