using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentHasAmmo : BehaviorTreeNode
{
    public override void Start()
    {
        agent = transform.root.GetComponent<Agent>();
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
}
