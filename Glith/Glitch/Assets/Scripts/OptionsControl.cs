using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OptionsControl : MonoBehaviour {

    public Slider volumeSlider;
    public LevelManager levelManager;

    private MusicManager music;


	// Use this for initialization
	void Start () {
        music = GameObject.FindObjectOfType<MusicManager>();
        volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
        Debug.Log(music);
	}
	
	// Update is called once per frame
	void Update () {
        MusicManager.changeLevel(volumeSlider.value);
	}


    public void saveAndExit()
    {
        PlayerPrefsManager.SetMasterVolume(volumeSlider.value);
        levelManager.LoadLevelbyName("menu");
    }
}
