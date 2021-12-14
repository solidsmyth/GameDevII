using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldCoin : Collectables
{
    private void Start()
    {
        objName = "GoldCoin";
        pointValue = 10;
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Collision Occurred");
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Notify");
            Notify(gameObject, NotificationType.goldcoin, pointValue);
        }
    }
}
