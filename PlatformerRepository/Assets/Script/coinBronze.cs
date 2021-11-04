using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinBronze : Collectables
{
    private void Start()
    {
        objName = "BronzeCoin";
        pointValue = 1;
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Collision Occurred");
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Notify");
            Notify(gameObject, NotificationType.bronzecoin, pointValue);
        }
    }

}
