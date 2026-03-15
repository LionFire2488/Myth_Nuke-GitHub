using UnityEngine;
using UnityEngine.UI;

public class Img_Scoller : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private float resetPosition = -20f;
    [SerializeField] private float startPosition = 20f;

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        if (transform.position.x <= resetPosition)
        {
            transform.position = new Vector3(startPosition,transform.position.y,transform.position.z);
        }
    }
}
