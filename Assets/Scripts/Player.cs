using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  [SerializeField] float jumpForce = 15f;
  [SerializeField] int scorePerObstacle = 10;

  bool isStarted = false;

  ScoreBoard scoreBoard;


  Rigidbody2D rb;
  // Start is called before the first frame update
  void Start()
  {
    StartCoroutine(WaitForGravity());
    scoreBoard = FindObjectOfType<ScoreBoard>();
  }

  // Update is called once per frame
  void Update()
  {
    ProcessJump();

  }

  void ProcessJump()
  {
    if (Input.GetKey(KeyCode.Space) && isStarted)
    {
      rb.velocity = Vector2.up * jumpForce;
    }
  }

  private void OnTriggerEnter2D(Collider2D other)
  {
    if (other.gameObject.CompareTag("Score"))
    {
      scoreBoard.IncreaseScore(scorePerObstacle);
    }
  }

  IEnumerator WaitForGravity()
  {
    rb = GetComponent<Rigidbody2D>();
    rb.gravityScale = 0;
    yield return new WaitForSeconds(0.5f);
    isStarted = true;
    rb.gravityScale = 5;
  }

}
