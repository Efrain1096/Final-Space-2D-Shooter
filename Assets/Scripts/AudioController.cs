using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioClip death;
    public AudioClip playerFireSound;
    public AudioClip enemyFireSound;
    public AudioClip menuMusic;
    public AudioClip gamePlayMusic;
    public AudioSource Audio;

    void Start()
    {
        Audio = GetComponent<AudioSource>();
    }



}
