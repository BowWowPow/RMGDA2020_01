using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject projectile;
    public Vector3 offset;
    public float speed;
    // Start is called before the first frame update
    public void Fire()
    {
        //Do I have to do some shit like get the next value in the colour wheel beforehand? 
        GameObject temp = Instantiate(projectile, transform.position + offset, Quaternion.identity);
        
    }

}
