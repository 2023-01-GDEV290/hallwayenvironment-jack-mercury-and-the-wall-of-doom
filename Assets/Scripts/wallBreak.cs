using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using StarterAssets;

public class wallBreak: MonoBehaviour
{
    public Animator animator;
    public Animator playerAnimator;
    public int hp = 3;
    public GameObject midWall;
    public bool inRange;
    public MyStarterAssets starterAssets;
    private InputAction wallSmack;
    bool onCooldown = false;


    // Start is called before the first frame update
    void Start()
    {
        inRange = false;
    }

    private void Awake()
    {
        starterAssets = new MyStarterAssets();
    }

    private void OnEnable()
    {
        wallSmack = starterAssets.Player.HammerSwing;
        wallSmack.Enable();

        wallSmack.performed += WallInteract;
    }

    private void OnDisable()
    {
        wallSmack.Disable();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("T$$anonymous$$s will be called every frame");
        if (other.tag == "Player")
        {
            inRange = true;
        }
        else
        {
            inRange = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            inRange = false;
        }
    }

    private void WallInteract(InputAction.CallbackContext context)
    {
        if (onCooldown == false)
        {
            Invoke("BreakWall", 1f);
            Invoke("Cooling", 1.5f);
            playerAnimator.SetTrigger("Swing");
        }
        
    }

    private void BreakWall()
    {
        if (inRange == true)
        {
            hp--;
            if (animator.GetInteger("Hp") == 3)
            {
                animator.SetInteger("Hp", 2);
            }
            else if (animator.GetInteger("Hp") == 2)
            {
                animator.SetInteger("Hp", 1);
            }
            else if (animator.GetInteger("Hp") == 1)
            {
                animator.SetInteger("Hp", 0);
                Destroy(midWall);
            }

            Debug.Log("hit");
        }
    }

    void Cooling()
    {
        onCooldown = true;
        Invoke("CoolOff", 1.5f);
    }

    void CoolOff()
    {
        onCooldown = false;
    }

}
