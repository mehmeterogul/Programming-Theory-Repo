using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] List<GameObject> obstacles;
    [SerializeField] List<Transform> positions;

    private float spawnRate = 1.5f;
    private float startValue = .5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startValue, spawnRate);
    }

    private void SpawnObstacle()
    {
        Instantiate(GenerateObstacle(), GeneratePosition(), Quaternion.identity);
    }

    private GameObject GenerateObstacle()
    {
        int index = Random.Range(0, obstacles.Count);
        return obstacles[index];
    }

    private Vector3 GeneratePosition()
    {
        int index = Random.Range(0, positions.Count);
        return positions[index].position;
    }
}
