using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Map : MonoBehaviour
{
    public void LoadFarmStage()
    {
        SceneManager.LoadScene("Farm001");
        FarmAnimalNamesQuestionBank.LoadQuestionList();
    }

    public void LoadHouseStage()
    {

    }

    public void LoadSchoolStage()
    {
        SceneManager.LoadScene("SchoolIntro");
    }

    public void LoadForestStage()
    {
        SceneManager.LoadScene("ForestIntro");
    }
    public void LoadTownStage()
    {
        SceneManager.LoadScene("Town001");
    }

}
