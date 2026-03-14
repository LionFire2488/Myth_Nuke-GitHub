using UnityEngine;

public class Trigger_Score : MonoBehaviour
{
    public static int score = 0; 

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            score += 1;
            Destroy(gameObject);
        }
    }
}