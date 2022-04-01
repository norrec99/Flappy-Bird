using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
  public float queueTime = 1.5f;
  float time = 0f;
  public float height;

  public GameObject wall;

  // Update is called once per frame
  void Update()
  {
    if (time < queueTime)
    {
      GameObject newWall = Instantiate(wall);
      //   newWall.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
      newWall.transform.position = new Vector3(0, Random.Range(-height, height), 0);

      time = 0;

      Destroy(newWall, 10f);
    }

    time += Time.deltaTime;
  }
}
