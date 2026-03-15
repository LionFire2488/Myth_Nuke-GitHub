using UnityEngine;


public class Quiz_Score : MonoBehaviour
{
    public static int score;
    

    void Start()
    {
        Debug.Log("score : "+ score);
    }

    public void addScore()
    {
        score++;
        Debug.Log("score : " + score);
        
    }
}
