using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{

    public Rigidbody rb;
    float hiz = 2.5f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");
        Vector3 kuvvet = new Vector3(yatay, 0, dikey);
        rb.AddForce(kuvvet * hiz*Time.deltaTime);
    }
}
