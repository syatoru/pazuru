using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class change : MonoBehaviour
{
    public CharMove charmove;
    private bool jamp;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        jamp = charmove.jampCheck;
        if (jamp == false)
        {
            if (gameObject.tag == "siro")
            {
                gameObject.GetComponent<Renderer>().material.color = new Color(255, 255, 255);
                this.gameObject.layer = LayerMask.NameToLayer("ground");
                GetComponent<BoxCollider2D>().enabled = true;
            }
            if (gameObject.tag == "kuro")
            {
                gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 0);
                this.gameObject.layer = LayerMask.NameToLayer("bg");
                GetComponent<BoxCollider2D>().enabled = false;
            }
        }
        else
        {
            if (gameObject.tag == "siro") { 
            gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 0);
                this.gameObject.layer = LayerMask.NameToLayer("bg");
                GetComponent<BoxCollider2D>().enabled = false;
            }
            if (gameObject.tag == "kuro") { 
            gameObject.GetComponent<Renderer>().material.color = new Color(255, 255, 255);
                this.gameObject.layer = LayerMask.NameToLayer("ground");
                GetComponent<BoxCollider2D>().enabled = true;
            }
        }
    }
}
