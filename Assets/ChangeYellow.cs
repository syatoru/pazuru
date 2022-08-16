using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeYellow : MonoBehaviour
{
    public YellowCheck yellowcheck;
    private bool yellow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        yellow = yellowcheck.yellowCheck;
        if(yellow == true)
        {
            Destroy(gameObject);
        }
    }
}
