using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentHasAmmo : BehaviorTreeNode
{
    public override void Start()
    {
        
    }

    public override bool Run()
    {
        if (agent.ammo > 0)
        {
            //Debug.Log("Has Ammo");
            return true;
        }

        //Debug.Log("Does Not Has Ammo");
        return false;
    }

    public override void Setup()
    {
        if (transform.parent.GetComponent<BehaviorTreeNode>().agent != null)
        {
            agent = transform.parent.GetComponent<BehaviorTreeNode>().agent;
        }
    }

}
