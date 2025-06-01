using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{

    // Variables
    public float rotationSpeed;
    public GameObject onCollectEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        // Rotates the collectible
        transform.Rotate(0, rotationSpeed, 0);

    }

    private void OnTriggerEnter(Collider other) {
        
        // Makes it so that only the player can destroy the collectible. Model must have "Player" tag
        if(other.CompareTag("Player")) {

            // Destroys the collectible 
            Destroy(gameObject);

            // Instantiate the particle effect
            Instantiate(onCollectEffect, transform.position, transform.rotation);

        }
    }

    
}
