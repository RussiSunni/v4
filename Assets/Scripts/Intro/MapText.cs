using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class MapText : MonoBehaviour
{
    Text txt;

    public int txtNumberCount;


    public void changeText() // make sure to attach this to event trigger
    {
        switch (txtNumberCount)
        {

            case 0:
                txt = gameObject.GetComponent<Text>();
                txt.text = "Welcome, we have been waiting for you.";
                txtNumberCount++; //increase count so it gets higher and switches to different sprite
                break;
            case 1:
                txt = gameObject.GetComponent<Text>();
                txt.text = txt.text + "\n\n This is Wild World. All knowledge has been lost.";
                txtNumberCount++;
                break;
            case 2:
                txt = gameObject.GetComponent<Text>();
                txt.text = txt.text + "\n\n There are many people that need your help";
                txtNumberCount++;
                break;
            case 3:
                SceneManager.LoadScene("WorldMap");
                txtNumberCount++;
                txtNumberCount = 0; //Reset it to 0
                break;
            default:
                Debug.Log("Error");
                break;
        }
    }
}
