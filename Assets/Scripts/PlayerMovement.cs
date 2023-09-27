using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool conversacion;
    public float horizontalMove = 0;
    public float verticalMove = 0;
    public float runSpeedHorizontal=3;
    public float runSpeedVertical=3;
    public float runSpeed = 0;
    Rigidbody2D rigigbody2D;
    Animator animator;
    public Joystick joystick;
    // Start is called before the first frame update
    void Start()
    {
        rigigbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        verticalMove = joystick.Vertical * runSpeedVertical;
        horizontalMove = joystick.Horizontal * runSpeedHorizontal;

        transform.position += new Vector3(horizontalMove, verticalMove, 0) * Time.deltaTime * runSpeed;
        animator.SetFloat("Horizontal", horizontalMove);
        animator.SetFloat("Vertical", verticalMove);

        if(verticalMove != 0  || horizontalMove != 0){
            animator.SetBool("Exit", true);
        }
        else {animator.SetBool("Exit", false);}
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
         if(other.CompareTag("npc"))
        {
        Debug.Log("ColisionNPC");
        conversacion=true;
        }
        else{Debug.Log("NoColisionNPC");}
       
    }
    private void OnTriggerExit2D(){
        Debug.Log("No colision");
        conversacion=false;
       
    }
}
