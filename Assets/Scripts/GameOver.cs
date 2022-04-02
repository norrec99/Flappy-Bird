using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameOver : MonoBehaviour
{
  [SerializeField] AudioClip gameOverSound;

  Text gameOverText;

  AudioSource audioSource;

  // Start is called before the first frame update
  void Start()
  {
    gameOverText = GetComponent<Text>();
    gameOverText.GetComponent<Text>().enabled = false;

    audioSource = GetComponent<AudioSource>();
  }

  public void GameOverText()
  {
    gameOverText.GetComponent<Text>().enabled = true;
    audioSource.PlayOneShot(gameOverSound);
    gameOverText.text = "Game Over!";
  }

}
