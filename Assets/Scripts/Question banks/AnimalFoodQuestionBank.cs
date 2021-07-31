using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class AnimalFoodQuestionBank : Question
{
    public static List<Question> questions = new List<Question>();
    public static Question animalFood001 = new Question();
    public static Question animalFood002 = new Question();
    public static Question animalFood003 = new Question();
    public static Question animalFood004 = new Question();
    public static Question animalFood005 = new Question();
    public static Question animalFood006 = new Question();
    public static Question animalFood007 = new Question();
    private Sprite dogSprite,
                    horseSprite,
                    catSprite,
                    rabbitSprite,
                    frogSprite,
                    lionSprite,
                    tigerSprite,
                    zebraSprite,
                    elephantSprite,
                    monkeySprite,
                    chickenSprite,
                    parrotSprite,
                    cowSprite,
                    mouseSprite,
                    dolphinSprite;

    void Start()
    {
        // sprites
        dogSprite = Resources.Load<Sprite>("Questions/Animals/Dog");
        horseSprite = Resources.Load<Sprite>("Questions/Animals/Horse");
        catSprite = Resources.Load<Sprite>("Questions/Animals/Cat");
        rabbitSprite = Resources.Load<Sprite>("Questions/Animals/Rabbit");
        frogSprite = Resources.Load<Sprite>("Questions/Animals/Frog");
        lionSprite = Resources.Load<Sprite>("Questions/Animals/Lion");
        tigerSprite = Resources.Load<Sprite>("Questions/Animals/Tiger");
        zebraSprite = Resources.Load<Sprite>("Questions/Animals/Zebra");
        elephantSprite = Resources.Load<Sprite>("Questions/Animals/Elephant");
        monkeySprite = Resources.Load<Sprite>("Questions/Animals/Monkey");
        chickenSprite = Resources.Load<Sprite>("Questions/Animals/Chicken");
        parrotSprite = Resources.Load<Sprite>("Questions/Animals/Parrot");
        cowSprite = Resources.Load<Sprite>("Questions/Animals/Cow");
        mouseSprite = Resources.Load<Sprite>("Questions/Animals/Mouse");
        dolphinSprite = Resources.Load<Sprite>("Questions/Animals/Dolphin");

        animalFood001 = new Question()
        {
            number = 1,
            questionName = "carrots",
            fairyTalk = "Who likes carrots?",
            answer = null,
            answerList = new List<string>()
        {
            "horse",
            "rabbit"
        },
            answerOptionsSprites = new List<Sprite>()
            {
                dogSprite,
                horseSprite,
                catSprite,
                rabbitSprite
            },
            answerOptions = new List<string>()
            {
                "dog",
                "horse",
                "cat",
                "rabbit"
            },
            tags = new List<string>()
            {
            "animals", "food"
            },
            size = 1
        };

        animalFood002 = new Question()
        {
            number = 2,
            questionName = "meat",
            fairyTalk = "Who eats meat?",
            answer = null,
            answerList = new List<string>()
        {
            "tiger",
            "lion"
        },
            answerOptionsSprites = new List<Sprite>()
        {
                frogSprite,
                lionSprite,
                rabbitSprite,
                tigerSprite
        },
            answerOptions = new List<string>()
        {
            "frog",
            "lion",
            "rabbit",
            "tiger"
        },
            tags = new List<string>()
        {
            "animals", "food"
        },
            size = 1
        };

        animalFood003 = new Question()
        {
            number = 3,
            questionName = "cheese",
            fairyTalk = "Who eats cheese?",
            answer = "mouse",
            answerOptionsSprites = new List<Sprite>()
        {
                mouseSprite,
                dolphinSprite,
                catSprite,
                parrotSprite
        },
            answerOptions = new List<string>()
        {
            "mouse",
            "dolphin",
            "cat",
            "parrot"
        },
            tags = new List<string>()
        {
            "animals", "food"
        },
            size = 1
        };

        animalFood004 = new Question()
        {
            number = 4,
            questionName = "grass",
            fairyTalk = "Who eats grass?",
            answer = null,
            answerList = new List<string>()
        {
            "cow",
            "zebra"
        },
            answerOptionsSprites = new List<Sprite>()
        {
                zebraSprite,
                parrotSprite,
                cowSprite,
                dogSprite
        },
            answerOptions = new List<string>()
        {
            "zebra",
            "parrot",
            "cow",
            "dog"
        },
            tags = new List<string>()
        {
            "animals", "food"
        },
            size = 1
        };


        animalFood005 = new Question()
        {
            number = 5,
            questionName = "banana",
            fairyTalk = "Who eats bananas?",
            answer = "monkey",
            answerOptionsSprites = new List<Sprite>()
        {
                elephantSprite,
                chickenSprite,
                mouseSprite,
                monkeySprite
        },
            answerOptions = new List<string>()
        {
            "elephant",
            "chicken",
            "mouse",
            "monkey"
        },
            tags = new List<string>()
        {
            "animals", "food"
        },
            size = 1
        };

        animalFood006 = new Question()
        {
            number = 6,
            questionName = "bone",
            fairyTalk = "Who eats bones?",
            answer = "dog",
            answerOptionsSprites = new List<Sprite>()
        {
                lionSprite,
                dogSprite,
                mouseSprite,
                monkeySprite
        },
            answerOptions = new List<string>()
        {
            "lion",
            "dog",
            "mouse",
            "monkey"
        },
            tags = new List<string>()
        {
            "animals", "food"
        },
            size = 1
        };

        animalFood007 = new Question()
        {
            number = 7,
            questionName = "fish",
            fairyTalk = "Who eats fish?",
            answer = "dolphin",
            answerOptionsSprites = new List<Sprite>()
        {
                lionSprite,
                dolphinSprite,
                mouseSprite,
                monkeySprite
        },
            answerOptions = new List<string>()
        {
            "lion",
            "dolphin",
            "mouse",
            "monkey"
        },
            tags = new List<string>()
        {
            "animals", "food"
        },
            size = 1
        };
    }
    public static void LoadQuestionList()
    {
        if (GameControl.animalFood001known == false)
            questions.Add(animalFood001);

        if (GameControl.animalFood002known == false)
            questions.Add(animalFood002);

        if (GameControl.animalFood003known == false)
            questions.Add(animalFood003);

        if (GameControl.animalFood004known == false)
            questions.Add(animalFood004);

        if (GameControl.animalFood005known == false)
            questions.Add(animalFood005);

        if (GameControl.animalFood006known == false)
            questions.Add(animalFood006);

        if (GameControl.animalFood007known == false)
            questions.Add(animalFood007);

        questions = questions.OrderBy(x => System.Guid.NewGuid()).ToList();
    }
}