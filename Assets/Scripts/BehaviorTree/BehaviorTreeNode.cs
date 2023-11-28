using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviorTreeNode : MonoBehaviour
{
    protected Agent agent;

    // Start is called before the first frame update
    public virtual void Start()
    {
         agent = transform.root.GetComponent<Agent>();
    }

    public virtual bool Run()
    {
        Debug.Log("Empty Node");
        return false;
    }
}