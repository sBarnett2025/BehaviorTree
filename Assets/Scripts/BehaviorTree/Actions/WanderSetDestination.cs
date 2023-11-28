using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderSetDestination : BehaviorTreeNode
{
    public override void Start()
    {
        agent = transform.root.GetComponent<Agent>();
    }

    public override bool Run()
    {
        


        return true;
    }
}
