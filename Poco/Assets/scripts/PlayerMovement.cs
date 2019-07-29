using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody Rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float upForce = 500f;
    // Update is called once per frame
    //to keep adding a force everytime. 
    //adding time delta time to help with slowing doen the player from just zooming off at a speed that is stupid.
    void FixedUpdate()
    {
        Rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Rb.transform.position.y < 1.5) //controlling when the player can press keys and they would be applied.
        {
            if (Input.GetKey("d"))//to move right
            {
                Rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (Input.GetKey("a")) //to move left 
            {
                Rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
        }
        
        if(Input.GetKey("space")) //to make the player jump
        {
            if (Rb.transform.position.y < 1.02)
            {
                Rb.AddForce(0, upForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            }
            
        }


    }
}