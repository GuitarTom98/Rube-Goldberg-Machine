﻿using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target1;
    public Transform target2;
    public Transform target3;
    public Transform target4;

    public float smoothSpeed = 5f;
    public Vector3 offset;
    private int ActiveCam;

    private void FixedUpdate()
    {
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
