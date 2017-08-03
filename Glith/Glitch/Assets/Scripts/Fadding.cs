using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fadding : MonoBehaviour {

    public float faddingTime = 2.0f;
    private Image fadeTexture;
    private Color currentColor = Color.black;

    void Start()
    {
        fadeTexture = GetComponent<Image>();
    }


    //Transition Effect FadeIN Login
    //Changin the Alpha Channel.
     void Update()
    {
        if (Time.timeSinceLevelLoad < faddingTime)
            {
                float alphaChange = Time.deltaTime / faddingTime;
                currentColor.a -= alphaChange;
                fadeTexture.color = currentColor;
            }

        else
            {
                gameObject.SetActive(false);
            }
    }





}
