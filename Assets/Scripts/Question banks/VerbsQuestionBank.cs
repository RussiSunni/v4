using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerbsQuestionBank : Question
{
    Question verb001 = new Question()
    {
        number = 1,
        questionName = "reading",
        sprite = Resources.Load<Sprite>("SimpleApp/Questions/Reading"),
        answerOptions = new List<string>()
        {
            "sister",
            "brother",
            "family",
            "reading"
        },
        tags = new List<string>()
        {
            "verbs"
        },
        size = 2
    };

    //    questions.Add(verb001);

    Question verb002 = new Question()
    {
        number = 2,
        questionName = "think",
        sprite = Resources.Load<Sprite>("SimpleApp/Questions/Think"),
        answerOptions = new List<string>()
        {
            "think",
            "brother",
            "family",
            "reading"
        },
        tags = new List<string>()
        {
            "verbs"
        },
        size = 2
    };

    //  questions.Add(verb002);

    Question verb003 = new Question()
    {
        number = 3,
        questionName = "sleep",
        sprite = Resources.Load<Sprite>("SimpleApp/Questions/Sleep"),
        answerOptions = new List<string>()
        {
            "think",
            "brother",
            "sleep",
            "reading"
        },
        tags = new List<string>()
        {
            "verbs"
        },
        size = 2
    };

    //   questions.Add(verb003);

    Question verb004 = new Question()
    {
        number = 4,
        questionName = "wake up",
        sprite = Resources.Load<Sprite>("SimpleApp/Questions/Wake up"),
        answerOptions = new List<string>()
        {
            "think",
            "wake up",
            "sleep",
            "reading"
        },
        tags = new List<string>()
        {
            "verbs"
        },
        size = 2
    };

    //  questions.Add(verb004);

    Question verb005 = new Question()
    {
        number = 5,
        questionName = "deliver",
        sprite = Resources.Load<Sprite>("SimpleApp/Questions/Deliver"),
        answerOptions = new List<string>()
        {
            "think",
            "wake up",
            "sleep",
            "deliver"
        },
        tags = new List<string>()
        {
            "verbs"
        },
        size = 2
    };

    // questions.Add(verb005);



}