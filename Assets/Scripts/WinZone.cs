using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinZone : MonoBehaviour
{
    public GameObject displayHat;
    public GameObject playerHat;
    public WinUIScript winUIScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        winUIScript.WinUI();
        displayHat.SetActive(false);
        playerHat.SetActive(true);
    }
}
