using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{

  GameOver gameOver;
  // Start is called before the first frame update
  void Start()
  {
    gameOver = FindObjectOfType<GameOver>();
  }

  // Update is called once per frame
  void Update()
  {
    ReloadLevel();
  }

  private void ReloadLevel()
  {
    if (Time.timeScale == 0f && Input.GetKey(KeyCode.Space) || Time.timeScale == 0f && Input.touchCount > 0)
    {

      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      Time.timeScale = 1f;
    }
  }
  void OnCollisionEnter2D(Collision2D other)
  {
    Time.timeScale = 0f;
    gameOver.GameOverText();
  }
}
