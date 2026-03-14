using UnityEngine;

public class Quiz_Score : MonoBehaviour
{
    public static int score;

    void Start()
    {
        Debug.Log("score : "+ score);
    }
    
    void Update()
    {
        addScore();
    }

    public void addScore()
    {
        if (Input.GetMouseButtonDown(0))
        {
            score++;
            Debug.Log("score : " + score);
        }
    }
}
