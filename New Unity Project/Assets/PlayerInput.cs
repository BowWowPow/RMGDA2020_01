using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float speed, decay, yClamp;
    public int playerNumber;
    Rigidbody2D rb;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    { 
        rb = transform.GetComponent<Rigidbody2D>();
        player = this.gameObject;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(transform.position.y >= yClamp)
        {
            transform.position = new Vector2(transform.position.x, yClamp); 
        }

        if(transform.position.y <= -yClamp)
        {
            transform.position = new Vector2(transform.position.x, -yClamp);
        }

        if(playerNumber == 0)
        {
            if (Input.GetKey(KeyCode.W))
            {
                rb.AddForce(speed * Vector2.up);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                rb.AddForce(speed * -Vector2.up);
            }
            else
            {
                // slowdown.
                rb.velocity = rb.velocity * decay;
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                rb.AddForce(speed * Vector2.up);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                rb.AddForce(speed * -Vector2.up);
            }
            else
            {
                // slowdown.
                rb.velocity = rb.velocity * decay;
            }
        }
        
       
        if (Input.GetKeyUp(KeyCode.RightShift))
        {
            player.GetComponent<Shoot>().Fire();
            //Fire.
            //this.gameObject.GetComponent<Shoot>();
        }
    }
}   
