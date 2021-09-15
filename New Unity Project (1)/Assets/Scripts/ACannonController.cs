using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACannonController : MonoBehaviour
{
    public Camera MainCamera;
    public Rigidbody2D Pig;
    // Start is called before the first frame update
    void Start()
    {
        Pig.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pointInWorld = new Vector3(Input.mousePosition.x, Input.mousePosition.y, -MainCamera.transform.position.z);
        Debug.Log("Mouse Position" + pointInWorld);
        Vector3 mousePointInWorld = MainCamera.ScreenToWorldPoint(pointInWorld);
        Debug.Log("Position in the Game World" + mousePointInWorld);

        transform.LookAt(mousePointInWorld);

        if (Input.GetMouseButton(0))
        {
            Pig.gravityScale = 1;
            Pig.transform.parent = null;
            Vector3 temp = mousePointInWorld - transform.position;
            Vector2 directionAndMagnitudeAndForce = new Vector2(temp.x,temp.y);
            Pig.AddForce(directionAndMagnitudeAndForce*10);
        }
    }
    
}
