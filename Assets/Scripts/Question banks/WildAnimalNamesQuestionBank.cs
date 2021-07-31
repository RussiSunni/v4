using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class WildAnimalNamesQuestionBank : Question
{
    public static List<Question> questions = new List<Question>();
    public static Question wildAnimalName001 = new Question();
    public static Question wildAnimalName002 = new Question();
    public static Question wildAnimalName003 = new Question();
    public static Question wildAnimalName004 = new Question();
    public static Question wildAnimalName005 = new Question();
    public static Question wildAnimalName006 = new Question();
    public static Question wildAnimalName007 = new Question();
    public static Question wildAnimalName008 = new Question();
    public static Question wildAnimalName009 = new Question();
    public static Question wildAnimalName010 = new Question();
    public static Question wildAnimalName011 = new Question();
    public static Question wildAnimalName012 = new Question();
    public static Question wildAnimalName013 = new Question();
    public static Question wildAnimalName014 = new Question();
    public static Question wildAnimalName015 = new Question();
    public static Question wildAnimalName016 = new Question();
    public static Question wildAnimalName017 = new Question();
    public static Question wildAnimalName018 = new Question();
    public static Question wildAnimalName019 = new Question();
    public static Question wildAnimalName020 = new Question();
    public static Question wildAnimalName021 = new Question();
    public static Question wildAnimalName022 = new Question();
    public static Question wildAnimalName023 = new Question();
    public static Question wildAnimalName024 = new Question();


    void Start()
    {
        wildAnimalName001 = new Question()
        {
            number = 1,
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

        wildAnimalName002 = new Question()
        {
            number = 2,
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

        wildAnimalName003 = new Question()
        {
            number = 3,
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

        wildAnimalName004 = new Question()
        {
            number = 4,
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

        wildAnimalName005 = new Question()
        {
            number = 5,
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

        wildAnimalName006 = new Question()
        {
            number = 6,
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

        wildAnimalName007 = new Question()
        {
            number = 7,
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

        wildAnimalName008 = new Question()
        {
            number = 8,
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

        wildAnimalName009 = new Question()
        {
            number = 9,
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



        wildAnimalName010 = new Question()
        {
            number = 10,
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

        wildAnimalName011 = new Question()
        {
            number = 11,
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

        wildAnimalName012 = new Question()
        {
            number = 12,
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


        wildAnimalName013 = new Question()
        {
            number = 13,
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

        wildAnimalName014 = new Question()
        {
            number = 14,
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

        wildAnimalName015 = new Question()
        {
            number = 15,
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

        wildAnimalName016 = new Question()
        {
            number = 16,
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

        wildAnimalName017 = new Question()
        {
            number = 17,
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

        wildAnimalName018 = new Question()
        {
            number = 18,
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

        wildAnimalName019 = new Question()
        {
            number = 19,
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



        wildAnimalName020 = new Question()
        {
            number = 20,
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

        wildAnimalName021 = new Question()
        {
            number = 21,
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

        wildAnimalName022 = new Question()
        {
            number = 22,
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

        wildAnimalName023 = new Question()
        {
            number = 23,
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

        wildAnimalName024 = new Question()
        {
            number = 24,
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
        questions.Add(wildAnimalName001);

        //  if (!GameControl.animalName005known)
        questions.Add(wildAnimalName002);

        //  if (!GameControl.animalName006known)
        questions.Add(wildAnimalName003);

        //    if (!GameControl.animalName007known)
        questions.Add(wildAnimalName004);

        //  if (!GameControl.animalName008known)
        questions.Add(wildAnimalName005);

        //   if (!GameControl.animalName009known)
        questions.Add(wildAnimalName006);

        //   if (!GameControl.animalName010known)
        questions.Add(wildAnimalName007);

        //   if (!GameControl.animalName011known)
        questions.Add(wildAnimalName008);

        //   if (!GameControl.animalName012known)
        questions.Add(wildAnimalName009);

        //     if (!GameControl.animalName017known)
        questions.Add(wildAnimalName010);

        //    if (!GameControl.animalName018known)
        questions.Add(wildAnimalName011);

        //    if (!GameControl.animalName019known)
        questions.Add(wildAnimalName012);

        //     if (!GameControl.animalName022known)
        questions.Add(wildAnimalName013);

        //   if (!GameControl.animalName023known)
        questions.Add(wildAnimalName014);

        //    if (!GameControl.animalName024known)
        questions.Add(wildAnimalName015);

        //     if (!GameControl.animalName025known)
        questions.Add(wildAnimalName016);

        //    if (!GameControl.animalName026known)
        questions.Add(wildAnimalName017);

        //   if (!GameControl.animalName027known)
        questions.Add(wildAnimalName018);

        //    if (!GameControl.animalName028known)
        questions.Add(wildAnimalName019);

        //    if (!GameControl.animalName030known)
        questions.Add(wildAnimalName020);

        //   if (!GameControl.animalName031known)
        questions.Add(wildAnimalName021);

        //   if (!GameControl.animalName032known)
        questions.Add(wildAnimalName022);

        //    if (!GameControl.animalName033known)
        questions.Add(wildAnimalName023);

        //    if (!GameControl.animalName034known)
        questions.Add(wildAnimalName024);

        questions = questions.OrderBy(x => System.Guid.NewGuid()).ToList();

        //Debug.Log(questions.Count);
    }
}

