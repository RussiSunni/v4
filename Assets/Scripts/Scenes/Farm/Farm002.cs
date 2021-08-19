using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Farm002 : MonoBehaviour
{
    public Image questionImage, fairyImage;
    private Sprite fairyIncorrect,
                   fairyNeutral,
                   fairyCorrect;
    int questionNumber = 0;
    Text answerText1, answerText2, answerText3, answerText4;
    public float timeRemaining = 0;
    bool timerReady, correctAnswer, finished = false;
    int score;

    public Text fairyTalk; void Start()
    {
        answerText1 = GameObject.Find("Answer1Text").GetComponent<Text>();
        answerText2 = GameObject.Find("Answer2Text").GetComponent<Text>();
        answerText3 = GameObject.Find("Answer3Text").GetComponent<Text>();
        answerText4 = GameObject.Find("Answer4Text").GetComponent<Text>();
        fairyImage = GameObject.Find("Fairy").GetComponent<Image>();
        fairyTalk = GameObject.Find("FairyTalk").GetComponent<Text>();

        fairyIncorrect = Resources.Load<Sprite>("FairyIncorrect");
        fairyNeutral = Resources.Load<Sprite>("FairyNeutral");
        fairyCorrect = Resources.Load<Sprite>("FairyCorrect");

        timerReady = false;

        Answer1();
    }

    public void Answer1()
    {
      
    }

    public void Answer2()
    {
      

    }
   
    public void Answer3()
    {
     
    }

    public void Answer4()
    {
       
    }
   

  

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            if (correctAnswer)
                fairyImage.sprite = fairyCorrect;
            else
                fairyImage.sprite = fairyIncorrect;
        }
        else
        {
            fairyImage.sprite = fairyNeutral;
         //   ChangeQuestion();
            timerReady = false;
        }
      
        // if (AnimalNamesQuestionBank.questions.Count > 0 && questionNumber != 0)
        // {
        //     if (AnimalNamesQuestionBank.questions[questionNumber - 1].size == 2)
        //     {
        //         RectTransform questionRT = questionImage.GetComponent(typeof(RectTransform)) as RectTransform;
        //         questionRT.sizeDelta = new Vector2(800, 712);
        //         questionRT.anchoredPosition = new Vector2(400, -356);

        //         RectTransform fairyRT = fairyImage.GetComponent(typeof(RectTransform)) as RectTransform;
        //         fairyRT.sizeDelta = new Vector2(250.7f, 446.4f);
        //         fairyRT.anchoredPosition = new Vector2(274.7f, 223.2f);
        //     }
        //     else if (AnimalNamesQuestionBank.questions[questionNumber - 1].size == 1)
        //     {
        //         RectTransform questionRT = questionImage.GetComponent(typeof(RectTransform)) as RectTransform;
        //         questionRT.sizeDelta = new Vector2(400, 712);
        //         questionRT.anchoredPosition = new Vector2(200, -356);

        //         RectTransform fairyRT = fairyImage.GetComponent(typeof(RectTransform)) as RectTransform;
        //         fairyRT.sizeDelta = new Vector2(400f, 712f);
        //         fairyRT.anchoredPosition = new Vector2(200f, 356.1402f);
        //     }
        // }
    }
}
