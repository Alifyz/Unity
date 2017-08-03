using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class LevelManager : MonoBehaviour {

    public float LoadNextLevelTime;
    public bool autoLoad;

	void Start () {

        if(autoLoad == true) { 
            Invoke("LoadNextLevel", LoadNextLevelTime);
        }
			
    }


    public void LoadNextLevel()
    {
        //Obsolate Function
        //Application.LoadLevel(Application.loadedLevel + 1);
        EditorSceneManager.LoadScene(EditorSceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadLevelbyName(string name)
    {
        EditorSceneManager.LoadScene(name);
    }

}
