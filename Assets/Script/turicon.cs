using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class turicon : MonoBehaviour
{
    public Animator ani;
    int kiri=0;
    int count;
    static public int fish;
    static public float a;




    // Start is called before the first frame update
    void Start()
    {
        count = Random.Range(6, 10);
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.A)) 
        {
            kiri = 0;
            count--;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            kiri = 1;
            count--;
        }
        
        if(count == 0)
        {
            gagicon.btcon = true;
            fish = 1;
            
            if (fish == 1)
            {
                a++;
            }
            Destroy(gameObject);
            

        }

        switch (kiri)
        {
            case 0:
                ani.Play("turianicon");
                break;
                case 1:
                ani.Play("turi2");
                break;
        }

    }
   
}
