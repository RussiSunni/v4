using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class AnimalNamesQuestionBank : SimpleQuestion
{
    public static List<SimpleQuestion> questions = new List<SimpleQuestion>();
    public static SimpleQuestion animalName004 = new SimpleQuestion();
    public static SimpleQuestion animalName005 = new SimpleQuestion();
    public static SimpleQuestion animalName006 = new SimpleQuestion();
    public static SimpleQuestion animalName007 = new SimpleQuestion();
    public static SimpleQuestion animalName008 = new SimpleQuestion();
    public static SimpleQuestion animalName009 = new SimpleQuestion();
    public static SimpleQuestion animalName010 = new SimpleQuestion();
    public static SimpleQuestion animalName011 = new SimpleQuestion();
    public static SimpleQuestion animalName012 = new SimpleQuestion();
    public static SimpleQuestion animalName017 = new SimpleQuestion();
    public static SimpleQuestion animalName018 = new SimpleQuestion();
    public static SimpleQuestion animalName019 = new SimpleQuestion();
    public static SimpleQuestion animalName022 = new SimpleQuestion();
    public static SimpleQuestion animalName023 = new SimpleQuestion();
    public static SimpleQuestion animalName024 = new SimpleQuestion();
    public static SimpleQuestion animalName025 = new SimpleQuestion();
    public static SimpleQuestion animalName026 = new SimpleQuestion();
    public static SimpleQuestion animalName027 = new SimpleQuestion();
    public static SimpleQuestion animalName028 = new SimpleQuestion();
    public static SimpleQuestion animalName030 = new SimpleQuestion();
    public static SimpleQuestion animalName031 = new SimpleQuestion();
    public static SimpleQuestion animalName032 = new SimpleQuestion();
    public static SimpleQuestion animalName033 = new SimpleQuestion();
    public static SimpleQuestion animalName034 = new SimpleQuestion();


    void Start()
    {
        animalName004 = new SimpleQuestion()
        {
            number = 4,
            questionName = "bear",
            sprite = Resources.Load<Sprite>("Questions/Animals/Bear"),
            answerOptions = new List<string>()
        {
            "bear",
            "horse",
            "mouse",
            "ant"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Bear"
        };

        animalName005 = new SimpleQuestion()
        {
            number = 5,
            questionName = "wolf",
            sprite = Resources.Load<Sprite>("Questions/Animals/Wolf"),
            answerOptions = new List<string>()
        {
            "cat",
            "wolf",
            "mouse",
            "ant"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Wolf"
        };

        animalName006 = new SimpleQuestion()
        {
            number = 6,
            questionName = "zebra",
            sprite = Resources.Load<Sprite>("Questions/Animals/Zebra"),
            answerOptions = new List<string>()
        {
            "dog",
            "horse",
            "mouse",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Zebra"
        };

        animalName007 = new SimpleQuestion()
        {
            number = 7,
            questionName = "owl",
            sprite = Resources.Load<Sprite>("Questions/Animals/Owl"),
            answerOptions = new List<string>()
        {
            "dog",
            "horse",
            "owl",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Owl"
        };

        animalName008 = new SimpleQuestion()
        {
            number = 8,
            questionName = "monkey",
            sprite = Resources.Load<Sprite>("Questions/Animals/Monkey"),
            answerOptions = new List<string>()
        {
            "monkey",
            "horse",
            "owl",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Monkey"
        };

        animalName009 = new SimpleQuestion()
        {
            number = 9,
            questionName = "parrot",
            sprite = Resources.Load<Sprite>("Questions/Animals/Parrot"),
            answerOptions = new List<string>()
        {
            "monkey",
            "parrot",
            "owl",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Parrot"
        };

        animalName010 = new SimpleQuestion()
        {
            number = 10,
            questionName = "giraffe",
            sprite = Resources.Load<Sprite>("Questions/Animals/Giraffe"),
            answerOptions = new List<string>()
        {
            "giraffe",
            "parrot",
            "owl",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Giraffe"
        };

        animalName011 = new SimpleQuestion()
        {
            number = 11,
            questionName = "lion",
            sprite = Resources.Load<Sprite>("Questions/Animals/Lion"),
            answerOptions = new List<string>()
        {
            "giraffe",
            "parrot",
            "lion",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Lion"
        };

        animalName012 = new SimpleQuestion()
        {
            number = 12,
            questionName = "crocodile",
            sprite = Resources.Load<Sprite>("Questions/Animals/Crocodile"),
            answerOptions = new List<string>()
        {
            "crocodile",
            "parrot",
            "lion",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Crocodile"
        };



        animalName017 = new SimpleQuestion()
        {
            number = 17,
            questionName = "rabbit",
            sprite = Resources.Load<Sprite>("Questions/Animals/Rabbit"),
            answerOptions = new List<string>()
        {
            "rabbit",
            "parrot",
            "pig",
            "donkey"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Rabbit"
        };

        animalName018 = new SimpleQuestion()
        {
            number = 18,
            questionName = "frog",
            sprite = Resources.Load<Sprite>("Questions/Animals/Frog"),
            answerOptions = new List<string>()
        {
            "rabbit",
            "parrot",
            "pig",
            "frog"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Frog"
        };

        animalName019 = new SimpleQuestion()
        {
            number = 19,
            questionName = "tiger",
            sprite = Resources.Load<Sprite>("Questions/Animals/Tiger"),
            answerOptions = new List<string>()
        {
            "tiger",
            "parrot",
            "pig",
            "frog"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Tiger"
        };


        animalName022 = new SimpleQuestion()
        {
            number = 22,
            questionName = "elephant",
            sprite = Resources.Load<Sprite>("Questions/Animals/Elephant"),
            answerOptions = new List<string>()
        {
            "tiger",
            "elephant",
            "goat",
            "chicken"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Elephant"
        };

        animalName023 = new SimpleQuestion()
        {
            number = 23,
            questionName = "lizard",
            sprite = Resources.Load<Sprite>("Questions/Animals/Lizard"),
            answerOptions = new List<string>()
        {
            "tiger",
            "elephant",
            "goat",
            "lizard"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Lizard"
        };

        animalName024 = new SimpleQuestion()
        {
            number = 24,
            questionName = "bat",
            sprite = Resources.Load<Sprite>("Questions/Animals/Bat"),
            answerOptions = new List<string>()
        {
            "tiger",
            "elephant",
            "bat",
            "lizard"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Bat"
        };

        animalName025 = new SimpleQuestion()
        {
            number = 25,
            questionName = "eagle",
            sprite = Resources.Load<Sprite>("Questions/Animals/Eagle"),
            answerOptions = new List<string>()
        {
            "tiger",
            "elephant",
            "bat",
            "eagle"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Eagle"
        };

        animalName026 = new SimpleQuestion()
        {
            number = 26,
            questionName = "kangaroo",
            sprite = Resources.Load<Sprite>("Questions/Animals/Kangaroo"),
            answerOptions = new List<string>()
        {
            "kangaroo",
            "elephant",
            "bat",
            "eagle"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Kangaroo"
        };

        animalName027 = new SimpleQuestion()
        {
            number = 27,
            questionName = "panda",
            sprite = Resources.Load<Sprite>("Questions/Animals/Panda"),
            answerOptions = new List<string>()
        {
            "kangaroo",
            "panda",
            "bat",
            "eagle"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Panda"
        };

        animalName028 = new SimpleQuestion()
        {
            number = 28,
            questionName = "penguin",
            sprite = Resources.Load<Sprite>("Questions/Animals/Penguin"),
            answerOptions = new List<string>()
        {
            "kangaroo",
            "panda",
            "bat",
            "penguin"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Penguin"
        };



        animalName030 = new SimpleQuestion()
        {
            number = 30,
            questionName = "snake",
            sprite = Resources.Load<Sprite>("Questions/Animals/Snake"),
            answerOptions = new List<string>()
        {
            "kangaroo",
            "panda",
            "snake",
            "penguin"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Snake"
        };

        animalName031 = new SimpleQuestion()
        {
            number = 31,
            questionName = "swan",
            sprite = Resources.Load<Sprite>("Questions/Animals/Swan"),
            answerOptions = new List<string>()
        {
            "kangaroo",
            "panda",
            "swan",
            "sheep"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Swan"
        };

        animalName032 = new SimpleQuestion()
        {
            number = 32,
            questionName = "tortoise",
            sprite = Resources.Load<Sprite>("Questions/Animals/Tortoise"),
            answerOptions = new List<string>()
        {
            "tortoise",
            "panda",
            "swan",
            "sheep"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Tortoise"
        };

        animalName033 = new SimpleQuestion()
        {
            number = 33,
            questionName = "shark",
            sprite = Resources.Load<Sprite>("Questions/Animals/Shark"),
            answerOptions = new List<string>()
        {
            "shark",
            "panda",
            "swan",
            "sheep"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Shark"
        };

        animalName034 = new SimpleQuestion()
        {
            number = 34,
            questionName = "dolphin",
            sprite = Resources.Load<Sprite>("Questions/Animals/Dolphin"),
            answerOptions = new List<string>()
        {
            "shark",
            "panda",
            "swan",
            "dolphin"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Dolphin"
        };

        LoadQuestionList();
    }

    public static void LoadQuestionList()
    {
        // if (!GameControl.animalName004known)
        questions.Add(animalName004);

        //  if (!GameControl.animalName005known)
        questions.Add(animalName005);

        //  if (!GameControl.animalName006known)
        questions.Add(animalName006);

        //    if (!GameControl.animalName007known)
        questions.Add(animalName007);

        //  if (!GameControl.animalName008known)
        questions.Add(animalName008);

        //   if (!GameControl.animalName009known)
        questions.Add(animalName009);

        //   if (!GameControl.animalName010known)
        questions.Add(animalName010);

        //   if (!GameControl.animalName011known)
        questions.Add(animalName011);

        //   if (!GameControl.animalName012known)
        questions.Add(animalName012);

        //     if (!GameControl.animalName017known)
        questions.Add(animalName017);

        //    if (!GameControl.animalName018known)
        questions.Add(animalName018);

        //    if (!GameControl.animalName019known)
        questions.Add(animalName019);

        //     if (!GameControl.animalName022known)
        questions.Add(animalName022);

        //   if (!GameControl.animalName023known)
        questions.Add(animalName023);

        //    if (!GameControl.animalName024known)
        questions.Add(animalName024);

        //     if (!GameControl.animalName025known)
        questions.Add(animalName025);

        //    if (!GameControl.animalName026known)
        questions.Add(animalName026);

        //   if (!GameControl.animalName027known)
        questions.Add(animalName027);

        //    if (!GameControl.animalName028known)
        questions.Add(animalName028);

        //    if (!GameControl.animalName030known)
        questions.Add(animalName030);

        //   if (!GameControl.animalName031known)
        questions.Add(animalName031);

        //   if (!GameControl.animalName032known)
        questions.Add(animalName032);

        //    if (!GameControl.animalName033known)
        questions.Add(animalName033);

        //    if (!GameControl.animalName034known)
        questions.Add(animalName034);

        questions = questions.OrderBy(x => System.Guid.NewGuid()).ToList();

        Debug.Log(questions.Count);
    }
}

