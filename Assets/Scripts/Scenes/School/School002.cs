using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class School002 : MonoBehaviour
{
    public Image questionImage, secretaryImage;
    public Sprite secretarySprite, secretaryCorrect;
    public Sprite secretaryNeutral, secretaryIncorrect;
    int questionNumber = 0;
    Text answerText1, answerText2, answerText3, answerText4;
    public float timeRemaining = 0;
    bool timerReady, correctAnswer, finished = false;
    int score;
    public Text secretaryTalk;

    void Start()
    {
        answerText1 = GameObject.Find("Answer1Text").GetComponent<Text>();
        answerText2 = GameObject.Find("Answer2Text").GetComponent<Text>();
        answerText3 = GameObject.Find("Answer3Text").GetComponent<Text>();
        answerText4 = GameObject.Find("Answer4Text").GetComponent<Text>();

        //  secretaryTalk = GameObject.Find("FairyTalk").GetComponent<Text>();

        //fairyIncorrect = Resources.Load<Sprite>("FairyIncorrect");
        //fairyNeutral = Resources.Load<Sprite>("FairyNeutral");
        //fairyCorrect = Resources.Load<Sprite>("FairyCorrect");
        //  secretaryNeutral = Resources.Load<Sprite>("ArtemisNeutral");
        //  secretaryIncorrect = Resources.Load<Sprite>("ArtemisIncorrect");
        //   secretaryCorrect = Resources.Load<Sprite>("ArtemisCorrect");

        timerReady = false;

        // if (!GameControl.scene1Started)
        // {
        //  fairyTalk.text = "Hi, learner. Let’s help the animals find their names.";
        //   SoundManager.playScene1Intro();
        //  answerText1.text = "Start";
        //  }
        // else
        Answer1();

        //print(SchoolQuestionBank.questions[0].answerOptions[0]);
    }

    public void Answer1()
    {
        if (finished)
        {
            SceneManager.LoadScene("School003");
        }
        else if (questionNumber == 0)
        {
            questionImage.sprite = SchoolQuestionBank.questions[0].sprite;
            answerText1.text = SchoolQuestionBank.questions[0].answerOptions[0];
            answerText2.text = SchoolQuestionBank.questions[0].answerOptions[1];
            answerText3.text = SchoolQuestionBank.questions[0].answerOptions[2];
            answerText4.text = SchoolQuestionBank.questions[0].answerOptions[3];

            secretaryTalk.text = null;
            questionNumber++;
            GameControl.scene1Started = true;
        }
        else
        {
            if (SchoolQuestionBank.questions[questionNumber - 1].questionName == answerText1.text)
            {
                correctAnswer = true;
                MarkAsKnown();
                // SoundManager.playAnswerSound(SchoolQuestionBank.questions[questionNumber - 1].answerSound);
            }
            else
            {
                correctAnswer = false;
                // SoundManager.playIncorrectSound();
            }

            timeRemaining = 1;
            timerReady = true;
        }
    }
    public void Answer2()
    {
        if (questionNumber != 0)
        {

            if (SchoolQuestionBank.questions[questionNumber - 1].questionName == answerText2.text)
            {
                correctAnswer = true;
                MarkAsKnown();
                // SoundManager.playAnswerSound(SchoolQuestionBank.questions[questionNumber - 1].answerSound);
            }
            else
            {
                correctAnswer = false;
                //  SoundManager.playIncorrectSound();
            }

            timeRemaining = 1;
            timerReady = true;
        }
    }
    public void Answer3()
    {
        if (questionNumber != 0)
        {

            if (SchoolQuestionBank.questions[questionNumber - 1].questionName == answerText3.text)
            {
                correctAnswer = true;
                MarkAsKnown();
                //  SoundManager.playAnswerSound(SchoolQuestionBank.questions[questionNumber - 1].answerSound);
            }
            else
            {
                correctAnswer = false;
                //  SoundManager.playIncorrectSound();
            }

            timeRemaining = 1;
            timerReady = true;
        }
    }
    public void Answer4()
    {
        if (questionNumber != 0)
        {
            if (SchoolQuestionBank.questions[questionNumber - 1].questionName == answerText4.text)
            {
                correctAnswer = true;
                MarkAsKnown();
                //  SoundManager.playAnswerSound(SchoolQuestionBank.questions[questionNumber - 1].answerSound);
            }
            else
            {
                correctAnswer = false;
                // SoundManager.playIncorrectSound();
            }

            timeRemaining = 1;
            timerReady = true;
        }
    }
    void ChangeQuestion()
    {
        if (timerReady == true)
        {
            Debug.Log(questionNumber);
            Debug.Log(SchoolQuestionBank.questions.Count);

            if (correctAnswer == true)
            {
                SchoolQuestionBank.questions.RemoveAt(questionNumber - 1);
            }

            else if (questionNumber < SchoolQuestionBank.questions.Count)
            {
                // questionNumber++;
                SchoolQuestionBank.questions.Add(SchoolQuestionBank.questions[0]);
                SchoolQuestionBank.questions.RemoveAt(0);
            }
            else
                questionNumber = 1;

            if (SchoolQuestionBank.questions.Count > 0)
            {
                questionImage.sprite = SchoolQuestionBank.questions[questionNumber - 1].sprite;
                answerText1.text = SchoolQuestionBank.questions[questionNumber - 1].answerOptions[0];
                answerText2.text = SchoolQuestionBank.questions[questionNumber - 1].answerOptions[1];
                answerText3.text = SchoolQuestionBank.questions[questionNumber - 1].answerOptions[2];
                answerText4.text = SchoolQuestionBank.questions[questionNumber - 1].answerOptions[3];
            }
            else
            {
                questionImage.sprite = null;
                secretaryTalk.text = "All finished.";
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
            secretaryTalk.text = "Wow, you really know this content";
        }
    }

    public void MarkAsKnown()
    {
        SchoolQuestionBank.questions[questionNumber - 1].known = true;

        if (SchoolQuestionBank.questions[questionNumber - 1].number == 1)
        {
            GameControl.animalName001known = true;
        }
        else if (SchoolQuestionBank.questions[questionNumber - 1].number == 2)
        {
            GameControl.animalName002known = true;
        }
        else if (SchoolQuestionBank.questions[questionNumber - 1].number == 3)
        {
            GameControl.animalName003known = true;
        }
        if (SchoolQuestionBank.questions[questionNumber - 1].number == 4)
        {
            GameControl.animalName004known = true;
        }
        else if (SchoolQuestionBank.questions[questionNumber - 1].number == 5)
        {
            GameControl.animalName005known = true;
        }
        else if (SchoolQuestionBank.questions[questionNumber - 1].number == 6)
        {
            GameControl.animalName006known = true;
        }
        if (SchoolQuestionBank.questions[questionNumber - 1].number == 7)
        {
            GameControl.animalName007known = true;
        }
        else if (SchoolQuestionBank.questions[questionNumber - 1].number == 8)
        {
            GameControl.animalName008known = true;
        }
        else if (SchoolQuestionBank.questions[questionNumber - 1].number == 9)
        {
            GameControl.animalName009known = true;
        }
        if (SchoolQuestionBank.questions[questionNumber - 1].number == 10)
        {
            GameControl.animalName010known = true;
        }
        else if (SchoolQuestionBank.questions[questionNumber - 1].number == 11)
        {
            GameControl.animalName011known = true;
        }
        else if (SchoolQuestionBank.questions[questionNumber - 1].number == 12)
        {
            GameControl.animalName012known = true;
        }
        else if (SchoolQuestionBank.questions[questionNumber - 1].number == 13)
        {
            GameControl.animalName013known = true;
        }
        if (SchoolQuestionBank.questions[questionNumber - 1].number == 14)
        {
            GameControl.animalName014known = true;
        }
        else if (SchoolQuestionBank.questions[questionNumber - 1].number == 15)
        {
            GameControl.animalName015known = true;
        }
        else if (SchoolQuestionBank.questions[questionNumber - 1].number == 16)
        {
            GameControl.animalName016known = true;
        }
        if (SchoolQuestionBank.questions[questionNumber - 1].number == 17)
        {
            GameControl.animalName017known = true;
        }
        else if (SchoolQuestionBank.questions[questionNumber - 1].number == 18)
        {
            GameControl.animalName018known = true;
        }
        else if (SchoolQuestionBank.questions[questionNumber - 1].number == 19)
        {
            GameControl.animalName019known = true;
        }
        else if (SchoolQuestionBank.questions[questionNumber - 1].number == 20)
        {
            GameControl.animalName020known = true;
        }
        if (SchoolQuestionBank.questions[questionNumber - 1].number == 21)
        {
            GameControl.animalName021known = true;
        }
        else if (SchoolQuestionBank.questions[questionNumber - 1].number == 22)
        {
            GameControl.animalName022known = true;
        }
        else if (SchoolQuestionBank.questions[questionNumber - 1].number == 23)
        {
            GameControl.animalName023known = true;
        }
    }

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            if (correctAnswer)
                secretaryImage.sprite = secretaryCorrect;
            else
                secretaryImage.sprite = secretaryIncorrect;
        }
        else
        {
            secretaryImage.sprite = secretaryNeutral;
            ChangeQuestion();
            timerReady = false;
        }
        // if (SchoolQuestionBank.questions.Count > 0 && questionNumber != 0)
        // {
        //     if (SchoolQuestionBank.questions[questionNumber - 1].size == 2)
        //     {
        //         RectTransform questionRT = questionImage.GetComponent(typeof(RectTransform)) as RectTransform;
        //         questionRT.sizeDelta = new Vector2(800, 712);
        //         questionRT.anchoredPosition = new Vector2(400, -356);

        //         RectTransform fairyRT = fairyImage.GetComponent(typeof(RectTransform)) as RectTransform;
        //         fairyRT.sizeDelta = new Vector2(250.7f, 446.4f);
        //         fairyRT.anchoredPosition = new Vector2(274.7f, 223.2f);
        //     }
        //     else if (SchoolQuestionBank.questions[questionNumber - 1].size == 1)
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
