using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene003 : MonoBehaviour
{
    bool timerReady, finished, correctAnswer = false;
    public float timeRemaining = 0;
    int questionNumber = 0;
    Text answerText1, answerText2, answerText3, answerText4;
    private Sprite fairyIncorrect,
               fairyNeutral,
               fairyCorrect;
    public Text fairyTalk;
    Image questionImage, fairyImage;
    void Start()
    {
        AnimalActionsQuestionBank.LoadQuestionList();

        answerText1 = GameObject.Find("Answer1Text").GetComponent<Text>();
        answerText2 = GameObject.Find("Answer2Text").GetComponent<Text>();
        answerText3 = GameObject.Find("Answer3Text").GetComponent<Text>();
        answerText4 = GameObject.Find("Answer4Text").GetComponent<Text>();
        questionImage = GetComponent<Image>();
        fairyImage = GameObject.Find("Fairy").GetComponent<Image>();
        fairyTalk = GameObject.Find("FairyTalk").GetComponent<Text>();

        fairyIncorrect = Resources.Load<Sprite>("FairyIncorrect");
        fairyNeutral = Resources.Load<Sprite>("FairyNeutral");
        fairyCorrect = Resources.Load<Sprite>("FairyCorrect");

        timerReady = false;

        if (!GameControl.scene3Started)
        {
            fairyTalk.text = "";
            answerText1.text = "Start";
            SimpleSoundManager.playNextLevelSound();
        }
        else
            Answer1();

    }
    public void Answer1()
    {
        if (finished)
        {
            //   SceneManager.LoadScene("Scene003");
        }
        else if (questionNumber == 0)
        {
            questionImage.color = Color.white;
            fairyTalk.fontSize = 76;

            fairyTalk.text = AnimalActionsQuestionBank.questions[0].fairyTalk;
            questionImage.sprite = AnimalActionsQuestionBank.questions[0].sprite;
            answerText1.text = AnimalActionsQuestionBank.questions[0].answerOptions[0];
            answerText2.text = AnimalActionsQuestionBank.questions[0].answerOptions[1];
            answerText3.text = AnimalActionsQuestionBank.questions[0].answerOptions[2];
            answerText4.text = AnimalActionsQuestionBank.questions[0].answerOptions[3];

            questionNumber++;
            GameControl.scene3Started = true;
        }
        else
        {
            timeRemaining = 1;

            timerReady = true;

            if (AnimalActionsQuestionBank.questions[0].answer == answerText1.text)
            {
                correctAnswer = true;
                MarkAsKnown();
            }

            else
            {
                correctAnswer = false;
                SimpleSoundManager.playIncorrectSound();
            }
        }
    }
    public void Answer2()
    {
        if (!finished)
        {
            if (questionNumber != 0)
            {
                timeRemaining = 1;

                timerReady = true;

                if (AnimalActionsQuestionBank.questions[0].answer == answerText2.text)
                {
                    correctAnswer = true;
                    MarkAsKnown();
                }

                // list
                else if (AnimalActionsQuestionBank.questions[0].answerList.Contains(answerText2.text))
                {
                    correctAnswer = true;
                    MarkAsKnown();
                }

                else
                {
                    correctAnswer = false;
                    SimpleSoundManager.playIncorrectSound();
                }
            }
        }
    }
    public void Answer3()
    {
        if (!finished)
        {
            if (questionNumber != 0)
            {
                timeRemaining = 1;

                timerReady = true;

                if (AnimalActionsQuestionBank.questions[questionNumber - 1].answer == answerText3.text)
                {
                    correctAnswer = true;
                    MarkAsKnown();
                }

                // list
                else if (AnimalActionsQuestionBank.questions[questionNumber - 1].answerList.Contains(answerText3.text))
                {
                    correctAnswer = true;
                    MarkAsKnown();
                }

                else
                {
                    correctAnswer = false;
                    SimpleSoundManager.playIncorrectSound();
                }
            }
        }
    }
    public void Answer4()
    {
        if (!finished)
        {
            if (questionNumber != 0)
            {
                timeRemaining = 1;

                timerReady = true;

                if (AnimalActionsQuestionBank.questions[questionNumber - 1].answer == answerText4.text)
                {
                    correctAnswer = true;
                    MarkAsKnown();
                }

                // list
                else if (AnimalActionsQuestionBank.questions[questionNumber - 1].answerList.Contains(answerText4.text))
                {
                    correctAnswer = true;
                    MarkAsKnown();
                }

                else
                {
                    correctAnswer = false;
                    SimpleSoundManager.playIncorrectSound();
                }
            }
        }
    }

    void ChangeQuestion()
    {
        if (timerReady == true)
        {
            // Debug.Log(AnimalFoodQuestionBank.questions.Count);

            if (correctAnswer == true)
            {
                AnimalActionsQuestionBank.questions.RemoveAt(0);
            }

            else if (questionNumber < AnimalActionsQuestionBank.questions.Count)
            {
                AnimalActionsQuestionBank.questions.Add(AnimalActionsQuestionBank.questions[0]);
                AnimalActionsQuestionBank.questions.RemoveAt(0);
            }
            else
                questionNumber = 1;

            if (AnimalActionsQuestionBank.questions.Count > 0)
            {
                fairyTalk.text = AnimalActionsQuestionBank.questions[0].fairyTalk;
                questionImage.sprite = AnimalActionsQuestionBank.questions[0].sprite;
                answerText1.text = AnimalActionsQuestionBank.questions[0].answerOptions[0];
                answerText2.text = AnimalActionsQuestionBank.questions[0].answerOptions[1];
                answerText3.text = AnimalActionsQuestionBank.questions[0].answerOptions[2];
                answerText4.text = AnimalActionsQuestionBank.questions[0].answerOptions[3];
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
    }
}