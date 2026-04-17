using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class neko : MonoBehaviour
{
    Vector3 dir = Vector3.zero;
    float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dir.x = Input.GetAxis("Horizontal");
        dir.y = Input.GetAxis("Vertical");
        transform.position += dir.normalized*speed*Time.deltaTime;
    }
}
