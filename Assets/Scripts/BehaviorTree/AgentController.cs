using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentController : MonoBehaviour
{
    public GameObject[] objs;
    public List<Agent> agents;
    
    public BehaviorTreeNode behavior;

    // Start is called before the first frame update
    void Start()
    {
        behavior = transform.GetChild(0).GetComponent<BehaviorTreeNode>();
        behavior.Setup();

        objs = GameObject.FindGameObjectsWithTag("Agent");
        foreach (GameObject o in objs)
        {
            agents.Add(o.GetComponent<Agent>());
        }
    }

    // Update is called once per frame
    void Update()
    {
        behavior.Run();

        float msec = Time.deltaTime * 1000.0f;
        float fps = 1.0f / Time.deltaTime;
        string text = string.Format("{0:0.0} ms ({1:0.} fps)", msec, fps);
        //Debug.Log(text);

    }
}
