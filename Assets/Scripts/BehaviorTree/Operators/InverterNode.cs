using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Metadata;

public class InverterNode : BehaviorTreeNode
{
    BehaviorTreeNode child;

    public override void Start()
    {
        child = this.gameObject.transform.GetChild(0).GetComponent<BehaviorTreeNode>();
    }

    public override bool Run()
    {
        return (!child.Run());
    }
}
