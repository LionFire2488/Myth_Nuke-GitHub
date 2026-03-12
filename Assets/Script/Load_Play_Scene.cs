using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_Play_Scene : MonoBehaviour
{
    public void Load_Scene()
    {
        SceneManager.LoadScene("In_Game");
        Score.score = 0;
    }
}
