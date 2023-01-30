using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class wallBreak: MonoBehaviour
{
    public Animator animator;
    public int hp = 3;
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
        if (Keyboard.current[Key.Space].wasPressedThisFrame && other.tag == "player")
        {
            hp --;
            if (animator.GetInteger("Hp") == 3)
            {
                animator.SetInteger("Hp", 2);
            }
            if (animator.GetInteger("Hp") == 2)
            {
                animator.SetInteger("Hp", 1);
            }
            if (animator.GetInteger("Hp") == 1)
            {
                animator.SetInteger("Hp", 0);
            }

            Debug.Log("hit");
        }
    }
}
