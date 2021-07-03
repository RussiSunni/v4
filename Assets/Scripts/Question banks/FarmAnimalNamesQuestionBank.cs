using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class FarmAnimalNamesQuestionBank : MonoBehaviour
{
    public static List<SimpleQuestion> questions = new List<SimpleQuestion>();
    public static SimpleQuestion animalName001 = new SimpleQuestion();
    public static SimpleQuestion animalName002 = new SimpleQuestion();
    public static SimpleQuestion animalName003 = new SimpleQuestion();
    public static SimpleQuestion animalName013 = new SimpleQuestion();
    public static SimpleQuestion animalName014 = new SimpleQuestion();
    public static SimpleQuestion animalName015 = new SimpleQuestion();
    public static SimpleQuestion animalName016 = new SimpleQuestion();
    public static SimpleQuestion animalName020 = new SimpleQuestion();
    public static SimpleQuestion animalName021 = new SimpleQuestion();
    public static SimpleQuestion animalName029 = new SimpleQuestion();
    public static SimpleQuestion animalName035 = new SimpleQuestion();

    void Start()
    {
        animalName001 = new SimpleQuestion()
        {
            number = 1,
            questionName = "cat",
            sprite = Resources.Load<Sprite>("Questions/Animals/Cat"),
            answerOptions = new List<string>()
        {
            "bear",
            "dog",
            "cat",
            "horse"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Cat"
        };

        animalName002 = new SimpleQuestion()
        {
            number = 2,
            questionName = "dog",
            sprite = Resources.Load<Sprite>("Questions/Animals/Dog"),
            answerOptions = new List<string>()
        {
            "mouse",
            "cat",
            "duck",
            "dog"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Dog"
        };

        animalName003 = new SimpleQuestion()
        {
            number = 3,
            questionName = "horse",
            sprite = Resources.Load<Sprite>("Questions/Animals/Horse"),
            answerOptions = new List<string>()
        {
            "dog",
            "horse",
            "mouse",
            "ant"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Horse"
        };
        animalName013 = new SimpleQuestion()
        {
            number = 13,
            questionName = "cow",
            sprite = Resources.Load<Sprite>("Questions/Animals/Cow"),
            answerOptions = new List<string>()
        {
            "cow",
            "parrot",
            "lion",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Cow"
        };

        animalName014 = new SimpleQuestion()
        {
            number = 14,
            questionName = "duck",
            sprite = Resources.Load<Sprite>("Questions/Animals/Duck"),
            answerOptions = new List<string>()
        {
            "cow",
            "parrot",
            "lion",
            "duck"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Duck"
        };

        animalName015 = new SimpleQuestion()
        {
            number = 15,
            questionName = "pig",
            sprite = Resources.Load<Sprite>("Questions/Animals/Pig"),
            answerOptions = new List<string>()
        {
            "cow",
            "parrot",
            "pig",
            "duck"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Pig"
        };

        animalName016 = new SimpleQuestion()
        {
            number = 16,
            questionName = "donkey",
            sprite = Resources.Load<Sprite>("Questions/Animals/Donkey"),
            answerOptions = new List<string>()
        {
            "cow",
            "parrot",
            "pig",
            "donkey"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Donkey"
        };

        animalName020 = new SimpleQuestion()
        {
            number = 20,
            questionName = "goat",
            sprite = Resources.Load<Sprite>("Questions/Animals/Goat"),
            answerOptions = new List<string>()
        {
            "tiger",
            "parrot",
            "goat",
            "frog"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Goat"
        };

        animalName021 = new SimpleQuestion()
        {
            number = 21,
            questionName = "chicken",
            sprite = Resources.Load<Sprite>("Questions/Animals/Chicken"),
            answerOptions = new List<string>()
        {
            "tiger",
            "parrot",
            "goat",
            "chicken"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Chicken"
        };

        animalName029 = new SimpleQuestion()
        {
            number = 29,
            questionName = "sheep",
            sprite = Resources.Load<Sprite>("Questions/Animals/Sheep"),
            answerOptions = new List<string>()
        {
            "kangaroo",
            "panda",
            "bat",
            "sheep"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Sheep"
        };

        animalName035 = new SimpleQuestion()
        {
            number = 35,
            questionName = "mouse",
            sprite = Resources.Load<Sprite>("Questions/Animals/Mouse"),
            answerOptions = new List<string>()
        {
            "shark",
            "panda",
            "mouse",
            "dolphin"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Mouse"
        };
    }

    public static void LoadQuestionList()
    {
        if (GameControl.animalName001known == false)
            questions.Add(animalName001);

        if (!GameControl.animalName002known)
            questions.Add(animalName002);

        if (!GameControl.animalName003known)
            questions.Add(animalName003);

        if (!GameControl.animalName013known)
            questions.Add(animalName013);

        if (!GameControl.animalName014known)
            questions.Add(animalName014);

        if (!GameControl.animalName015known)
            questions.Add(animalName015);

        if (!GameControl.animalName016known)
            questions.Add(animalName016);

        if (!GameControl.animalName020known)
            questions.Add(animalName020);

        if (!GameControl.animalName021known)
            questions.Add(animalName021);


        if (!GameControl.animalName029known)
            questions.Add(animalName029);

        if (!GameControl.animalName035known)
            questions.Add(animalName035);

        questions = questions.OrderBy(x => System.Guid.NewGuid()).ToList();
    }
}
