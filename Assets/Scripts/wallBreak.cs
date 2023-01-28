using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallBreak: MonoBehaviour
{

    public int hP = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("T$$anonymous$$s will be called every frame");
        if (Input.GetKeyDown("e") && other.tag == "player")
        {
            Debug.Log("hit");
        }
    }
}
