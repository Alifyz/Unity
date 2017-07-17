using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{

    //Audio System Remastered
    public AudioClip[] audioChanger;
    private AudioSource audioSource;

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    //Make the GameObject Persist
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    //Initializating the new Gameobjects
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        AudioClip thisLevelMusic = audioChanger[scene.buildIndex];
        if(thisLevelMusic)
        {
            audioSource.clip = thisLevelMusic;
            audioSource.loop = true;
            audioSource.Play();
        }
    }

    public static void changeLevel(float volume)
    {
        GameObject.FindObjectOfType<AudioSource>().volume = volume;
    }
    
    

}