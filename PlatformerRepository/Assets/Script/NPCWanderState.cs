using UnityEngine;
using UnityEngine.AI;
using System.Collections.Generic;

public class WanderState : INPCState
{
    int moveSign = -1;
    float speed = 2;

    public INPCState DoState(NPCSearch_ClassBased npc)
    {
        DoWander(npc);
        /* if (npc.navAgent == null)
         {
             npc.nextLocation = npc.transform.position;
             npc.navAgent = npc.GetComponent<NavMeshAgent>();
         }

         DoWander(npc);

         if (CanSeeCritter(npc))
             return npc.attackState;
         else if (CanSeePickUp(npc))
             return npc.collectState;
         else
             return npc.wanderState;*/
        return npc.wanderState;
    }

    private void DoWander(NPCSearch_ClassBased npc)
    {
        //if close choose next location
        npc.gameObject.transform.position += new Vector3(Time.deltaTime*speed*moveSign, 0, 0);

    }

    public void changeSign()
    {
        moveSign *= -1;
    }

    public void setDirection(int i)
    {
        moveSign = i;
    }


}
