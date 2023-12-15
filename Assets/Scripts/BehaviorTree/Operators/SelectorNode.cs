using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorNode : BehaviorTreeNode
{
    public List<BehaviorTreeNode> children = new List<BehaviorTreeNode>();

    public override void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            children.Add(transform.GetChild(i).GetComponent<BehaviorTreeNode>());
        }
    }

    public override bool Run()
    {
        for (int i = 0; i < children.Count; i++)
        {
            if (children[i].Run())
            {
                return true;
            }
        }
        
        return false;
    }

    public override void Setup()
    {
        if (transform.parent.GetComponent<BehaviorTreeNode>().agent != null)
        {
            agent = transform.parent.GetComponent<BehaviorTreeNode>().agent;
        }

        foreach (BehaviorTreeNode child in children)
        {
            child.Setup();
        }
    }
}
