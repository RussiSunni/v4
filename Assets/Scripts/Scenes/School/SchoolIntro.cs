using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SchoolIntro : MonoBehaviour
{
    private float timeRemaining = 5;

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            SceneManager.LoadScene("School001");
        }
    }
}
