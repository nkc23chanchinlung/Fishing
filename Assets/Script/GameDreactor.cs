using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SearchService;
using UnityEngine.UI;

public class GameDreactor : MonoBehaviour
{
    public Text Gold;
    int gold = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Gold.text = gold.ToString();
        
    }

    public void sell()
    {

        if (turicon.a > 0)
        {
            turicon.a--;
            gold += 200;
        }
        
        
    }
}
