using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator animator;
    Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
	body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        body.velocity = new Vector2(horizontal * 2.5f, vertical * 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal", horizontal);
        animator.SetFloat("Vertical", vertical);   
    }
}
