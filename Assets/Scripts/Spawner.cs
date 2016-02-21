using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    Transform prefab;

    [SerializeField]
    float minSpawnTime;

    [SerializeField]
    float maxSpawnTime;

    void Start()
    {
        InvokeRepeating("Spawn", Random.Range(minSpawnTime, maxSpawnTime), Random.Range(minSpawnTime, maxSpawnTime));
    }

    void Update()
    {

    }

    void Spawn()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }
}
