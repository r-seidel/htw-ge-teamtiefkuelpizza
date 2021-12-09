using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public SoundFiles[] sounds;

    void Awake()
    {
        foreach(SoundFiles s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
        
    }

    public void Play (string name)
    {
        SoundFiles s = Array.Find(sounds, sound => sound.name == name);
        //https://www.youtube.com/watch?v=6OT43pvUyfY&t=207s
        s.source.Play();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
