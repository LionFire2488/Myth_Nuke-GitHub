using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject player;
    public GameObject deadCanvas;
    public GameObject menuCanvas;

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
        player.SetActive(false);
        deadCanvas.SetActive(true);
        menuCanvas.SetActive(false);
        Time.timeScale = 0;
    }
}
