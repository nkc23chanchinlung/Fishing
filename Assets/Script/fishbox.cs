using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fishbox : MonoBehaviour
{
    float afish;
    public GameObject kingyou;
    // Start is called before the first frame update
    void Start()
    {
        afish = turicon.a;
        

        for(int i = 0;i<turicon.a;i++)
        {
            int radX = Random.Range(-10, 10);
            int radY = Random.Range(-10, 10);
            Instantiate(kingyou, new Vector3(radX,radY,0),Quaternion.identity);
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void modoru()
    {
        SceneManager.LoadScene(3);
    }
}
