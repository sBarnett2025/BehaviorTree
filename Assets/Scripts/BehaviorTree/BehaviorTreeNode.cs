using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviorTreeNode : MonoBehaviour
{
    public Agent agent;

    // Start is called before the first frame update
    public virtual void Start()
    {
         agent = transform.root.GetComponent<Agent>();
    }

    public virtual bool Run()
    {
        Debug.LogError("Empty Node");
        return false;
    }

    public virtual void Setup()
    {
        if (transform.parent.GetComponent<BehaviorTreeNode>().agent != null)
        {
            agent = transform.parent.GetComponent<BehaviorTreeNode>().agent;
        }
    }
}