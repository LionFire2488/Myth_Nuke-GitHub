using UnityEngine;

public class Quiz_Score : MonoBehaviour
{
    public static int score = 0;
    void STM()
    {
        if (Input.GetMouseButtonDown(0))
        {
            score++;
            Debug.Log("score :" + score);
        }
    }
}
