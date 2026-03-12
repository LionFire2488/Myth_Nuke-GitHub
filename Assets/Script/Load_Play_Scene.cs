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

    public void Load_Quiz_Scene()
    {
        SceneManager.LoadScene("Quiz");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
