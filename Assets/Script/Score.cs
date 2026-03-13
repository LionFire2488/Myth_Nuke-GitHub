using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static int score = 0; 
    public TextMeshProUGUI scoreText;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            score += 1;
            scoreText.text = "Score : " + score;
            Destroy(gameObject);
        }
    }
}