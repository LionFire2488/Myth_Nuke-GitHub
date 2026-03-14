using UnityEngine;
using TMPro;

public class Show_Play_Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    void Update()
    {
        scoreText.text = "คุณได้ "+Trigger_Score.score+" คะแนน";
    }
}
