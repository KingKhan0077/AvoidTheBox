using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    public AudioMixer audiomixer;

   

   // public void stopeSound()
   // {
    //    audiomixer.SetFloat("Volume", -80);
    //
    //}

   public  AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void stopSound()
    {
        
            audioSource.mute = !audioSource.mute;
    }

}
