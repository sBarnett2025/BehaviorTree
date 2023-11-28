using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentProjectile : MonoBehaviour
{
    public float moveSpeed;
    public Vector3 moveDirection;

    // Update is called once per frame
    void Update()
    {
        transform.position += moveDirection.normalized * moveSpeed * Time.deltaTime;

        DeleteIfOutside();
    }

    void DeleteIfOutside()
    {
        if (transform.position.x > 40 || transform.position.x < -40 || transform.position.z > 40 || transform.position.z < -40)
        {
            Destroy(gameObject);
        }
    }
}
