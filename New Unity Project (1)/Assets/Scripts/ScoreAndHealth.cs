using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAndHealth : MonoBehaviour
{
    private int Health;
    // Start is called before the first frame update
    void Start()
    {
        if(this.gameObject.tag == "Bird")
        {
            Health = 5;
        }
        else if(this.gameObject.tag == "BombBird")
        {
            Health = 5;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Collider" || collision.gameObject.tag == "Hinge")
        {
            Health -= 1;
            Debug.Log("Health loss");
            if (Health <= 0)
            {
                if(this.gameObject.tag == "Bird")
                {
                    Destroy(gameObject);
                    GameObject.Find("UIandScoreManager").GetComponent<UIandScoreManager>().ScoreIncreaseBird();
                }
                else if(this.gameObject.tag == "BombBird")
                {
                    this.gameObject.GetComponent<ExplosionScript>().Explode();
                    GameObject.Find("UIandScoreManager").GetComponent<UIandScoreManager>().ScoreIncreaseBigBird();
                }
            }
        }
        else if (collision.gameObject.tag == "Player")
        {
            Health = 0;
            if (Health <= 0)
            {
                if (this.gameObject.tag == "Bird")
                {
                    Destroy(gameObject);
                    GameObject.Find("UIandScoreManager").GetComponent<UIandScoreManager>().ScoreIncreaseBird();
                }
                else if (this.gameObject.tag == "BombBird")
                {
                    this.gameObject.GetComponent<ExplosionScript>().Explode();
                    GameObject.Find("UIandScoreManager").GetComponent<UIandScoreManager>().ScoreIncreaseBigBird();
                }
            }
        }
    }
}
