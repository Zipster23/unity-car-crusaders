using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public GameObject player;
    private Vector3 offset = new Vector3(0.048f,0.352f, -0.427f);
    void LateUpdate()
    {
      transform.position = player.transform.position + offset;  
    }
}
