using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour
{
    public BehaviorTreeNode behavior;

    // behavior variables-----
    public float detectionRadius;
    public Transform playerPosition;

    public Vector3 moveTo;
    public float moveDistance;

    public GameObject projectilePrefab;
    public float projectileSpeed;
    public int ammo;
    

    // Start is called before the first frame update
    void Start()
    {
        behavior = transform.GetChild(0).GetComponent<BehaviorTreeNode>();
        transform.GetChild(1).localScale = new Vector3(detectionRadius * 2, detectionRadius * 2, detectionRadius * 2);
    }

    // Update is called once per frame
    void Update()
    {
        behavior.Run();

        float msec = Time.deltaTime * 1000.0f;
        float fps = 1.0f / Time.deltaTime;
        string text = string.Format("{0:0.0} ms ({1:0.} fps)", msec, fps);
        Debug.Log(text);
    }
}
