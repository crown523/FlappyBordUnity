using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    public GameObject pipePrefab;
    public float spawnTime = 2;
    float spawnTimer;
    public float pipeRange = 1;
    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = spawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0)
        {
            spawnTimer = spawnTime;
            GameObject g = Instantiate(pipePrefab, transform);
            g.transform.position += new Vector3(0, Random.Range(-pipeRange, pipeRange), 0);
        }
    }
}
