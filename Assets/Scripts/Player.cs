using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  [SerializeField] float jumpForce = 15f;


  Rigidbody2D rb;
  // Start is called before the first frame update
  void Start()
  {
    rb = GetComponent<Rigidbody2D>();
  }

  // Update is called once per frame
  void Update()
  {
    ProcessJump();

  }

  void ProcessJump()
  {
    if (Input.GetKey(KeyCode.Space))
    {
      rb.velocity = Vector2.up * jumpForce;
    }
  }

}
