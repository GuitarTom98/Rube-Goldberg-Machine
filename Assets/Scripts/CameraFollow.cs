using UnityEngine;

public class CameraFollow : MonoBehaviour {

    //The targets for the camera
    public Transform target1;
    public Transform target2;
    public Transform target3;
    public Transform target4;

    //The variables to determine the camera's position, speed and target's position
    public float smoothSpeed = 5f;
    public Vector3 offset;
    private int ActiveCam;

    private void FixedUpdate()
    {
        /*
        Finds and uses the game camera and references the target from 
        the variable "ChangeCamera" from the "CameraChange" script.
        Then uses 'if' statements to change between the different camera targets
        */
        GameObject Camera = GameObject.Find("Main Camera");
        CameraChange cameraChange = Camera.GetComponent<CameraChange>();
        ActiveCam = CameraChange.ChangeCamera;

        if (ActiveCam == 0) {

            Vector3 desiredPosition = target1.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
            transform.position = smoothedPosition;

            transform.LookAt(target1);

        }

        if (ActiveCam == 1)
        {

            Vector3 desiredPosition = target2.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
            transform.position = smoothedPosition;

            transform.LookAt(target2);

        }

        if (ActiveCam == 2)
        {

            Vector3 desiredPosition = target3.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
            transform.position = smoothedPosition;

            transform.LookAt(target3);

        }

        if (ActiveCam == 3)
        {

            Vector3 desiredPosition = target4.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
            transform.position = smoothedPosition;

            transform.LookAt(target4);

        }

    }

}
