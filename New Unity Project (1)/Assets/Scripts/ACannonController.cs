using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACannonController : MonoBehaviour
{
    public Camera MainCamera;
    public Rigidbody2D Pig;
    public Transform SpawnPoint;
    public GameObject PigPrefab;
    public GameObject Cparent;
    private bool inAir;
    private bool launched;
    private float Timer = 15.0f;
    private float MAX_ANGLE = 80.0f;
    private float MIN_ANGLE = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        Pig.gravityScale = 0;
        launched = false;
        inAir = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pointInWorld = new Vector3(Input.mousePosition.x, Input.mousePosition.y, -MainCamera.transform.position.z);
        //Debug.Log("Mouse Position" + pointInWorld);
        Vector3 mousePointInWorld = MainCamera.ScreenToWorldPoint(pointInWorld);
        //Debug.Log("Position in the Game World" + mousePointInWorld);
        //Debug.Log("CannonRotation" + transform.rotation);
        //transform.LookAt(mousePointInWorld);
        Vector3 temp = mousePointInWorld - transform.position;
        Vector2 directionAndMagnitudeAndForce = new Vector2(temp.x, temp.y);
        float angleOfCannon = Mathf.Acos(Vector3.Dot(Vector3.right, directionAndMagnitudeAndForce.normalized))*Mathf.Rad2Deg;
        if (angleOfCannon <= MAX_ANGLE && angleOfCannon > MIN_ANGLE && directionAndMagnitudeAndForce.y > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, angleOfCannon);
        }

        if (Input.GetMouseButton(0) && Pig != null && launched == false)
        {
            Pig.gravityScale = 1;
            Pig.transform.parent = null;
            Pig.AddForce(directionAndMagnitudeAndForce*100);
            launched = true;
            inAir = true;
        }
        if (inAir == true)
        {
            {
                Timer -= Time.deltaTime;
                Debug.Log("CountDown");
                if (Timer <= 0)
                {
                    RespawnPig();
                    inAir = false;
                    Destroy(GameObject.FindGameObjectWithTag("Player"));
                    Timer = 15.0f;
                }
                else if (Timer >= 0 && inAir == false)
                {
                    Timer = 15.0f;
                    Debug.Log("Reset1");
                }
            }
        }
        else if (inAir == false)
        {
            Timer = 15.0f;
            Debug.Log("Reset2");
        }
    }
    public void RespawnPig()
    {
        GameObject nextPig = Instantiate(PigPrefab, SpawnPoint.transform.position, SpawnPoint.transform.rotation, Cparent.transform);
        nextPig.tag = "Player";
        Pig = nextPig.GetComponent<Rigidbody2D>();
        Pig.gravityScale = 0;
        launched = false;
    }
    
}
