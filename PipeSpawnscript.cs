using UnityEngine;

public class PillarSpawner : MonoBehaviour
{
    public GameObject pillarPrefab; // Reference to the pillar prefab
    public float spawnRate = 2f; // Time between spawns
    public float heightOffset = 3f; // Offset for pillar height

    void Start()
    {
        InvokeRepeating("SpawnPillar", 0f, spawnRate);
    }

    void SpawnPillar()
    {
        float randomHeight = Random.Range(-heightOffset, heightOffset);
        Vector3 spawnPosition = new Vector3(10f, randomHeight, 0); // Adjust X position for spawning
        Instantiate(pillarPrefab, spawnPosition, Quaternion.identity);
    }
}
