using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        float yatay = Input.GetAxis("Mouse X");
        float dikey = Input.GetAxis("Mouse Y");
        Vector3 kuvvet = new Vector3(yatay, 0, dikey);
        transform.position += kuvvet * speed * Time.deltaTime;
         rb.AddForce(kuvvet * Time.deltaTime * speed);

    }


}
