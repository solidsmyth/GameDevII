using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Collider" || collision.gameObject.tag == "Hinge")
        {
            
        }
        else if (collision.gameObject.tag == "Bird")
        {

        }
        else if (collision.gameObject.tag == "BombBird")
        {

        }
    }
}
