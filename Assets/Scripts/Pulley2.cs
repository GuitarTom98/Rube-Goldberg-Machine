using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulley2 : MonoBehaviour {

    //The maximum amount the object can move
    public float MaxMoveAmount;

    //The maximum amount the object can rotate
    public float MaxRotAmount;

    //How far it has already moved
    float movedSoFar = 0;

    //How much it has already rotated
    float rotatedSoFar = 0;

    bool BallInTrigger = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //The amount the object is supposed to move this frame
        float amountToMoveThisFrame = 2 * Time.deltaTime;

        GameObject Trigger = GameObject.Find("Pulley Trigger Box 2");
        PulleyTrigger2 PulleyScript2 = Trigger.GetComponent<PulleyTrigger2>();
        BallInTrigger = PulleyScript2.PulleyTriggered;

        //The calculation for the object to move
        if (movedSoFar < MaxMoveAmount && BallInTrigger == true)
        {
            transform.Translate(0, amountToMoveThisFrame, 0);
            movedSoFar += amountToMoveThisFrame;
        }

        //The calculation for the object to rotate
        float amountToRotateThisFrame = -40 * Time.deltaTime;

        if (rotatedSoFar > MaxRotAmount && movedSoFar >= MaxMoveAmount)
        {
            transform.Rotate(0, 0, amountToRotateThisFrame);
            rotatedSoFar += amountToRotateThisFrame;
        }

    }
}
