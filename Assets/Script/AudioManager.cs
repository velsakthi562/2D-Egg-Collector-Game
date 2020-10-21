using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager Instance;

    public AudioClip eggCraking;
    public AudioClip collectingEgg;
    public AudioClip dropEgg;

    private void Awake()
    {
        Instance = this;
    }

    public void PlayAudio(AudioClip clip)
    {

        //AudioSource.Play(clip);

    }

}
