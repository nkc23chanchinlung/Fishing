using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.SceneManagement;
public class shopmeun : MonoBehaviour
{
    GameObject panel;
    bool shoponoff;
    public Texture2D handCursor;
   
    // Start is called before the first frame update
    void Start()
    {
        panel = GameObject.Find("shopmeun");
      
        panel.SetActive(false);
        shoponoff = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
          
            if (shoponoff==false)
            {
                panel.SetActive(true);
              
                shoponoff = true;
            }
            //else
            //{
               
            //}
        }
    }
    public void modoru()
    {
        SceneManager.LoadScene(3);
    }
}
