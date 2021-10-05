using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionScript : MonoBehaviour
{
    private GameObject childObj;
    // Start is called before the first frame update
    void Start()
    {
        childObj = GameObject.Find("Explosion");
        childObj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Explode();
        }
    }
    public void Explode()
    {
        childObj.SetActive(true);
        childObj.transform.parent = null;
        Destroy(gameObject);
    }
}
