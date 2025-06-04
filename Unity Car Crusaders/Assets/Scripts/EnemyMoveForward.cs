using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyMoveForward : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 40.0f;
    public float timeToLive = 1f;

    private void Start()
    {
        Destroy(gameObject, timeToLive);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > 0)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }
}
