using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public GameObject onCollectEffect;
    public GameObject onCollectSoundEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        Instantiate(onCollectEffect, transform.position, transform.rotation);
        Instantiate(onCollectSoundEffect, transform.position, transform.rotation);
        Destroy(other.gameObject);
        Destroy(gameObject);

    }
}
