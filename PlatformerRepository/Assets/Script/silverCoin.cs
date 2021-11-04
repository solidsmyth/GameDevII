using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class silverCoin : Collectables
{
    private void Start()
    {
        objName = "SilverCoin";
        pointValue = 5;
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
