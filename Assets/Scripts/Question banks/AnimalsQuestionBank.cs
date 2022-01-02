using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class AnimalsQuestionBank : Question
{
    public static List<Question> questions = new List<Question>();

    //L1

    public static Question animals001 = new Question();
    public static Question animals002 = new Question();
    public static Question animals003 = new Question();
    public static Question animals004 = new Question();
    public static Question animals005 = new Question();
    public static Question animals006 = new Question();
    public static Question animals007 = new Question();
    public static Question animals008 = new Question();
    public static Question animals009 = new Question();
    public static Question animals010 = new Question();
    public static Question animals011 = new Question();
    public static Question animals012 = new Question();
    public static Question animals013 = new Question();
    public static Question animals014 = new Question();
    public static Question animals015 = new Question();
    public static Question animals016 = new Question();
    public static Question animals017 = new Question();
    public static Question animals018 = new Question();
    public static Question animals019 = new Question();
    public static Question animals020 = new Question();
    public static Question animals021 = new Question();
    public static Question animals022 = new Question();
    public static Question animals023 = new Question();
    public static Question animals024 = new Question();
    public static Question animals025 = new Question();
    public static Question animals026 = new Question();
    public static Question animals027 = new Question();
    public static Question animals028 = new Question();
    public static Question animals029 = new Question();
    public static Question animals030 = new Question();
    public static Question animals031 = new Question();
    public static Question animals032 = new Question();
    public static Question animals033 = new Question();
    public static Question animals034 = new Question();
    public static Question animals035 = new Question();

    //L2
    public static Question animals036 = new Question();
    public static Question animals038 = new Question();
    public static Question animals039 = new Question();
    public static Question animals040 = new Question();
    public static Question animals041 = new Question();
    public static Question animals043 = new Question();
    public static Question animals044 = new Question();

    //L3
    public static Question animals052 = new Question();
    public static Question animals058 = new Question();
    public static Question animals059 = new Question();


    void Start()
    {
        animals001 = new Question()
        {
            number = 1,
            questionName = "animal",
            sprite = Resources.Load<Sprite>("Questions/Animals/Pre_A1_Starters/Animal"),
            answerOptions = new List<string>()
        {
            "animal",
            "panda",
            "swan",
            "dolphin"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Animal",
            level = 1
        };

        animals002 = new Question()
        {
            number = 2,
            questionName = "bear",
            sprite = Resources.Load<Sprite>("Questions/Animals/Pre_A1_Starters/Bear"),
            answerOptions = new List<string>()
        {
            "bear",
            "horse",
            "mouse",
            "ant"
        },
            answerBlocks = new List<char>()
        {
            'B',
            'E',
            'A',
            'R'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Bear",
            level = 1
        };

        animals003 = new Question()
        {
            number = 3,
            questionName = "bee",
            sprite = Resources.Load<Sprite>("Questions/Animals/Pre_A1_Starters/Bee"),
            answerOptions = new List<string>()
        {
            "shark",
            "panda",
            "bee",
            "dolphin"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Bee",
            level = 1
        };

        animals004 = new Question()
        {
            number = 4,
            questionName = "bird",
            sprite = Resources.Load<Sprite>("Questions/Animals/Pre_A1_Starters/Bird"),
            answerOptions = new List<string>()
        {
            "shark",
            "panda",
            "swan",
            "bird"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Bird",
            level = 1
        };

        animals005 = new Question()
        {
            number = 5,
            questionName = "cat",
            sprite = Resources.Load<Sprite>("Questions/Animals/Pre_A1_Starters/Cat"),
            answerOptions = new List<string>()
        {
            "bear",
            "dog",
            "cat",
            "horse"
        },
            answerBlocks = new List<char>()
        {
            'C',
            'A',
            'T'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Cat",
            level = 1
        };

        animals006 = new Question()
        {
            number = 6,
            questionName = "chicken",
            sprite = Resources.Load<Sprite>("Questions/Animals/Pre_A1_Starters/Chicken"),
            answerOptions = new List<string>()
        {
            "bear",
            "dog",
            "chicken",
            "horse"
        },
            answerBlocks = new List<char>()
        {
            'C',
            'H',
            'I',
            'C',
            'K',
            'E',
            'N'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Chicken",
            level = 1
        };

        animals007 = new Question()
        {
            number = 7,
            questionName = "cow",
            sprite = Resources.Load<Sprite>("Questions/Animals/Pre_A1_Starters/Cow"),
            answerOptions = new List<string>()
        {
            "cow",
            "dog",
            "cat",
            "horse"
        },
            answerBlocks = new List<char>()
        {
            'C',
            'O',
            'W'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Cow",
            level = 1
        };

        animals008 = new Question()
        {
            number = 8,
            questionName = "crocodile",
            sprite = Resources.Load<Sprite>("Questions/Animals/Pre_A1_Starters/Crocodile"),
            answerOptions = new List<string>()
        {
            "crocodile",
            "parrot",
            "lion",
            "zebra"
        },
            answerBlocks = new List<char>()
        {
            'C',
            'R',
            'O',
            'C',
            'O',
            'D',
            'I',
            'L',
            'E'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Crocodile",
            level = 1
        };

        animals009 = new Question()
        {
            number = 9,
            questionName = "dog",
            sprite = Resources.Load<Sprite>("Questions/Animals/Pre_A1_Starters/Dog"),
            answerOptions = new List<string>()
        {
            "bear",
            "dog",
            "cat",
            "horse"
        },
            answerBlocks = new List<char>()
        {
            'D',
            'O',
            'G'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Dog",
            level = 1
        };

        animals010 = new Question()
        {
            number = 10,
            questionName = "donkey",
            sprite = Resources.Load<Sprite>("Questions/Animals/Pre_A1_Starters/Donkey"),
            answerOptions = new List<string>()
        {
            "bear",
            "donkey",
            "cat",
            "horse"
        },
            answerBlocks = new List<char>()
        {
            'D',
            'O',
            'N',
            'K',
            'E',
            'Y'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Donkey",
            level = 1
        };

        animals011 = new Question()
        {
            number = 11,
            questionName = "duck",
            sprite = Resources.Load<Sprite>("Questions/Animals/Pre_A1_Starters/Duck"),
            answerOptions = new List<string>()
        {
            "duck",
            "dog",
            "cat",
            "horse"
        },
            answerBlocks = new List<char>()
        {
            'D',
            'U',
            'C',
            'K'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Duck",
            level = 1
        };

        animals012 = new Question()
        {
            number = 12,
            questionName = "elephant",
            sprite = Resources.Load<Sprite>("Questions/Animals/Pre_A1_Starters/Elephant"),
            answerOptions = new List<string>()
        {
            "tiger",
            "elephant",
            "goat",
            "chicken"
        },
            answerBlocks = new List<char>()
        {
            'E',
            'L',
            'E',
            'P',
            'H',
            'A',
            'N',
            'T'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Elephant",
            level = 1
        };

        animals013 = new Question()
        {
            number = 13,
            questionName = "fish",
            sprite = Resources.Load<Sprite>("Questions/Animals/Pre_A1_Starters/Fish"),
            answerOptions = new List<string>()
        {
            "tiger",
            "fish",
            "goat",
            "chicken"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Fish",
            level = 1
        };

        animals014 = new Question()
        {
            number = 14,
            questionName = "frog",
            sprite = Resources.Load<Sprite>("Questions/Animals/Pre_A1_Starters/Frog"),
            answerOptions = new List<string>()
        {
            "rabbit",
            "parrot",
            "pig",
            "frog"
        },
            answerBlocks = new List<char>()
        {
            'F',
            'R',
            'O',
            'G'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Frog",
            level = 1
        };

        animals015 = new Question()
        {
            number = 15,
            questionName = "giraffe",
            sprite = Resources.Load<Sprite>("Questions/Animals/Pre_A1_Starters/Giraffe"),
            answerOptions = new List<string>()
        {
            "giraffe",
            "parrot",
            "owl",
            "zebra"
        },
            answerBlocks = new List<char>()
        {
            'G',
            'I',
            'R',
            'A',
            'F',
            'F',
            'E'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Giraffe",
            level = 1
        };

        animals016 = new Question()
        {
            number = 16,
            questionName = "goat",
            sprite = Resources.Load<Sprite>("Questions/Animals/Pre_A1_Starters/Goat"),
            answerOptions = new List<string>()
        {
            "giraffe",
            "parrot",
            "owl",
            "goat"
        },
            answerBlocks = new List<char>()
        {
            'G',
            'O',
            'A',
            'T'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Goat",
            level = 1
        };

        animals018 = new Question()
        {
            number = 18,
            questionName = "horse",
            sprite = Resources.Load<Sprite>("Questions/Animals/Pre_A1_Starters/Horse"),
            answerBlocks = new List<char>()
        {
            'H',
            'O',
            'R',
            'S',
            'E'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Horse"
        };

        animals020 = new Question()
        {
            number = 20,
            questionName = "lizard",
            sprite = Resources.Load<Sprite>("Questions/Animals/Pre_A1_Starters/Lizard"),
            answerOptions = new List<string>()
        {
            "tiger",
            "elephant",
            "goat",
            "lizard"
        },
            answerBlocks = new List<char>()
        {
            'L',
            'I',
            'Z',
            'A',
            'R',
            'D'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Lizard",
            level = 1
        };



        animals021 = new Question()
        {
            number = 21,
            questionName = "monkey",
            sprite = Resources.Load<Sprite>("Questions/Animals/Pre_A1_Starters/Monkey"),
            answerOptions = new List<string>()
        {
            "monkey",
            "horse",
            "owl",
            "zebra"
        },
            answerBlocks = new List<char>()
        {
            'M',
            'O',
            'N',
            'K',
            'E',
            'Y'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Monkey",
            level = 1
        };

        animals022 = new Question()
        {
            number = 22,
            questionName = "mouse",
            sprite = Resources.Load<Sprite>("Questions/Animals/Mouse"),
            answerBlocks = new List<char>()
        {
            'M',
            'O',
            'U',
            'S',
            'E'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Mouse"
        };


        animals025 = new Question()
        {
            number = 25,
            questionName = "sheep",
            sprite = Resources.Load<Sprite>("Questions/Animals/Sheep"),
            answerBlocks = new List<char>()
        {
            'S',
            'H',
            'E',
            'E',
            'P'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Sheep"
        };


        animals026 = new Question()
        {
            number = 26,
            questionName = "snake",
            sprite = Resources.Load<Sprite>("Questions/Animals/Pre_A1_Starters/Snake"),
            answerOptions = new List<string>()
        {
            "kangaroo",
            "panda",
            "snake",
            "penguin"
        },
            answerBlocks = new List<char>()
        {
            'S',
            'N',
            'A',
            'K',
            'E'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Snake",
            level = 1
        };


        animals028 = new Question()
        {
            number = 28,
            questionName = "tiger",
            sprite = Resources.Load<Sprite>("Questions/Animals/Pre_A1_Starters/Tiger"),
            answerOptions = new List<string>()
        {
            "tiger",
            "parrot",
            "pig",
            "frog"
        },
            answerBlocks = new List<char>()
        {
            'T',
            'I',
            'G',
            'E',
            'R'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Tiger",
            level = 1
        };


        animals030 = new Question()
        {
            number = 30,
            questionName = "zebra",
            sprite = Resources.Load<Sprite>("Questions/Animals/Pre_A1_Starters/Zebra"),
            answerOptions = new List<string>()
        {
            "dog",
            "horse",
            "mouse",
            "zebra"
        },
            answerBlocks = new List<char>()
        {
            'Z',
            'E',
            'B',
            'R',
            'A'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Zebra",
            level = 1
        };










        animals032 = new Question()
        {
            number = 32,
            questionName = "bat",
            sprite = Resources.Load<Sprite>("V4/Questions/Animals/Bat"),
            answerOptions = new List<string>()
        {
            "tiger",
            "elephant",
            "bat",
            "lizard"
        },
            answerBlocks = new List<char>()
        {
            'B',
            'A',
            'T'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Bat",
            level = 2
        };

        animals034 = new Question()
        {
            number = 34,
            questionName = "dolphin",
            sprite = Resources.Load<Sprite>("V4/Questions/Animals/Dolphin"),
            answerOptions = new List<string>()
        {
            "shark",
            "panda",
            "swan",
            "dolphin"
        },
            answerBlocks = new List<char>()
        {
            'D',
            'O',
            'L',
            'P',
            'H',
            'I',
            'N'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Dolphin",
            level = 2
        };

        animals036 = new Question()
        {
            number = 36,
            questionName = "kangaroo",
            sprite = Resources.Load<Sprite>("V4/Questions/Animals/Kangaroo"),
            answerOptions = new List<string>()
        {
            "kangaroo",
            "elephant",
            "bat",
            "eagle"
        },
            answerBlocks = new List<char>()
        {
            'K',
            'A',
            'N',
            'G',
            'A',
            'R',
            'O',
            'O'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Kangaroo",
            level = 2
        };

        animals038 = new Question()
        {
            number = 38,
            questionName = "lion",
            sprite = Resources.Load<Sprite>("V4/Questions/Animals/Lion"),
            answerOptions = new List<string>()
        {
            "giraffe",
            "parrot",
            "lion",
            "zebra"
        },
            answerBlocks = new List<char>()
        {
            'L',
            'I',
            'O',
            'N'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Lion",
            level = 2
        };

        animals039 = new Question()
        {
            number = 39,
            questionName = "panda",
            sprite = Resources.Load<Sprite>("V4/Questions/Animals/Panda"),
            answerOptions = new List<string>()
        {
            "kangaroo",
            "panda",
            "bat",
            "eagle"
        },
            answerBlocks = new List<char>()
        {
            'P',
            'A',
            'N',
            'D',
            'A'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Panda",
            level = 2
        };


        animals040 = new Question()
        {
            number = 40,
            questionName = "parrot",
            sprite = Resources.Load<Sprite>("V4/Questions/Animals/Parrot"),
            answerOptions = new List<string>()
        {
            "monkey",
            "parrot",
            "owl",
            "zebra"
        },
            answerBlocks = new List<char>()
        {
            'P',
            'A',
            'R',
            'R',
            'O',
            'T'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Parrot",
            level = 2
        };

        animals041 = new Question()
        {
            number = 41,
            questionName = "penguin",
            sprite = Resources.Load<Sprite>("V4/Questions/Animals/Penguin"),
            answerOptions = new List<string>()
        {
            "kangaroo",
            "panda",
            "bat",
            "penguin"
        },
            answerBlocks = new List<char>()
        {
            'P',
            'E',
            'N',
            'G',
            'U',
            'I',
            'N'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Penguin",
            level = 2
        };


        animals043 = new Question()
        {
            number = 43,
            questionName = "rabbit",
            sprite = Resources.Load<Sprite>("V4/Questions/Animals/Rabbit"),
            answerOptions = new List<string>()
        {
            "rabbit",
            "parrot",
            "pig",
            "donkey"
        },
            answerBlocks = new List<char>()
        {
            'R',
            'A',
            'B',
            'B',
            'I',
            'T'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Rabbit",
            level = 2
        };

        animals044 = new Question()
        {
            number = 44,
            questionName = "shark",
            sprite = Resources.Load<Sprite>("V4/Questions/Animals/Shark"),
            answerOptions = new List<string>()
        {
            "shark",
            "panda",
            "swan",
            "sheep"
        },
            answerBlocks = new List<char>()
        {
            'S',
            'H',
            'A',
            'R',
            'K'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Shark",
            level = 2
        };







        //L3

        animals052 = new Question()
        {
            number = 52,
            questionName = "eagle",
            sprite = Resources.Load<Sprite>("V4/Questions/Animals/Eagle"),
            answerOptions = new List<string>()
        {
            "tiger",
            "elephant",
            "bat",
            "eagle"
        },
            answerBlocks = new List<char>()
        {
            'E',
            'A',
            'G',
            'L',
            'E'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Eagle",
            level = 3
        };

        animals058 = new Question()
        {
            number = 58,
            questionName = "swan",
            sprite = Resources.Load<Sprite>("V4/Questions/Animals/Swan"),
            answerOptions = new List<string>()
        {
            "kangaroo",
            "panda",
            "swan",
            "sheep"
        },
            answerBlocks = new List<char>()
        {
            'S',
            'W',
            'A',
            'N'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Swan",
            level = 3
        };

        animals059 = new Question()
        {
            number = 59,
            questionName = "tortoise",
            sprite = Resources.Load<Sprite>("V4/Questions/Animals/Tortoise"),
            answerOptions = new List<string>()
        {
            "tortoise",
            "panda",
            "swan",
            "sheep"
        },
            answerBlocks = new List<char>()
        {
            'T',
            'O',
            'R',
            'T',
            'O',
            'I',
            'S',
            'E'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Tortoise",
            level = 3
        };




        LoadL1AnimalsQuestionList();
    }


    public static void LoadL1AnimalsQuestionList()
    {
        questions.Add(animals001);

        questions.Add(animals002);

        questions.Add(animals003);

        questions.Add(animals004);

        questions.Add(animals005);

        questions.Add(animals006);

        questions.Add(animals007);

        questions.Add(animals008);

        questions.Add(animals009);

        questions.Add(animals010);

        questions.Add(animals011);

        questions.Add(animals012);

        questions.Add(animals013);

        questions.Add(animals014);

        questions.Add(animals015);

        questions.Add(animals016);

        questions.Add(animals017);

        questions.Add(animals018);

        questions.Add(animals019);

        questions.Add(animals020);

        questions.Add(animals021);

        questions.Add(animals026);

        questions.Add(animals028);

        questions.Add(animals030);

        questions = questions.OrderBy(x => System.Guid.NewGuid()).ToList();

        //Debug.Log(questions.Count);
    }

    public static void LoadL2AnimalsQuestionList()
    {
        questions = questions.OrderBy(x => System.Guid.NewGuid()).ToList();
    }


    public static void LoadL3AnimalsQuestionList()
    {
        questions = questions.OrderBy(x => System.Guid.NewGuid()).ToList();
    }
}

