using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AnimalActionsQuestionBank : SimpleQuestion
{
    public static List<SimpleQuestion> questions = new List<SimpleQuestion>();
    public static SimpleQuestion animalActions001 = new SimpleQuestion();
    public static SimpleQuestion animalActions002 = new SimpleQuestion();
    public static SimpleQuestion animalActions003 = new SimpleQuestion();
    public static SimpleQuestion animalActions004 = new SimpleQuestion();
    public static SimpleQuestion animalActions005 = new SimpleQuestion();
    public static SimpleQuestion animalActions006 = new SimpleQuestion();
    public static SimpleQuestion animalActions007 = new SimpleQuestion();
    public static SimpleQuestion animalActions008 = new SimpleQuestion();
    public static SimpleQuestion animalActions009 = new SimpleQuestion();

    private Sprite tortoiseSprite,
                lizardSprite,
                mouseSprite,
                antSprite,
                snailSprite,
                rabbitSprite;

    void Start()
    {
        // sprites

        rabbitSprite = Resources.Load<Sprite>("Questions/Animals/Rabbit");
        mouseSprite = Resources.Load<Sprite>("Questions/Animals/Mouse");
        tortoiseSprite = Resources.Load<Sprite>("Questions/Animals/Tortoise");
        lizardSprite = Resources.Load<Sprite>("Questions/Animals/Lizard");

        animalActions001 = new SimpleQuestion()
        {
            number = 1,
            questionName = "shark",
            sprite = Resources.Load<Sprite>("Questions/Animals/Shark"),
            fairyTalk = "A shark",
            answer = "swims",
            answerOptions = new List<string>()
            {
                "swims",
                "runs",
                "jumps",
                null
            },
            tags = new List<string>()
            {
            "animals", "actions", "verbs"
            },
            size = 1
        };

        animalActions002 = new SimpleQuestion()
        {
            number = 2,
            questionName = "parrot",
            sprite = Resources.Load<Sprite>("Questions/Animals/Parrot"),
            fairyTalk = "A parrot can",
            answer = "fly",
            answerOptions = new List<string>()
            {
                "jump",
                "fly",
                "hop",
               null
            },
            tags = new List<string>()
            {
            "animals", "actions", "verbs"
            },
            size = 1
        };

        animalActions003 = new SimpleQuestion()
        {
            number = 3,
            questionName = "walk",
            sprite = Resources.Load<Sprite>("Questions/Verbs/Walking"),
            fairyTalk = "Who walks?",
            answer = "tortoise",
            answerOptionsSprites = new List<Sprite>()
            {
                tortoiseSprite,
                lizardSprite,
                mouseSprite
            },
            answerOptions = new List<string>()
            {
                "tortoise",
                "lizard",
                "mouse",
               null
            },
            tags = new List<string>()
            {
            "animals", "actions", "verbs"
            },
            size = 1
        };


        // tortoise joke



        animalActions004 = new SimpleQuestion()
        {
            number = 4,
            questionName = "penguin",
            sprite = Resources.Load<Sprite>("Questions/Animals/Penguin"),
            fairyTalk = "I am a bird, but I can not",
            answer = "fly",
            answerOptions = new List<string>()
            {
                "fly",
                "run",
                null,
               null
            },
            tags = new List<string>()
            {
            "animals", "actions", "verbs"
            },
            size = 1
        };


        animalActions006 = new SimpleQuestion()
        {
            number = 6,
            questionName = "hop",
            sprite = Resources.Load<Sprite>("Questions/Verbs/Hopping"),
            fairyTalk = "Who hops?",
            answer = "rabbit",
            answerOptionsSprites = new List<Sprite>()
            {
                antSprite,
                snailSprite,
                rabbitSprite
            },
            answerOptions = new List<string>()
            {
                "rabbit",
                "snail",
                "ant",
               null
            },
            tags = new List<string>()
            {
            "animals", "actions", "verbs"
            },
            size = 1
        };


        animalActions007 = new SimpleQuestion()
        {
            number = 7,
            questionName = "kangaroo",
            sprite = Resources.Load<Sprite>("Questions/Animals/Kangaroo"),
            fairyTalk = "I am a kangaroo. I can",
            answer = "jump",
            answerOptions = new List<string>()
            {
                "run",
                "swim",
                "jump",
               null
            },
            tags = new List<string>()
            {
            "animals", "actions", "verbs"
            },
            size = 1
        };

        // kangaroo joke

        // Fairy talk: "Fairy: now you have to choose two correct answers."
    }

    public static void LoadQuestionList()
    {
        questions.Add(animalActions001);
        questions.Add(animalActions002);
        questions.Add(animalActions003);
        questions.Add(animalActions004);
        questions.Add(animalActions005);
        questions.Add(animalActions006);
        questions.Add(animalActions007);

        //questions = questions.OrderBy(x => System.Guid.NewGuid()).ToList();
    }
}