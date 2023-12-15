using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnProjectile : BehaviorTreeNode
{
    public override void Start()
    {
        
    }

    public override bool Run()
    {
        GameObject obj = Instantiate(agent.projectilePrefab, agent.transform.position, Quaternion.identity);
        AgentProjectile projectile = obj.GetComponent<AgentProjectile>();

        Vector3 playerPos = new Vector3(agent.playerPosition.x, agent.playerPosition.y, agent.playerPosition.z);
        projectile.moveDirection = (playerPos - agent.transform.position).normalized;
        projectile.moveSpeed = agent.projectileSpeed;

        agent.ammo -= 1;
        agent.timeSinceShot = 0;

        return true;
    }

    public override void Setup()
    {
        if (transform.parent.GetComponent<BehaviorTreeNode>().agent != null)
        {
            agent = transform.parent.GetComponent<BehaviorTreeNode>().agent;
        }
    }

}
