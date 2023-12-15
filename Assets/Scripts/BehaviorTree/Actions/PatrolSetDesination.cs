using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolSetDesination : BehaviorTreeNode
{
    public List<Transform> patrolPoints = new List<Transform>();
    int index;

    public override void Start()
    {
        index = 0;
    }

    public override bool Run()
    {
        if (index > patrolPoints.Count - 1)
        {
            index = 0;
        }
        agent.moveTo = patrolPoints[index].position;
        index++;
        
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
