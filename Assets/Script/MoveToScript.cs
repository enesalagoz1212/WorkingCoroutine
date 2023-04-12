using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToScript : MonoBehaviour
{
    Rigidbody rb;
    Animator _anim;
    public float speed;
    [SerializeField] private float sensivity;
    public int jumpForce;
    void Start()
    {
        rb.GetComponent<Rigidbody>();
        _anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        Movement();
    }
    void Movement()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.position += move * speed * Time.deltaTime;
        _anim.SetFloat("ileri", Input.GetAxis("Vertical"));
    }
}
