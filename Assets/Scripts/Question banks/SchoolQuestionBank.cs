using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SchoolQuestionBank : Question
{
    public static List<Question> questions = new List<Question>();
    public static Question school001 = new Question();
    public static Question school002 = new Question();
    public static Question school003 = new Question();
    public static Question school004 = new Question();
    public static Question school005 = new Question();
    public static Question school006 = new Question();
    public static Question school007 = new Question();
    public static Question school008 = new Question();
    public static Question school009 = new Question();
    public static Question school010 = new Question();
    public static Question school011 = new Question();
    public static Question school012 = new Question();
    public static Question school013 = new Question();
    public static Question school014 = new Question();
    public static Question school015 = new Question();
    public static Question school016 = new Question();
    public static Question school017 = new Question();
    public static Question school018 = new Question();
    public static Question school019 = new Question();
    public static Question school020 = new Question();
    public static Question school021 = new Question();
    public static Question school022 = new Question();
    public static Question school023 = new Question();
    public static Question school024 = new Question();


    void Start()
    {
        school001 = new Question()
        {
            number = 1,
            questionName = "alphabet",
            sprite = Resources.Load<Sprite>("Questions/School/Alphabet"),
            answerOptions = new List<string>()
        {
            "bear",
            "horse",
            "mouse",
            "ant"
        },
            tags = new List<string>()
        {
            "school"
        },
            size = 1,
            answerSound = "Alphabet"
        };

        school002 = new Question()
        {
            number = 2,
            questionName = "answer",
            sprite = Resources.Load<Sprite>("Questions/School/Answer"),
            answerOptions = new List<string>()
        {
            "cat",
            "wolf",
            "mouse",
            "ant"
        },
            tags = new List<string>()
        {
            "school"
        },
            size = 1,
            answerSound = "Answer"
        };

        school003 = new Question()
        {
            number = 3,
            questionName = "ask",
            sprite = Resources.Load<Sprite>("Questions/School/Ask"),
            answerOptions = new List<string>()
        {
            "dog",
            "horse",
            "mouse",
            "zebra"
        },
            tags = new List<string>()
        {
            "school"
        },
            size = 1,
            answerSound = "Ask"
        };

        school004 = new Question()
        {
            number = 4,
            questionName = "board",
            sprite = Resources.Load<Sprite>("Questions/School/Board"),
            answerOptions = new List<string>()
        {
            "dog",
            "horse",
            "owl",
            "zebra"
        },
            tags = new List<string>()
        {
            "school"
        },
            size = 1,
            answerSound = "Board"
        };

        school005 = new Question()
        {
            number = 5,
            questionName = "book",
            sprite = Resources.Load<Sprite>("Questions/School/Book"),
            answerOptions = new List<string>()
        {
            "monkey",
            "horse",
            "owl",
            "zebra"
        },
            tags = new List<string>()
        {
            "school"
        },
            size = 1,
            answerSound = "Book"
        };

        school006 = new Question()
        {
            number = 6,
            questionName = "bookcase",
            sprite = Resources.Load<Sprite>("Questions/School/Bookcase"),
            answerOptions = new List<string>()
        {
            "monkey",
            "parrot",
            "owl",
            "zebra"
        },
            tags = new List<string>()
        {
            "school"
        },
            size = 1,
            answerSound = "bookcase"
        };

        school007 = new Question()
        {
            number = 7,
            questionName = "class",
            sprite = Resources.Load<Sprite>("Questions/School/Class"),
            answerOptions = new List<string>()
        {
            "giraffe",
            "parrot",
            "owl",
            "zebra"
        },
            tags = new List<string>()
        {
            "school"
        },
            size = 1,
            answerSound = "class"
        };

        school008 = new Question()
        {
            number = 8,
            questionName = "classroom",
            sprite = Resources.Load<Sprite>("Questions/School/Classroom"),
            answerOptions = new List<string>()
        {
            "giraffe",
            "parrot",
            "lion",
            "zebra"
        },
            tags = new List<string>()
        {
            "school"
        },
            size = 1,
            answerSound = "classroom"
        };

        school009 = new Question()
        {
            number = 9,
            questionName = "close",
            sprite = Resources.Load<Sprite>("Questions/School/Close"),
            answerOptions = new List<string>()
        {
            "crocodile",
            "parrot",
            "lion",
            "zebra"
        },
            tags = new List<string>()
        {
            "school"
        },
            size = 1,
            answerSound = "close"
        };



        school010 = new Question()
        {
            number = 10,
            questionName = "rabbit",
            sprite = Resources.Load<Sprite>("Questions/School/Rabbit"),
            answerOptions = new List<string>()
        {
            "rabbit",
            "parrot",
            "pig",
            "donkey"
        },
            tags = new List<string>()
        {
            "school"
        },
            size = 1,
            answerSound = "Rabbit"
        };

        school011 = new Question()
        {
            number = 11,
            questionName = "frog",
            sprite = Resources.Load<Sprite>("Questions/School/Frog"),
            answerOptions = new List<string>()
        {
            "rabbit",
            "parrot",
            "pig",
            "frog"
        },
            tags = new List<string>()
        {
            "school"
        },
            size = 1,
            answerSound = "Frog"
        };

        school012 = new Question()
        {
            number = 12,
            questionName = "tiger",
            sprite = Resources.Load<Sprite>("Questions/School/Tiger"),
            answerOptions = new List<string>()
        {
            "tiger",
            "parrot",
            "pig",
            "frog"
        },
            tags = new List<string>()
        {
            "school"
        },
            size = 1,
            answerSound = "Tiger"
        };


        school013 = new Question()
        {
            number = 13,
            questionName = "elephant",
            sprite = Resources.Load<Sprite>("Questions/School/Elephant"),
            answerOptions = new List<string>()
        {
            "tiger",
            "elephant",
            "goat",
            "chicken"
        },
            tags = new List<string>()
        {
            "school"
        },
            size = 1,
            answerSound = "Elephant"
        };

        school014 = new Question()
        {
            number = 14,
            questionName = "lizard",
            sprite = Resources.Load<Sprite>("Questions/School/Lizard"),
            answerOptions = new List<string>()
        {
            "tiger",
            "elephant",
            "goat",
            "lizard"
        },
            tags = new List<string>()
        {
            "school"
        },
            size = 1,
            answerSound = "Lizard"
        };

        school015 = new Question()
        {
            number = 15,
            questionName = "bat",
            sprite = Resources.Load<Sprite>("Questions/School/Bat"),
            answerOptions = new List<string>()
        {
            "tiger",
            "elephant",
            "bat",
            "lizard"
        },
            tags = new List<string>()
        {
            "school"
        },
            size = 1,
            answerSound = "Bat"
        };

        school016 = new Question()
        {
            number = 16,
            questionName = "eagle",
            sprite = Resources.Load<Sprite>("Questions/School/Eagle"),
            answerOptions = new List<string>()
        {
            "tiger",
            "elephant",
            "bat",
            "eagle"
        },
            tags = new List<string>()
        {
            "school"
        },
            size = 1,
            answerSound = "Eagle"
        };

        school017 = new Question()
        {
            number = 17,
            questionName = "kangaroo",
            sprite = Resources.Load<Sprite>("Questions/School/Kangaroo"),
            answerOptions = new List<string>()
        {
            "kangaroo",
            "elephant",
            "bat",
            "eagle"
        },
            tags = new List<string>()
        {
            "school"
        },
            size = 1,
            answerSound = "Kangaroo"
        };

        school018 = new Question()
        {
            number = 18,
            questionName = "panda",
            sprite = Resources.Load<Sprite>("Questions/School/Panda"),
            answerOptions = new List<string>()
        {
            "kangaroo",
            "panda",
            "bat",
            "eagle"
        },
            tags = new List<string>()
        {
            "school"
        },
            size = 1,
            answerSound = "Panda"
        };

        school019 = new Question()
        {
            number = 19,
            questionName = "penguin",
            sprite = Resources.Load<Sprite>("Questions/School/Penguin"),
            answerOptions = new List<string>()
        {
            "kangaroo",
            "panda",
            "bat",
            "penguin"
        },
            tags = new List<string>()
        {
            "school"
        },
            size = 1,
            answerSound = "Penguin"
        };



        school020 = new Question()
        {
            number = 20,
            questionName = "snake",
            sprite = Resources.Load<Sprite>("Questions/School/Snake"),
            answerOptions = new List<string>()
        {
            "kangaroo",
            "panda",
            "snake",
            "penguin"
        },
            tags = new List<string>()
        {
            "school"
        },
            size = 1,
            answerSound = "Snake"
        };

        school021 = new Question()
        {
            number = 21,
            questionName = "swan",
            sprite = Resources.Load<Sprite>("Questions/School/Swan"),
            answerOptions = new List<string>()
        {
            "kangaroo",
            "panda",
            "swan",
            "sheep"
        },
            tags = new List<string>()
        {
            "school"
        },
            size = 1,
            answerSound = "Swan"
        };

        school022 = new Question()
        {
            number = 22,
            questionName = "tortoise",
            sprite = Resources.Load<Sprite>("Questions/School/Tortoise"),
            answerOptions = new List<string>()
        {
            "tortoise",
            "panda",
            "swan",
            "sheep"
        },
            tags = new List<string>()
        {
            "school"
        },
            size = 1,
            answerSound = "Tortoise"
        };

        school023 = new Question()
        {
            number = 23,
            questionName = "shark",
            sprite = Resources.Load<Sprite>("Questions/School/Shark"),
            answerOptions = new List<string>()
        {
            "shark",
            "panda",
            "swan",
            "sheep"
        },
            tags = new List<string>()
        {
            "school"
        },
            size = 1,
            answerSound = "Shark"
        };

        school024 = new Question()
        {
            number = 24,
            questionName = "dolphin",
            sprite = Resources.Load<Sprite>("Questions/School/Dolphin"),
            answerOptions = new List<string>()
        {
            "shark",
            "panda",
            "swan",
            "dolphin"
        },
            tags = new List<string>()
        {
            "school"
        },
            size = 1,
            answerSound = "Dolphin"
        };

        LoadQuestionList();
    }

    public void LoadQuestionList()
    {
        // if (!GameControl.animalName004known)
        questions.Add(school001);

        //  if (!GameControl.animalName005known)
        questions.Add(school002);

        //  if (!GameControl.animalName006known)
        questions.Add(school003);

        //    if (!GameControl.animalName007known)
        questions.Add(school004);

        //  if (!GameControl.animalName008known)
        questions.Add(school005);

        //   if (!GameControl.animalName009known)
        questions.Add(school006);

        //   if (!GameControl.animalName010known)
        questions.Add(school007);

        //   if (!GameControl.animalName011known)
        questions.Add(school008);

        //   if (!GameControl.animalName012known)
        questions.Add(school009);

        //     if (!GameControl.animalName017known)
        questions.Add(school010);

        //    if (!GameControl.animalName018known)
        questions.Add(school011);

        //    if (!GameControl.animalName019known)
        questions.Add(school012);

        //     if (!GameControl.animalName022known)
        questions.Add(school013);

        //   if (!GameControl.animalName023known)
        questions.Add(school014);

        //    if (!GameControl.animalName024known)
        questions.Add(school015);

        //     if (!GameControl.animalName025known)
        questions.Add(school016);

        //    if (!GameControl.animalName026known)
        questions.Add(school017);

        //   if (!GameControl.animalName027known)
        questions.Add(school018);

        //    if (!GameControl.animalName028known)
        questions.Add(school019);

        //    if (!GameControl.animalName030known)
        questions.Add(school020);

        //   if (!GameControl.animalName031known)
        questions.Add(school021);

        //   if (!GameControl.animalName032known)
        questions.Add(school022);

        //    if (!GameControl.animalName033known)
        questions.Add(school023);

        //    if (!GameControl.animalName034known)
        questions.Add(school024);

        questions = questions.OrderBy(x => System.Guid.NewGuid()).ToList();

        //Debug.Log(questions.Count);
    }
}

