using UnityEngine;
using TMPro;

public class Show_Quiz_Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    void Start()
    {
        scoreText.text = Quiz_Score.score+"/10";
    }

}
