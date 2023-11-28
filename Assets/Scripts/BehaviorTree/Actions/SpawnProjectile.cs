using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnProjectile : BehaviorTreeNode
{
    public override void Start()
    {
        agent = transform.root.GetComponent<Agent>();
    }

    public override bool Run()
    {
        GameObject obj = Instantiate(agent.projectilePrefab, transform.position, Quaternion.identity);
        AgentProjectile projectile = obj.GetComponent<AgentProjectile>();

        Vector3 playerPos = new Vector3(agent.playerPosition.position.x, agent.playerPosition.position.y, agent.playerPosition.position.z);
        projectile.moveDirection = (playerPos - transform.position).normalized;
        projectile.moveSpeed = agent.projectileSpeed;

        agent.ammo -= 1;

        return true;
    }
}
