using UnityEngine;

public class Object_Spawner : MonoBehaviour
{
    public GameObject Object;
    public float spawnRate = 2f;
    float timer = 0f;
    public float heightOffset = 2f;

    void Start()
    {
        SpawnObject();
    }

    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnObject();
            timer = 0;
        }
    }

    void SpawnObject()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(Object, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
