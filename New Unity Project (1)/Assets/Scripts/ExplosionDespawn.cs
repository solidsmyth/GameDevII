using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionDespawn : MonoBehaviour
{
    private float Timer = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.parent == null)
        {
            Timer -= Time.deltaTime;
            if (Timer <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
