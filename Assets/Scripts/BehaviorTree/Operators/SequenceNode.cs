using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceNode : BehaviorTreeNode
{
    BehaviorTreeNode[] children;

    public override void Start()
    {
        agent = transform.root.GetComponent<Agent>();
        children = GetComponentsInChildren<BehaviorTreeNode>();
    }

    public override bool Run()
    {
        for (int i = 0; i < children.Length; i++)
        {
            if (children[i].Run())
            {
                return false;
            }
        }
        return true;
    }
}
