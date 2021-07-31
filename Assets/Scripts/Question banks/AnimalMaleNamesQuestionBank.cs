using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMaleNamesQuestionBank : Question
{
    public static List<Question> questions = new List<Question>();
    public static Question animalMaleName001 = new Question();
    public static Question animalMaleName002 = new Question();
    public static Question animalMaleName003 = new Question();
    public static Question animalMaleName004 = new Question();

    void Start()
    {
        animalMaleName001 = new Question()
        {
            number = 1,
            questionName = "boar",
            sprite = null,
            answerOptions = new List<string>()
        {
            "badger",
            "guinea pig",
            "mole",
            "hedgehog"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalMaleName002 = new Question()
        {
            number = 2,
            questionName = "buck",
            sprite = null,
            answerOptions = new List<string>()
        {
            "rabbit",
            "squirrel",
            "rat",
            "hare"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalMaleName003 = new Question()
        {
            number = 1,
            questionName = "jack",
            sprite = null,
            answerOptions = new List<string>()
        {
            "hamster",
            "hare",
            "donkey",
            "weasel"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalMaleName004 = new Question()
        {
            number = 1,
            questionName = "hen",
            sprite = null,
            answerOptions = new List<string>()
        {
            "salmon",
            "dove",
            "goose",
            "duck"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };
    }

    // public static void LoadQuestionList()
    // {
    //     if (GameControl.animalMaleName001known == false)
    //         questions.Add(animalMaleName001);

    //     if (!GameControl.animalMaleName002known)
    //         questions.Add(animalMaleName002);

    //     if (!GameControl.animalMaleName003known)
    //         questions.Add(animalName003);

    //     if (!GameControl.animalMaleName004known)
    //         questions.Add(animalMaleName004);

    //     questions = questions.OrderBy(x => System.Guid.NewGuid()).ToList();
    // }
}