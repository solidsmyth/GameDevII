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
        if (collision.gameObject.tag == "Bird")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "BombBird")
        {
            Destroy(collision.gameObject);
        }
    }
}
