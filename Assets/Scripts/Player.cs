using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 0.0125f;
    public float rotateSpeed = 0.25f;
    public Transform cam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckMove();
        CheckRotate();
    }

    void CheckMove()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");

        Vector3 vel = new Vector3(hor, 0f, ver).normalized;

        if (vel.magnitude >= 0.1f)
        {
            float angel = Mathf.Atan2(vel.x, vel.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            //transform.rotation = Quaternion.Euler(0f, angel, 0f);
            Vector3 moveDir = Quaternion.Euler(0f, angel, 0f) * Vector3.forward;
            transform.position += (moveDir * moveSpeed * Time.deltaTime);
        }    
        //transform.position += vel;
    }

    void CheckRotate()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0f, -rotateSpeed, 0f);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0f, rotateSpeed, 0f);
        }


    }

}
