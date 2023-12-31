using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSequence : BehaviorTreeNode
{
    BehaviorTreeNode[] children;

    public override void Start()
    {
        children = GetComponentsInChildren<BehaviorTreeNode>();
    }

    public override bool Run()
    {
        randomShuffle();
        foreach (BehaviorTreeNode c in children)
        {
            if (!c.Run())
            {
                return false;
            }
        }
        return true;
    }

    void randomShuffle()
    {
        int n = children.Length;
        int k;
        while (n > 1)
        {
            k = Random.Range(0, n - 1);
            n--;
            BehaviorTreeNode temp = children[k];
            children[k] = children[n];
            children[n] = temp;
        }
    }

}

