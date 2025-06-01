using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
enemy
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 1.0f;

    public float speed = 40.0f;
    public float timeToLive = 1f;

    private void Start()
    {
        Destroy(gameObject, timeToLive);
    }

main

    // Update is called once per frame
    void Update()
    {
enemy
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        transform.Translate(Vector3.forward * Time.deltaTime * speed);  
main
    }
}
