using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderSetDestination : BehaviorTreeNode
{
    public Transform maxPosition;
    public Transform minPosition;

    public override void Start()
    {
        
    }

    public override bool Run()
    {
        float x = Random.Range(minPosition.position.x, maxPosition.position.x);
        float y = Random.Range(minPosition.position.y, maxPosition.position.y);
        float z = Random.Range(minPosition.position.z, maxPosition.position.z);

        Vector3 destination = new Vector3(x, y, z);
        agent.moveTo = destination;

        return true;
    }

    public override void Setup()
    {
        if (transform.parent.GetComponent<BehaviorTreeNode>().agent != null)
        {
            agent = transform.parent.GetComponent<BehaviorTreeNode>().agent;
        }
    }

}
