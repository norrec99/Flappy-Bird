using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  [SerializeField] float jumpForce = 10f;
  [SerializeField] int scorePerObstacle = 10;

  [SerializeField] AudioClip jumpSound;
  [SerializeField] AudioClip collectSound;

  bool isStarted = false;

  ScoreBoard scoreBoard;
  AudioSource audioSource;


  Rigidbody2D rb;
  // Start is called before the first frame update
  void Start()
  {
    StartCoroutine(WaitForGravity());
    scoreBoard = FindObjectOfType<ScoreBoard>();
    audioSource = GetComponent<AudioSource>();
  }

  // Update is called once per frame
  void Update()
  {
    ProcessJump();

  }

  void ProcessJump()
  {
    if (Input.GetKeyDown(KeyCode.Space) && isStarted)
    {
      rb.velocity = Vector2.up * jumpForce;
      audioSource.PlayOneShot(jumpSound);

    }
  }

  private void OnTriggerEnter2D(Collider2D other)
  {
    if (other.gameObject.CompareTag("Score"))
    {
      scoreBoard.IncreaseScore(scorePerObstacle);
      audioSource.PlayOneShot(collectSound);
    }
    Destroy(other.gameObject);
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
