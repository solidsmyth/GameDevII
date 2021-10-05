using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPigs : MonoBehaviour
{
    public Rigidbody2D Pig;
    public GameObject PigPrefab;
    public Transform SpawnPoint;
    private float Timer;
    // Start is called before the first frame update
    void Start()
    {
        Timer = Random.Range(1, 10);
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer >= 0)
        {
            Timer -= Time.deltaTime;
            if(Timer <= 0)
            {
                GameObject nextPig = Instantiate(PigPrefab, SpawnPoint.transform.position, SpawnPoint.transform.rotation);
                nextPig.gameObject.layer = 1;
                Pig = nextPig.GetComponent<Rigidbody2D>();
                Pig.gravityScale = 1;
                Timer = Random.Range(1, 10);
            }
        }
    }
}
