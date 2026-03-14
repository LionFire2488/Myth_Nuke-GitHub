using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_Play_Scene : MonoBehaviour
{
    public void Load_In_Game_Scene()
    {
        SceneManager.LoadScene("In_Game");
        Score.score = 0;
    }

    public void Load_Main_Menu_Scene()
    {
        SceneManager.LoadScene("mainmenu");
    }

    public void Load_Learn_Nuclear_Scene()
    {
        SceneManager.LoadScene("LearnNuclear");
    }

    public void Load_Quiz_1_Scene()
    {
        SceneManager.LoadScene("Quiz_1");
        Quiz_Score.score = 0;
    }

    public void Load_Quiz_2_Scene()
    {
        SceneManager.LoadScene("Quiz_2");
    }

    public void Load_Quiz_3_Scene()
    {
        SceneManager.LoadScene("Quiz_3");
    }
    
    public void Load_Quiz_4_Scene()
    {
        SceneManager.LoadScene("Quiz_4");
    }
    
    public void Load_Quiz_5_Scene()
    {
        SceneManager.LoadScene("Quiz_5");
    }

    public void Load_Quiz_6_Scene()
    {
        SceneManager.LoadScene("Quiz_6");
    }

    public void Load_Quiz_7_Scene()
    {
        SceneManager.LoadScene("Quiz_7");
    }

    public void Load_Quiz_8_Scene()
    {
        SceneManager.LoadScene("Quiz_8");
    }

    public void Load_Quiz_9_Scene()
    {
        SceneManager.LoadScene("Quiz_9");
    }

    public void Load_Quiz_10_Scene()
    {
        SceneManager.LoadScene("Quiz_10");
    }

    public void Load_Final_Quiz_Scene()
    {
        SceneManager.LoadScene("Load_Final_Quiz_Scene");
    }
    
    public void Exit()
    {
        Application.Quit();
    }   
}
