using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gagicon : MonoBehaviour
{
    public Image gagi;
    int a = 0;
    float fill = 0.03f;
    public Button bt;
    static public bool btcon=false;
    public GameObject turi;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (btcon == true)
        {
            bt.interactable = true;
            btcon = false;
        }
        Debug.Log(btcon);
        if (gagi.fillAmount == 1f)
            a = 1;
        else if (gagi.fillAmount == 0f)
            a = 2;
        switch (a)
        {
            case 1:
                gagi.fillAmount -= fill;
                break;

            case 2:
                gagi.fillAmount += fill;
                break;

            case 3:
                fill = 0;
                break;

                
        }
    }
   public void modoru()
    {
        SceneManager.LoadScene(3);
    }
    public void qtebar()
    {
        
        if (a==1||a==2)
        {
            a = 3;
        }
        else
        {
            fill = 0.03f;
            a = 1;

        }

        if (a==3)
        {
            bt.interactable = btcon;
            Instantiate(turi);
        }



        
    }
    


}
