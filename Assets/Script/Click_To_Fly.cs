using JetBrains.Annotations;
using UnityEngine;

public class Click_To_Fly : MonoBehaviour
{
    public Rigidbody2D rb;

    public int flyFroce = 1;

    void Start()
    {
        Time.timeScale = 0;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.linearVelocity = new Vector3(0,flyFroce,0);
        }
    }
}
