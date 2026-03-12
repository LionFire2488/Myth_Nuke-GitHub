using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadAbout()
    {
        SceneManager.LoadScene("AboutScene");
    }
}