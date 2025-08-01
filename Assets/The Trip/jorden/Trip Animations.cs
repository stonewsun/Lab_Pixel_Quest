using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripAnimations : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
       animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            animator.SetBool("Left/Right", true);
            animator.SetBool("Up", false);
            animator.SetBool("Down", false);
           
        }
        else if (Input.GetAxis("Vertical") > 0)
        {
            animator.SetBool("Left/Right", false);
            animator.SetBool("Up", false);
            animator.SetBool("Down", true);
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            animator.SetBool("Left/Right", false);
            animator.SetBool("Up", true);
            animator.SetBool("Down", false);
        }
        else
        {
            animator.SetBool("Left/Right", false);
            animator.SetBool("Up", false);
            animator.SetBool("Down", false) ;
           

        }
    }
}
