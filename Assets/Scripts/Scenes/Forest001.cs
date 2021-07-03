using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Forest001 : MonoBehaviour
{
    int questionNumber;

    public Text NPCText, answerText1, answerText2, answerText3, answerText4;
    void Start()
    {
        questionNumber = 1;
        NPCText.text = "Hello";
        SimpleSoundManager.PlaySound(SimpleSoundManager.forest001Q001);
        answerText1.text = "thank you";
        answerText2.text = "hello";
        answerText3.text = "goodbye";
    }

    public void AnswerButton01()
    {
        if (questionNumber == 1)
        {
            // wrong
        }
        else if (questionNumber == 2)
        {
            // wrong
        }
        else if (questionNumber == 3)
        {
            // right
            questionNumber = 4;
            ChangeQuestion();
        }
        else if (questionNumber == 4)
        {
            //AnimalNamesQuestionBank.LoadQuestionList();
            SceneManager.LoadScene("Forest002");
        }
    }

    public void AnswerButton02()
    {
        if (questionNumber == 1)
        {
            // right
            questionNumber = 2;
            ChangeQuestion();
        }
        else if (questionNumber == 2)
        {
            // wrong
        }
        else if (questionNumber == 3)
        {
            // wrong
        }
    }

    public void AnswerButton03()
    {
        if (questionNumber == 1)
        {
            // wrong
        }
        else if (questionNumber == 2)
        {
            //right
            questionNumber = 3;
            ChangeQuestion();
        }
        else if (questionNumber == 3)
        {
            // wrong
        }
    }


    public void ChangeQuestion()
    {
        if (questionNumber == 2)
        {
            SimpleSoundManager.PlaySound(SimpleSoundManager.forest001Q002);
            NPCText.text = "Welcome to my forest";
            answerText1.text = "hello";
            answerText2.text = "goodbye";
            answerText3.text = "thank you";
        }

        else if (questionNumber == 3)
        {
            SimpleSoundManager.PlaySound(SimpleSoundManager.forest001Q003);
            NPCText.text = "Can you help me?";
            answerText1.text = "yes";
            answerText2.text = "hello";
            answerText3.text = "goodbye";
        }

        else if (questionNumber == 4)
        {
            SimpleSoundManager.PlaySound(SimpleSoundManager.forest001Q004);
            NPCText.text = "Please tell me the names of the animals";
            answerText1.text = "Start";
            answerText2.text = "";
            answerText3.text = "";
        }
    }
}
