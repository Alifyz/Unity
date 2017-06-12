using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class LevelManager : MonoBehaviour {

    public float LoadNextLevelTime;

	void Start () {
        Invoke("LoadNextLevel", LoadNextLevelTime);
	}


    public void LoadNextLevel()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
        
    }

}
