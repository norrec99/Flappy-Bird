using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameOver : MonoBehaviour
{
  Text gameOverText;

  // Start is called before the first frame update
  void Start()
  {
    gameOverText = GetComponent<Text>();
    gameOverText.GetComponent<Text>().enabled = false;
  }

  public void GameOverText()
  {
    gameOverText.GetComponent<Text>().enabled = true;
    gameOverText.text = "Game Over!";
  }

}
