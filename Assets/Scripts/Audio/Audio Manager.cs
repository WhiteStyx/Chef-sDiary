using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    public Audio[] musicSounds, sfxSounds;
    public AudioSource musicSource, sfxSource;

    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        
    }

    void Start()
    {
        PlayMusic("Theme");
    }
    public void PlayMusic(string name)
    {
        Audio s = Array.Find(musicSounds, x => x.clipName == name);
        if(s == null) Debug.Log("Sound Not Found");
        else
        {
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }
}
