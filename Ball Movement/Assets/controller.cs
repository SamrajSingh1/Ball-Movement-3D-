using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class controller : MonoBehaviour
{

    // Start is called before the first
    public Text scorep1, scorep2;
    public Text res;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int k = int.Parse(scorep1.text);
        int l = int.Parse(scorep2.text);
        if ((k + l) == 15)
        {
            if (k > l)
                res.text = "Player 1 win ";
            else
                res.text = "Player 2 win ";
            Time.timeScale = 0;
        }

    }
}
