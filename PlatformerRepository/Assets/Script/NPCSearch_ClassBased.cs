using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(GameObject))]
public class NPCSearch_ClassBased : MonoBehaviour
{
    [SerializeField]
    private string currentStateName;
    private INPCState currentState;

    public WanderState wanderState = new WanderState();
    public AttackState attackState = new AttackState();

    //public GameObject navAgent;

    //public Vector3 nextLocation;
    //public GameObject pickUpTarget;
    //public GameObject critterTarget;

    //public float wanderDistance = 10f;
    //public float pickUpDistance = 25f;

    private void OnEnable()
    {
        currentState = wanderState;
    }

    private void Start()
    {
        //StartCoroutine(movementAnimate());
    }

    // Update is called once per frame
    void Update()
    {
        currentState.DoState(this);

    }

    /* IEnumerator movementAnimate()
     {
         yield return new WaitForSeconds(Time.deltaTime);
         while
             (
          )

     }*/


    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            currentState = attackState;
            if (col.transform.position.x < transform.position.x)
            {
                currentState.setDirection(-1);
            }
            else
            {
                currentState.setDirection(1);
            }

        }
        else
        {
            if(currentState == wanderState)
            {
                currentState.changeSign();
            }
            else if (currentState == attackState)
            {
                currentState.setDirection(0);
            }

        }

        Debug.Log("POW!");
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            currentState = wanderState;

        }
    }


}