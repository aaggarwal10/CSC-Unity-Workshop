using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Goal : MonoBehaviour
{
    public GameObject ballSpawner;
    public GameObject ball;
    public TMP_Text tmpText;
    
    private int count = 0;
    void OnTriggerEnter(Collider other) {
      if (other.gameObject.tag == "Ball") {
        ball.transform.position = ballSpawner.transform.position;
        ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
        ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        count += 1;
        tmpText.text = "Score: " + count;
      }
    }
}
