using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour
{
    Player player;

    // behavior variables-----
    public float detectionRadius;
    public Vector3 playerPosition;

    public Vector3 moveTo;
    public float moveDistance;

    public GameObject projectilePrefab;
    public float projectileSpeed;

    public float shotRechargeTime;
    public float timeSinceShot;

    public int ammo;
    

    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(0).localScale = new Vector3(detectionRadius * 2, detectionRadius * 2, detectionRadius * 2);
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = player.gameObject.transform.position;

        Vector3 dir = playerPosition - transform.position;
        Debug.DrawRay(transform.position, dir, Color.black);

    }
}
