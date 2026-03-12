using UnityEngine;

public class Death : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Object") || collision.gameObject.CompareTag("Ground"))
        {
            Die();
        }
    }

    public void Die()
    {
        Debug.Log("Dead");
        Time.timeScale = 0;
    }
}
