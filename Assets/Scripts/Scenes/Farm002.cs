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
        if (finished)
        {
            //  SceneManager.LoadScene("Scene002");
        }
        else if (questionNumber == 0)
        {
            questionImage.sprite = FarmAnimalNamesQuestionBank.questions[0].sprite;
            answerText1.text = FarmAnimalNamesQuestionBank.questions[0].answerOptions[0];
            answerText2.text = FarmAnimalNamesQuestionBank.questions[0].answerOptions[1];
            answerText3.text = FarmAnimalNamesQuestionBank.questions[0].answerOptions[2];
            answerText4.text = FarmAnimalNamesQuestionBank.questions[0].answerOptions[3];
            print(answerText4.text);

            fairyTalk.text = null;
            questionNumber++;
            GameControl.scene1Started = true;
        }
        else
        {
            if (FarmAnimalNamesQuestionBank.questions[questionNumber - 1].questionName == answerText1.text)
            {
                correctAnswer = true;
                MarkAsKnown();
                SimpleSoundManager.playAnswerSound(FarmAnimalNamesQuestionBank.questions[questionNumber - 1].answerSound);
            }
            else
            {
                correctAnswer = false;
                SimpleSoundManager.playIncorrectSound();
            }

            timeRemaining = 1;
            timerReady = true;
        }
    }
    public void Answer2()
    {
        if (questionNumber != 0)
        {

            if (FarmAnimalNamesQuestionBank.questions[questionNumber - 1].questionName == answerText2.text)
            {
                correctAnswer = true;
                MarkAsKnown();
                SimpleSoundManager.playAnswerSound(FarmAnimalNamesQuestionBank.questions[questionNumber - 1].answerSound);
            }
            else
            {
                correctAnswer = false;
                SimpleSoundManager.playIncorrectSound();
            }

            timeRemaining = 1;
            timerReady = true;
        }
    }
    public void Answer3()
    {
        if (questionNumber != 0)
        {

            if (FarmAnimalNamesQuestionBank.questions[questionNumber - 1].questionName == answerText3.text)
            {
                correctAnswer = true;
                MarkAsKnown();
                SimpleSoundManager.playAnswerSound(FarmAnimalNamesQuestionBank.questions[questionNumber - 1].answerSound);
            }
            else
            {
                correctAnswer = false;
                SimpleSoundManager.playIncorrectSound();
            }

            timeRemaining = 1;
            timerReady = true;
        }
    }
    public void Answer4()
    {
        if (questionNumber != 0)
        {
            if (FarmAnimalNamesQuestionBank.questions[questionNumber - 1].questionName == answerText4.text)
            {
                correctAnswer = true;
                MarkAsKnown();
                SimpleSoundManager.playAnswerSound(FarmAnimalNamesQuestionBank.questions[questionNumber - 1].answerSound);
            }
            else
            {
                correctAnswer = false;
                SimpleSoundManager.playIncorrectSound();
            }

            timeRemaining = 1;
            timerReady = true;
        }
    }
    void ChangeQuestion()
    {
        if (timerReady == true)
        {
            // Debug.Log(questionNumber);
            //  Debug.Log(AnimalNamesQuestionBank.questions.Count);

            if (correctAnswer == true)
            {
                FarmAnimalNamesQuestionBank.questions.RemoveAt(questionNumber - 1);
            }

            else if (questionNumber < AnimalNamesQuestionBank.questions.Count)
            {
                // questionNumber++;
                FarmAnimalNamesQuestionBank.questions.Add(FarmAnimalNamesQuestionBank.questions[0]);
                FarmAnimalNamesQuestionBank.questions.RemoveAt(0);
            }
            else
                questionNumber = 1;

            if (FarmAnimalNamesQuestionBank.questions.Count > 0)
            {
                questionImage.sprite = FarmAnimalNamesQuestionBank.questions[questionNumber - 1].sprite;
                answerText1.text = FarmAnimalNamesQuestionBank.questions[questionNumber - 1].answerOptions[0];
                answerText2.text = FarmAnimalNamesQuestionBank.questions[questionNumber - 1].answerOptions[1];
                answerText3.text = FarmAnimalNamesQuestionBank.questions[questionNumber - 1].answerOptions[2];
                answerText4.text = FarmAnimalNamesQuestionBank.questions[questionNumber - 1].answerOptions[3];
            }
            else
            {
                questionImage.sprite = null;
                fairyTalk.text = "All finished.";
                answerText1.text = "Next";
                answerText2.text = null;
                answerText3.text = null;
                answerText4.text = null;

                finished = true;
            }
        }

        // add Fairy feedback based on how well they do with animals
        score = 0;

        if (score == 20)
        {
            fairyTalk.text = "Wow, you really know this content";
        }
    }


    public void MarkAsKnown()
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
            ChangeQuestion();
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
