using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{

  int score;

  Text scoreText;

  // Start is called before the first frame update
  void Start()
  {
    scoreText = GetComponent<Text>();
    scoreText.text = "Score: " + score;
  }

  public void IncreaseScore(int amountToIncrease)
  {
    score += amountToIncrease;
    scoreText.text = "Score: " + score.ToString();
  }

}
