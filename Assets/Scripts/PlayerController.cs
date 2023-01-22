using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rigidbody2d;
    public float speed;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0) // It is positive
        {
            rigidbody2d.velocity = new Vector2(speed, 0f);
        }
        else if (Input.GetAxis("Horizontal") < 0) // It is negative
        {
            rigidbody2d.velocity = new Vector2( -speed, 0f);
        }
        else if (Input.GetAxis("Vertical") > 0) // It is positive
        {
            rigidbody2d.velocity = new Vector2( 0f, speed);
        }
        else if (Input.GetAxis("Vertical") < 0) // It is negative
        {
            rigidbody2d.velocity = new Vector2( 0f, -speed);
        }
        else if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0)
        {
           rigidbody2d.velocity = new Vector2( 0f, 0f); // stop
        }
        //else if (inputs.getkeydown(keycode.e){ if(pausedplayer){ pauseplayer = true} else if(!pauseplayer) {pauseplayer = false}
        
    } 
 
 // Update is called once per frame
    void FixedUpdate () { 
     if (Input.GetKey (KeyCode.D)) { 
         GetComponent<Rigidbody2D>().AddForce (Vector2.right * speed); 
     }
         
     if (Input.GetKey (KeyCode.A)) { 
         GetComponent<Rigidbody2D>().AddForce (Vector2.left * speed); 
     } 
     if (Input.GetKey (KeyCode.W)) { 
         GetComponent<Rigidbody2D>().AddForce (Vector2.up * speed); 
     } 
     if (Input.GetKey (KeyCode.S)) { 
         GetComponent<Rigidbody2D>().AddForce (Vector2.down * speed); 
     }
    }
    /*void move(){
    //Update acceleration
    playerTotalAcceleration  = vec3(0,0,0)
    foreach acceleration
       playerTotalAcceleration += acceleration[i] + inputAccelaration

    velocity.x += playerTotalAcceleration.x;
    velocity.y += playerTotalAcceleration.y;
    position.x += velocity.x;
    position.y += velocity.y;
    }*/
    
    private void OnTriggerEnter2D(Collider2D Other)
    {
        if ( Other.tag == "Door")
        Debug.Log("Level Complete!!!");
    }
}  