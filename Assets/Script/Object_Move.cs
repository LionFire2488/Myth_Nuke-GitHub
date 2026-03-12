using UnityEngine;

public class Object_Move : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject Object;

    public float speed = 1f;
    public float deadZone = -14f;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if(transform.position.x < deadZone)
        {
            Destroy(Object);
        }
    }
}
