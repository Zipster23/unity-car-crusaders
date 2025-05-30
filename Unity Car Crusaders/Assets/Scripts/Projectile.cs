using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject[] projectilePrefabs;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int projectileIndex = Random.Range(0, projectilePrefabs.Length);
            Instantiate(projectilePrefabs[projectileIndex], transform.position, projectilePrefabs[projectileIndex].transform.rotation);
        }
    }
}
