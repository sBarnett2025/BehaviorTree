using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallel : BehaviorTreeNode
{
    public List<BehaviorTreeNode> children = new List<BehaviorTreeNode>();

    // Start is called before the first frame update
    public override void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            children.Add(transform.GetChild(i).GetComponent<BehaviorTreeNode>());
        }

    }

    public override bool Run()
    {
        // TODO

        return true;
    }


}
