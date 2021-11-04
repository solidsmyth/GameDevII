using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish : Collectables
{
    private void Start()
    {
        objName = "Finish";
        pointValue = 0;
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Collision Occurred");
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Notify");
            Notify(gameObject, NotificationType.finish, pointValue);
        }
    }
}
