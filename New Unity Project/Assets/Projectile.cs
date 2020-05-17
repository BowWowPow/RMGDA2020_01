using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    private Color c;
    public float timeAlive, speedClamp;
    private float t;
    private PlayerInput p;
    private int pN;

    void Start()
    {
        p = this.gameObject.GetComponent<PlayerInput>();
        pN = p.playerNumber;
        t = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(t >= timeAlive)
        {
            Destroy(this.gameObject);
        }
        else
        {
            t += Time.deltaTime;
        }

        Rigidbody2D trb = transform.GetComponent<Rigidbody2D>();

        if(pN == 0)
        {
            trb.AddForce(-Vector2.left * speed);
            if (trb.velocity.y >= speedClamp)
            {
                trb.velocity = new Vector2(0f, speedClamp);
            }
        }
        else
        {
            trb.AddForce(Vector2.left * speed);
            if (trb.velocity.y <= -speedClamp)
            {
                trb.velocity = new Vector2(0f, -speedClamp);
            }
        }
    }

    public void SetColour(Color c)
    {
        this.c = c;
    }
}
