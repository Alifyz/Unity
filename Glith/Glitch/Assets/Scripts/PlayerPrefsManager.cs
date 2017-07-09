using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
public class PlayerPrefsManager : MonoBehaviour {

    /// <summary>
    /// KEYS, That are being Stored in the PlayerPrefs Component Build in Unity3D
    /// </summary>
    const string MASTER_VOLUME_KEY = "master_volume";
    const string DIFFICULTY_KEY = "difficulty";
    const string LEVEL_KEY = "level_unloked_";

    //SET The Volume of the Game Using PlayerPrefs
    public static void SetMasterVolume(float volume)
    {
        if(volume > 0f && volume < 1f) { 
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        } else
        {
            Debug.LogError("Set the Value betwen 0 - 1");
        }
    }

    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }

    public static void SetLevel(int level)
    {
        if(level <= EditorSceneManager.sceneCountInBuildSettings - 1)
        {
            PlayerPrefs.SetInt(LEVEL_KEY + level.ToString(), 1);
        }
        else
        {
            Debug.LogError("Not in the Build Order");
        }
    }

    public static void SetDifficulty(float difficulty) {
        if(difficulty >= 0f && difficulty <= 1f)
        {
            PlayerPrefs.SetFloat(DIFFICULTY_KEY, difficulty);
        }
        else
        {
            Debug.Log("Set Difficulty out of the Range");
        }
    }

    public static float GetDifficulty()
    {
        return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
    }

    


	
}
