using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esc : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape)) FadeManager.Instance.LoadScene("title", 0.3f);
    }
}
