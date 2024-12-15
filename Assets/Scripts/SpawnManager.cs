using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [Header("Prefabs to Spawn")]
    [SerializeField] private GameObject[] spawnPrefabs; // Array of prefabs to spawn

    [Header("Spawn Settings")]
    [SerializeField] private float spawnInterval = 2f; // Interval between spawns
    private Vector3 spawnPoint;

    private void Start()
    {
        spawnPoint = new Vector3(0, 1, 60);
        
        // Start spawning objects repeatedly
        InvokeRepeating(nameof(SpawnRandomObject), 0f, spawnInterval);
    }

    private void SpawnRandomObject()
    {
        if (spawnPrefabs.Length == 0)
        {
            Debug.LogWarning("No prefabs assigned to SpawnManager!");
            return;
        }

        // Select a random prefab
        int randomIndex = Random.Range(0, spawnPrefabs.Length);
        GameObject prefabToSpawn = spawnPrefabs[randomIndex];

        // Calculate random spawn position
        Vector3 position;
        float randomX = Random.Range(-20f, 20f); // Random X value between -20 and 20

        if (spawnPoint != null)
        {
            position = new Vector3(randomX, spawnPoint.y, spawnPoint.z);
        }
        else
        {
            position = new Vector3(randomX, transform.position.y, transform.position.z);
        }

        // Spawn the object
        Instantiate(prefabToSpawn, position, Quaternion.identity);
    }
}