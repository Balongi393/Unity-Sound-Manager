using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    private Dictionary<string, AudioClip> gameplaySounds;
    private Dictionary<string, AudioClip> uiSounds;
    private Dictionary<string, AudioClip> backgroundSounds;

    private AudioSource audioSource;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

            // Initialize dictionaries
            gameplaySounds = new Dictionary<string, AudioClip>();
            uiSounds = new Dictionary<string, AudioClip>();
            backgroundSounds = new Dictionary<string, AudioClip>();

            // Add your audio clips to the dictionaries
            // Example: gameplaySounds.Add("Jump", Resources.Load<AudioClip>("Gameplay/JumpSound"));
            // Example: uiSounds.Add("ButtonClick", Resources.Load<AudioClip>("UI/ButtonClick"));
            // Example: backgroundSounds.Add("MainMenu", Resources.Load<AudioClip>("Background/MainMenuMusic"));

            // Get the AudioSource component
            audioSource = GetComponent<AudioSource>();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayGameplaySound(string soundName)
    {
        PlaySound(soundName, gameplaySounds);
    }

    public void PlayUISound(string soundName)
    {
        PlaySound(soundName, uiSounds);
    }

    public void PlayBackgroundSound(string soundName)
    {
        PlaySound(soundName, backgroundSounds, true);
    }

    private void PlaySound(string soundName, Dictionary<string, AudioClip> soundDictionary, bool loop = false)
    {
        if (soundDictionary.ContainsKey(soundName))
        {
            audioSource.clip = soundDictionary[soundName];
            audioSource.loop = loop;
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("Sound not found: " + soundName);
        }
    }
}
