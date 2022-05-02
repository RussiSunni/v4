using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Forest002 : MonoBehaviour
{
    public Image questionImage, fairyImage;
    private Sprite fairyIncorrect,
                   fairyNeutral,
                   fairyCorrect;

    public Sprite artemisSprite;
    int questionNumber = 0;
    Text answerText1, answerText2, answerText3, answerText4;
    bool correctAnswer, finished = false;
    int score;
    public Text fairyTalk;

    void Start()
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

        Answer1();
    }

    public void Answer1()
    {
        if (finished)
        {
            SceneManager.LoadScene("Forest003");
        }
        else if (questionNumber == 0)
        {
            //questionImage.sprite = Resources.Load<Sprite>("Questions/Animals/Bear");
            questionImage.sprite = AnimalsQuestionBank.questions[0].sprite;
            answerText1.text = AnimalsQuestionBank.questions[0].answerOptions[0];
            answerText2.text = AnimalsQuestionBank.questions[0].answerOptions[1];
            answerText3.text = AnimalsQuestionBank.questions[0].answerOptions[2];
            answerText4.text = AnimalsQuestionBank.questions[0].answerOptions[3];
            //print(answerText4.text);

            fairyTalk.text = null;
            questionNumber++;
            GameControl.scene1Started = true;
        }
        else
        {
            if (AnimalsQuestionBank.questions[questionNumber - 1].questionName == answerText1.text)
            {
                correctAnswer = true;
                MarkAsKnown();
                SoundManager.playCorrectSound();
            }
            else
            {
                correctAnswer = false;
                SoundManager.playIncorrectSound();
            }

            StartCoroutine(ChangeQuestion());
        }
    }
    public void Answer2()
    {
        if (questionNumber != 0)
        {
            if (AnimalsQuestionBank.questions[questionNumber - 1].questionName == answerText2.text)
            {
                correctAnswer = true;
                MarkAsKnown();
                SoundManager.playCorrectSound();
            }
            else
            {
                correctAnswer = false;
                SoundManager.playIncorrectSound();
            }
        }

        StartCoroutine(ChangeQuestion());
    }
    public void Answer3()
    {
        if (questionNumber != 0)
        {

            if (AnimalsQuestionBank.questions[questionNumber - 1].questionName == answerText3.text)
            {
                correctAnswer = true;
                MarkAsKnown();
                SoundManager.playCorrectSound();
            }
            else
            {
                correctAnswer = false;
                SoundManager.playIncorrectSound();
            }
        }

        StartCoroutine(ChangeQuestion());
    }
    public void Answer4()
    {
        if (questionNumber != 0)
        {
            if (AnimalsQuestionBank.questions[questionNumber - 1].questionName == answerText4.text)
            {
                correctAnswer = true;
                MarkAsKnown();
                SoundManager.playCorrectSound();
            }
            else
            {
                correctAnswer = false;
                SoundManager.playIncorrectSound();
            }
        }

        StartCoroutine(ChangeQuestion());
    }
    IEnumerator ChangeQuestion()
    {
        if (correctAnswer == true)
        {
            fairyImage.sprite = fairyCorrect;
        }
        else if (correctAnswer == false)
        {
            fairyImage.sprite = fairyIncorrect;
        }

        yield return new WaitForSeconds(2);


        fairyImage.sprite = fairyNeutral;

        if (correctAnswer == true)
        {
            AnimalsQuestionBank.questions.RemoveAt(questionNumber - 1);
        }
        else if (questionNumber < AnimalsQuestionBank.questions.Count)
        {
            // questionNumber++;
            AnimalsQuestionBank.questions.Add(AnimalsQuestionBank.questions[0]);
            AnimalsQuestionBank.questions.RemoveAt(0);
        }
        else
            questionNumber = 1;

        if (AnimalsQuestionBank.questions.Count > 0)
        {
            questionImage.sprite = AnimalsQuestionBank.questions[questionNumber - 1].sprite;
            answerText1.text = AnimalsQuestionBank.questions[questionNumber - 1].answerOptions[0];
            answerText2.text = AnimalsQuestionBank.questions[questionNumber - 1].answerOptions[1];
            answerText3.text = AnimalsQuestionBank.questions[questionNumber - 1].answerOptions[2];
            answerText4.text = AnimalsQuestionBank.questions[questionNumber - 1].answerOptions[3];
            SoundManager.playAnswerSound(AnimalsQuestionBank.questions[questionNumber - 1].answerSound);
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

        // add Fairy feedback based on how well they do with animals
        score = 0;

        if (score == 20)
        {
            fairyTalk.text = "Wow, you really know this content";
        }
    }

    public void MarkAsKnown()
    {
        AnimalsQuestionBank.questions[questionNumber - 1].known = true;

        if (AnimalsQuestionBank.questions[questionNumber - 1].number == 1)
        {
            GameControl.animalName001known = true;
        }
        else if (AnimalsQuestionBank.questions[questionNumber - 1].number == 2)
        {
            GameControl.animalName002known = true;
        }
        else if (AnimalsQuestionBank.questions[questionNumber - 1].number == 3)
        {
            GameControl.animalName003known = true;
        }
        if (AnimalsQuestionBank.questions[questionNumber - 1].number == 4)
        {
            GameControl.animalName004known = true;
        }
        else if (AnimalsQuestionBank.questions[questionNumber - 1].number == 5)
        {
            GameControl.animalName005known = true;
        }
        else if (AnimalsQuestionBank.questions[questionNumber - 1].number == 6)
        {
            GameControl.animalName006known = true;
        }
        if (AnimalsQuestionBank.questions[questionNumber - 1].number == 7)
        {
            GameControl.animalName007known = true;
        }
        else if (AnimalsQuestionBank.questions[questionNumber - 1].number == 8)
        {
            GameControl.animalName008known = true;
        }
        else if (AnimalsQuestionBank.questions[questionNumber - 1].number == 9)
        {
            GameControl.animalName009known = true;
        }
        if (AnimalsQuestionBank.questions[questionNumber - 1].number == 10)
        {
            GameControl.animalName010known = true;
        }
        else if (AnimalsQuestionBank.questions[questionNumber - 1].number == 11)
        {
            GameControl.animalName011known = true;
        }
        else if (AnimalsQuestionBank.questions[questionNumber - 1].number == 12)
        {
            GameControl.animalName012known = true;
        }
        else if (AnimalsQuestionBank.questions[questionNumber - 1].number == 13)
        {
            GameControl.animalName013known = true;
        }
        if (AnimalsQuestionBank.questions[questionNumber - 1].number == 14)
        {
            GameControl.animalName014known = true;
        }
        else if (AnimalsQuestionBank.questions[questionNumber - 1].number == 15)
        {
            GameControl.animalName015known = true;
        }
        else if (AnimalsQuestionBank.questions[questionNumber - 1].number == 16)
        {
            GameControl.animalName016known = true;
        }
        if (AnimalsQuestionBank.questions[questionNumber - 1].number == 17)
        {
            GameControl.animalName017known = true;
        }
        else if (AnimalsQuestionBank.questions[questionNumber - 1].number == 18)
        {
            GameControl.animalName018known = true;
        }
        else if (AnimalsQuestionBank.questions[questionNumber - 1].number == 19)
        {
            GameControl.animalName019known = true;
        }
        else if (AnimalsQuestionBank.questions[questionNumber - 1].number == 20)
        {
            GameControl.animalName020known = true;
        }
        if (AnimalsQuestionBank.questions[questionNumber - 1].number == 21)
        {
            GameControl.animalName021known = true;
        }
        else if (AnimalsQuestionBank.questions[questionNumber - 1].number == 22)
        {
            GameControl.animalName022known = true;
        }
        else if (AnimalsQuestionBank.questions[questionNumber - 1].number == 23)
        {
            GameControl.animalName023known = true;
        }
    }
}
