using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject cam;
    public GameObject car;
    public GameObject cameraRig;
    public GameObject ballCameraRig;
    public GameObject ball;

    private bool ballCam = false;
    // Update is called once per frame
    void Update() {
      SwitchTarget();
    }
    
    void LateUpdate() {
      if (ballCam) {
        BallCam();
      } else {
        CarCam();
      }
    }

    void CarCam()
    {
      cam.transform.position = cameraRig.transform.position;   
      cam.transform.LookAt(car.transform.position);
    }

    void BallCam() {
      cam.transform.position = ballCameraRig.transform.position;
      cam.transform.LookAt(ball.transform.position);
    }

    void SwitchTarget() {
      if (Input.GetKeyDown(KeyCode.Space)) {
        ballCam = !ballCam;
      }
    }
}
