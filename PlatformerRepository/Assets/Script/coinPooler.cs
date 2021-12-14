using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinPooler : MonoBehaviour
{
    [System.Serializable]
    public class Pool
    {
        public string tag;
        public Collectables prefab;
        public int size;
    }

    #region Singleton

    public static coinPooler Instance;

    private void Awake()
    {
        Instance = this;
    }

    #endregion

    public List<Pool> pools;
    public Dictionary<string, Queue<Collectables>> poolDictionary;

    // Start is called before the first frame update
    void Start()
    {
        poolDictionary = new Dictionary<string, Queue<Collectables>>();

        foreach (Pool pool in pools)
        {
            Queue<Collectables> collectablesPool = new Queue<Collectables>();

            for (int i = 0; i < pool.size; i++)
            {
                Collectables coin = Instantiate(pool.prefab);
                coin.gameObject.SetActive(false);
                collectablesPool.Enqueue(coin);
            }

            poolDictionary.Add(pool.tag, collectablesPool);
        }
    }

    public Collectables SpawnFromPool(string tag, Vector3 position, Quaternion rotation)
    {
        if (!poolDictionary.ContainsKey(tag))
        {
            Debug.LogWarning("Pool with tag " + tag + " doesn't exist");
            return null;
        }

            Collectables coinSpawn = poolDictionary[tag].Dequeue();
            coinSpawn.gameObject.SetActive(true);
            coinSpawn.gameObject.transform.position = position;
            coinSpawn.gameObject.transform.rotation = rotation;

            poolDictionary[tag].Enqueue(coinSpawn);
            return coinSpawn;

    }
}
