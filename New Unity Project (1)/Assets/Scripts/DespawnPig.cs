using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnPig : MonoBehaviour
{
    private bool Despawn = false;
    private float Timer = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Despawn == true)
        {
            Timer -= Time.deltaTime;
            if (Timer <= 0)
            {
                GameObject.Find("Cannon").GetComponent<ACannonController>().RespawnPig();
                Destroy(gameObject);
                Despawn = false;
            }
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Collider" || collision.gameObject.tag == "Hinge")
        {
            Despawn = true;
        }
    }
}
