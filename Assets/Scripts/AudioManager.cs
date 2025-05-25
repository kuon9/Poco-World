using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public AudioSource mainMenuMusic, levelMusic;
    public AudioSource [] Sfx;

    public void PlayMainMenuMusic()
    {
        if(!levelMusic.isPlaying)
        {
            levelMusic.Stop();
            mainMenuMusic.Play();        
        }
    }


    public void PlayLevelMusic()
    {    
        mainMenuMusic.Stop();
        levelMusic.Play();    
    }
    

    // Responsible for dictating what sound effect to play based on its assigned int
    public void PlaySFX(int sfxToPlay)
    {
        Sfx[sfxToPlay].Stop();
        Sfx[sfxToPlay].Play();     
    }

    // Randomizes pitch so it never sounds the same and gets annoying
    public void PlaySFXAdjusted(int sfxToAdjust)
    {
        Sfx[sfxToAdjust].pitch = Random.Range(.8f, 1.2f);
        Sfx[sfxToAdjust].volume = Random.Range(.7f, .9f);
        PlaySFX(sfxToAdjust);
    }
}
