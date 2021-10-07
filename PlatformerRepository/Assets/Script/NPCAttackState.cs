using UnityEngine;
using UnityEngine.AI;

public class AttackState : INPCState
{
    int moveSign = -1;
    float speed = 3;
    public INPCState DoState(NPCSearch_ClassBased npc)
    {
        DoAttack(npc);
        return npc.attackState;
    }

 

    private void DoAttack(NPCSearch_ClassBased npc)
    {
        //if close choose next location
        npc.gameObject.transform.position += new Vector3(Time.deltaTime * speed * moveSign, 0, 0);

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
