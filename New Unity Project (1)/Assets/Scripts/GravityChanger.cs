using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityChanger : MonoBehaviour
{
    private bool grounded;
    // Start is called before the first frame update
    void Start()
    {
        if(this.gameObject.transform.position.y < 22.0f)
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player" || collision.gameObject.tag == "Collider" && this.GetComponent<Rigidbody2D>().gravityScale == 0)
        {
            Debug.Log("change grav");
            this.GetComponent<Rigidbody2D>().gravityScale = 1;
        }
        if(collision.gameObject.tag == "Ground" && grounded == false)
        {
            Debug.Log("grounded");
            grounded = true;
            GameObject.Find("UIandScoreManager").GetComponent<UIandScoreManager>().ScoreIncrease();
        }
    }
}
