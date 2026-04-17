using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishcon : MonoBehaviour
{
    public Transform fish;
    float speed;
    Vector3 dir=Vector3.zero;
    int modion = 0;
    float kirikae=0;
    float snow = 0;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0.01f;
        modion = Random.Range(0, 7);
    }

    // Update is called once per frame
    void Update()
    {
        snow = Random.Range(0.7f, 0.99f);
        kirikae += Time.deltaTime;
        if (kirikae >= Random.Range(2, 10) )
        {
            modion = Random.Range(0, 7);
            kirikae = 0;
        }

        Debug.Log(kirikae);
        
        Vector3 rot = fish.eulerAngles;
        Vector3 pos = transform.position;
        
        pos.x = Mathf.Clamp(pos.x, -9f, 9f);
        pos.y = Mathf.Clamp(pos.y, -5f, 5f);
        transform.position = pos;
        

        switch (modion)
        {
            case 0:
                rot.y = 180;
                fish.eulerAngles = rot;
                transform.position += new Vector3(speed*snow, 0, 0);
                break;

                case 1:
                rot.y = 0;
                fish.eulerAngles = rot;
                transform.position += new Vector3(-speed*snow, 0, 0);
                break;

            case 2:
                rot.y = 180;
                fish.eulerAngles = rot;
                transform.position += new Vector3(speed * snow, speed * snow, 0);
                break;

            case 3:
                rot.y = 0;
                fish.eulerAngles = rot;
                transform.position += new Vector3(-speed * snow, -speed * snow, 0);
                break;

            case 4:
                rot.y = 180;
                fish.eulerAngles = rot;
                transform.position += new Vector3(0, speed * snow, 0);
                break;

            case 5:
                rot.y = 0;
                fish.eulerAngles = rot;
                transform.position += new Vector3(0, -speed * snow, 0);
                break;

            case 6:
                transform.position += new Vector3(0, 0, 0);
                break;
        }
        
    }
}
