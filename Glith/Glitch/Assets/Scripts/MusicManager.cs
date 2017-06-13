using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour {

    //Audio System Remastered
    public AudioClip[] audioChanger;
    private AudioSource audioSource;

    //Make the GameObject Persist
	void Awake () {
        DontDestroyOnLoad(gameObject);
	}
    //Initializating the new Gameobjects
    void Start() {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnLevelWasLoaded(int level)
    {
        
    }

