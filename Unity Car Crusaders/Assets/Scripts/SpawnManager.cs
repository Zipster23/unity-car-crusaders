using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    // Variables
    public GameObject enemyPrefab;
    public float[] spawnPositionsZ;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal() {
        Vector3 spawnpos = new Vector3(235, 0, spawnPositionsZ[Random.Range(0, spawnPositionsZ.Length)]);
        Instantiate(enemyPrefab, spawnpos, enemyPrefab.transform.rotation);
    }
}
