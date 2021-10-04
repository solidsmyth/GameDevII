using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player" || collision.gameObject.tag == "Collider" && this.GetComponent<Rigidbody2D>().gravityScale == 0)
        {
            Debug.Log("change grav");
            this.GetComponent<Rigidbody2D>().gravityScale = 1;
        }
    }
}
