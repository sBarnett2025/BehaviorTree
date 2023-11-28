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
        float x = Random.Range(-40, 40);
        float z = Random.Range(-40, 40);

        Vector3 destination = new Vector3(x, 0, z);
        agent.moveTo = destination;

        return true;
    }
}
