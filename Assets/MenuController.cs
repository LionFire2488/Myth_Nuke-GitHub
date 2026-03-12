using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void OpenSetting()
    {
        SceneManager.LoadScene("SettingScene");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}