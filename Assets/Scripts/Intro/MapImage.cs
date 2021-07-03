using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MapImage : MonoBehaviour
{


    public Sprite map1Img;
    public Sprite map2Img;
    public Sprite map3Img;

    public int imgNumberCount;


    public void changeImages() // make sure to attach this to event trigger
    {
        switch (imgNumberCount)
        {

            case 0:
                GetComponent<Image>().sprite = map2Img;
                imgNumberCount++; //increase count so it gets higher and switches to different sprite
                break;
            case 1:
                GetComponent<Image>().sprite = map3Img;
                imgNumberCount++;
                break;
            case 2:

                imgNumberCount++;
                break;
            case 3:

                imgNumberCount++;
                imgNumberCount = 0; //Reset it to 0
                break;
            default:
                Debug.Log("Error");
                break;
        }
    }
}
