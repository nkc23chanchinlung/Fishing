using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class shop : MonoBehaviour
{
    
    public Text one;
    
    int gold;
    float fisha;
    // Start is called before the first frame update
    void Start()
    {
       

        fisha = turicon.a;
    }

    // Update is called once per frame
    void Update()
    {
        one.text = turicon.a.ToString();
        if (Input.GetKeyDown(KeyCode.B))
        {
            SceneManager.LoadScene(0);
        }
        if(Input.GetKeyDown(KeyCode.C))
        {
            SceneManager.LoadScene(2);
        }
    }
}
