using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
  [SerializeField] float xForce = 5f;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    ProcessForward();
    Destroy(gameObject, 5f);
  }
  void ProcessForward()
  {
    transform.position += (Vector3.left * xForce) * Time.deltaTime;
  }

}
