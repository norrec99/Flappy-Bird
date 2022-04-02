using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
  [SerializeField] GameObject obstacles;

  float lastSpawnTime;

  // Update is called once per frame
  void Update()
  {
    if (Time.time - lastSpawnTime >= 2f)
    {
      Instantiate(obstacles, new Vector3(obstacles.transform.position.x, obstacles.transform.position.y + Random.Range(-2.5f, 2.5f), obstacles.transform.position.z), Quaternion.identity);
      lastSpawnTime = Time.time;
    }
  }

}
