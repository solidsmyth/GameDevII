using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinSpawner : MonoBehaviour
{
    coinPooler coinPooler1;
    CollectableRepository repository;

    private bool spawnCoins;
    
    // Start is called before the first frame update
    void Start()
    {
        spawnCoins = false;
        coinPooler1 = coinPooler.Instance;
        repository = FindObjectOfType<CollectableRepository>();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnCoins && Input.GetKeyDown(KeyCode.E))
        {
            if (coinPooler1.poolDictionary.Count > 0)
            {
                coinPooler1.SpawnFromPool("GoldCoins", this.transform.position, this.transform.rotation);
                repository.ReAssess();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            spawnCoins = true;
        }
    }
}
