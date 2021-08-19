using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Intro01Script : MonoBehaviour
{
    private float timeRemaining = 2;
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            SceneManager.LoadScene("Intro2");
        }
    }
}







