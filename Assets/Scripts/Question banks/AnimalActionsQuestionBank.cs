using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AnimalActionsQuestionBank : Question
{
    public static List<Question> questions = new List<Question>();
    public static Question animalActions001 = new Question();
    public static Question animalActions002 = new Question();
    public static Question animalActions003 = new Question();
    public static Question animalActions004 = new Question();
    public static Question animalActions005 = new Question();
    public static Question animalActions006 = new Question();
    public static Question animalActions007 = new Question();
    public static Question animalActions008 = new Question();
    public static Question animalActions009 = new Question();

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

        animalActions001 = new Question()
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

        animalActions002 = new Question()
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

        animalActions003 = new Question()
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



        animalActions004 = new Question()
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


        animalActions006 = new Question()
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


        animalActions007 = new Question()
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