using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyMoveForward : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 40.0f;

    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > 0)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
